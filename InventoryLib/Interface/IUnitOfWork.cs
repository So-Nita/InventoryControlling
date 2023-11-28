using InventoryLib.Repository;

namespace InventoryLib.Interface;

public interface IUnitOfWork
{
    void Dispose();
    void BeginTransaction();
    void RollBackTransaction();
    int Save();
    IRepository<TE> GetRepository<TE>() where TE : class;
}