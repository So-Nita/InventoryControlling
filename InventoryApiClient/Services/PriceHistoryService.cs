using InventoryApiClient.Model;
using InventoryApiClient.Model.PriceHistory;
using InventoryApiClient.Model.Stocking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryApiClient.Services
{
    public class PriceHistoryService : Service
    {
        private readonly HttpClient _httpClient;
        public PriceHistoryService()
        {
            _httpClient = new HttpClient();
        }
        //public async Task<List<PriceResponse>> ReadAllAsync()
        public async Task<List<PriceHistories>> ReadAllAsync()
        {
            try
            {
                EndPoint = Constant.EndPoint.pricehistory;
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint);
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var apiData = JsonSerializer.Deserialize<DataResponse<List<PriceResponse>>>(data, options)!;

                List<PriceHistories> stockings = new();
                if (apiData.Result != null)
                {
                    foreach (var item in apiData.Result)
                    {
                        stockings.AddRange(item.PriceHistories);
                    }
                }
                //return apiData.Result;
                return stockings;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null!;
            }
        }
    }
}
