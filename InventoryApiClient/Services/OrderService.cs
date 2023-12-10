using InventoryApiClient.Model.Order;
using System.Text;
using Newtonsoft.Json;
using InventoryApiClient.Model;
using System.Text.Json;

namespace InventoryApiClient.Services
{
    public class OrderService : Service
    {
        private readonly HttpClient _httpClient;
        public OrderService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<OrderResponse>> ReadAllAsync()
        {

            try
            {
                EndPoint = Constant.EndPoint.order;
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint);
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var apiData = System.Text.Json.JsonSerializer.Deserialize<DataResponse<List<OrderResponse>>>(data, options)!;

                return apiData.Result!;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null!;
            }
        }
        public async Task<bool> Create(OrderCreateReq req)
        {
            try
            {
                EndPoint = Constant.EndPoint.order;
                var jsonContent = JsonConvert.SerializeObject(req);
                var request = new HttpRequestMessage(HttpMethod.Post, GetEndPoint);
                request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.SendAsync(request);
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

        public async Task<bool> DeleteAsync(string Id)
        {
            try
            {
                EndPoint = Constant.EndPoint.order;
                 
                var request = new HttpRequestMessage(HttpMethod.Delete, GetEndPoint);
                var model = new Key()
                {
                    Id = Id
                };
                var jsonContent = JsonConvert.SerializeObject(model);
                var content = new StringContent(jsonContent, null, "application/json");
                request.Content = content;
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var dataResponse = await response.Content.ReadAsStringAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }
    }
}
