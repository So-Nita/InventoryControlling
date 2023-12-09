using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model
{
    public class DataResponse<T>
    {
        public int Status { get; set; }
        public int Total { get; set; }
        //public List<T> Result { get; set; } = new List<T>();
        public T? Result { get; set; }
    }
}
