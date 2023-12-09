using InventoryApiClient.Model;
using InventoryApiClient.Model.Category;
using InventoryApiClient.Model.Product;
using InventoryApiClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryApiClient.Services
{
    public class CategoryService : Service
    {
        private readonly HttpClient _httpClient;
        public CategoryService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<CategoryResponse>> ReadAllAsync()
        {
            try
            {
                EndPoint = Constant.EndPoint.category;
                //var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint);
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var apiData = JsonSerializer.Deserialize<DataResponse<List<CategoryResponse>>>(data, options)!;

                return apiData.Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null!;
            }
        }
    }
}
