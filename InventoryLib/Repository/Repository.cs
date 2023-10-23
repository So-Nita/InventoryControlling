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

    public async Task<IEnumerable<TE>> GetAll()=> await _context.Set<TE>().ToListAsync();
    
    public IQueryable<TE?> GetQueryable()
    {
        return _context.Set<TE>().AsQueryable();
    }
    public async Task<TE?> GetById(string id)
    {
        return await _context.Set<TE>().FindAsync(id);
    }

    public async void Add(TE entity)
    {
        await _context.Set<TE>().AddAsync(entity);
    }
    public void Update(TE entity)
    {
        _context.Set<TE>().Update(entity);
    }
    public void Delete(TE entity)
    {
        _context.Set<TE>().Remove(entity);
    }
}


