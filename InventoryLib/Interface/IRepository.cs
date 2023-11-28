using InventoryLib.Models.Response.Product;

namespace InventoryLib.Interface;

public interface IRepository<TE> where TE : class
{
    IEnumerable<TE> GetAll();
    IQueryable<TE?> GetQueryable();

    TE? GetById(string id);

    void Add(TE entity);
    void AddRange(ICollection<TE> entities);

    void Update(TE entity);
    void UpdateRange(ICollection<TE> entities);

    void Delete(TE entity);
    void DeleteRange(ICollection<TE> entities);
}