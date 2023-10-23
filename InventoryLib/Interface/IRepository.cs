using InventoryLib.Models.Response.Product;

namespace InventoryLib.Interface;

public interface IRepository<TE> where TE : class
{
    Task<IEnumerable<TE>> GetAll();
    IQueryable<TE?> GetQueryable();

    Task<TE?> GetById(string id);
    void Add(TE entity);
    void Update(TE entity);
    void Delete(TE entity);
}