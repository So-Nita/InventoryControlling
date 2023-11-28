using System;
using InventoryLib.DataResponse;
using InventoryLib.Interface;
using InventoryLib.Models.Response;

namespace InventoryLib.Services
{
    public interface IService<TR, TC, TU> where TR : IResponse where TC : ICreateReq where TU : IUpdateReq
    {
        public Response<List<TR>> ReadAll();

        public Response<TR?> Read(Key key);

        public Response<string> Create(TC req);

        public Response<string> Update(TU req);

        public Response<string> Delete(string key);
    }
}

