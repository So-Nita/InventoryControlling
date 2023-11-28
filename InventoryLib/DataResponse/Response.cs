using System;
using InventoryLib.Constant;

namespace InventoryLib.DataResponse
{
    public class Response<T>
    {
        public int Status { get; set; }
        public int Total { get; set; }
        public T? Result { get; set; } = default;

        public static Response<T> Success(T? data = default, int total = 1)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatusType.Success,
                Total = total,
                Result = data,
            };
        }

        public static Response<T> NotFound(T? data = default, int total = 0)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatusType.NotFound,
                Total = total,
                Result = data
            };
        }
        public static Response<T> Conflict(T? data = default, int total = 0)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatusType.Fail,
                Total = total,
                Result = data
            };
        }
        public static Response<T> Fail(T? data = default, int total = 0)
        {
            return new Response<T>()
            {
                Status = (int)ResponseStatusType.Fail,
                Total = total,
                Result = data
            };
        }

    }
}

