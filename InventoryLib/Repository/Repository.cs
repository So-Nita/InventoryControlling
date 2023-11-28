using InventoryLib.DataConfiguration;
using InventoryLib.Interface;
using InventoryLib.Models.Response.Product;
using Microsoft.EntityFrameworkCore;

namespace InventoryLib.Repository;

public class Repository<TE> : IRepository<TE> where TE : class
{
    private readonly InventoryContext _context;

    public Repository(InventoryContext context)
    {
        _context = context;
    }

    public IEnumerable<TE> GetAll()=> _context.Set<TE>().ToList();
    
    public IQueryable<TE?> GetQueryable()
    {
        return _context.Set<TE>().AsQueryable();
    }

    public TE? GetById(string id)
    {
        return _context.Set<TE>().Find(id);
    }

    public void Add(TE entity)
    {
         _context.Set<TE>().Add(entity);
    }

    public void Update(TE entity)
    {
        _context.Set<TE>().Update(entity);
    }

    public void Delete(TE entity)
    {
        _context.Set<TE>().Remove(entity);
    }

    public void SaveChanges()
    {
        try
        {
            _context.SaveChanges();
        }
        catch { throw new ArgumentException(); }
    }

    public void AddRange(ICollection<TE> entities)
    {
        try
        {
            _context.AddRange(entities);
        }
        catch { throw new ArgumentException(); }
    }

    public void UpdateRange(ICollection<TE> entities)
    {
        try
        {
            _context.UpdateRange(entities);
        }
        catch(Exception ex) { throw new ArgumentException(ex.Message); }
    }

    public void DeleteRange(ICollection<TE> entities)
    {
        try
        {
            _context.RemoveRange(entities);
        }
        catch (Exception ex) { throw new ArgumentException(ex.Message); }
    }
}


