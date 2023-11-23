using System;
namespace InventoryLib.Services
{
    public interface IService<TR, TC, TU> where TR : IReadReq where TC : ICreateReq where TU : IUpdateReq
    {
        string? Create(TC req);
        List<TR> ReadAll();
        TR? Read(string key);
        string? Update(TU req);
        string? Delete(string key);
    }
}

