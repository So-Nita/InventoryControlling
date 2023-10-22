using InventoryLib.DataConfiguration;
using InventoryLib.Interface;
using InventoryLib.Repository;
using Microsoft.EntityFrameworkCore.Storage;

namespace InventoryLib.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly InventoryContext _context;
    private IDbContextTransaction _trans;
    private Dictionary<string, object> _repository = new();
    public UnitOfWork(InventoryContext context)
    {
        _context = context;
    }
    public void BeginTransaction()
    {
        _trans = _context.Database.BeginTransaction();
    }

    public void CommitTransaction()
    {
        _trans.Commit();
    }
    public void RollBackTransaction()
    {
        _trans.Rollback();
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    public int Save()
    {
        return _context.SaveChanges();
    }
    public IRepository<TE> GetRepository<TE>() where TE : class
    {
        var type = typeof(TE).Name;
        if (!_repository.ContainsKey(type))
        {
            try
            {
                var repositoryType = typeof(Repository<TE>);
                var repositoryInstance = Activator.CreateInstance(repositoryType, _context);
                if (repositoryInstance == null) throw new Exception();
                _repository.Add(type, repositoryInstance);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        return (IRepository<TE>)_repository[type];
    }
    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
    }
}

