using InventoryApiClient.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryApiClient.Services
{
    public class OrderService : Service
    {
        public OrderService() { }
        public async Task<bool> Create(OrderCreateReq req)
        {
            try
            {
                var client = new HttpClient();

                EndPoint = Constant.EndPoint.order;
                var jsonContent = JsonConvert.SerializeObject(req);
                var request = new HttpRequestMessage(HttpMethod.Post, GetEndPoint);
                request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(await response.Content.ReadAsStringAsync());

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
