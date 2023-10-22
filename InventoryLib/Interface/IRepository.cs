namespace InventoryLib.Interface;

public interface IRepository<TE> where TE : class
{
    Task<IEnumerable<TE>> GetAll();
    Task<TE?> GetById(string id);
    void Add(TE entity);
    void Update(TE entity);
    void Delete(TE entity);
}