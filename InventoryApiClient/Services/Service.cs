using InventoryApiClient.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Services;

public class Service 
{
    protected static string BaseUrl = "http://sonitab-001-site1.atempurl.com/api";
    protected EndPoint EndPoint { get; set; } 
    protected string GetEndPoint => BaseUrl + "/" + EndPoint;
   
}
