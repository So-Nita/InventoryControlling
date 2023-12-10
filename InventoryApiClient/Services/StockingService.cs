using InventoryApiClient.Constant;
using InventoryApiClient.Model;
using InventoryApiClient.Model.Stocking;
using System.Text.Json;

namespace InventoryApiClient.Services;

public class StockingService : Service
{
    private readonly HttpClient _httpClient;
    public StockingService()
    {
        _httpClient = new HttpClient();
    }
    public async Task<List<StockingResponse>> ReadAllAsync()
    {
        try
        {
            EndPoint = EndPoint.product;
            var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var stockingsData = JsonSerializer.Deserialize<StockingsDataResponse>(data, options);

            return stockingsData?.Result ?? new List<StockingResponse>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new List<StockingResponse>();
        }
    }
    public async Task<StockingResponse> ReadAsync(Key key)
    {
        throw new Exception();
    }

    public async Task<DataResponse<StockCreateReq>> CreateAsync(StockCreateReq req)
    {
        try
        {
            EndPoint = EndPoint.category;
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, GetEndPoint);
            var jsonContent = JsonSerializer.Serialize(req);
            var content = new StringContent(jsonContent, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            var data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var apiData = JsonSerializer.Deserialize<DataResponse<StockCreateReq>>(data, options)!;

            return apiData!;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }
    public async Task<DataResponse<StockUpdateReq>> UpdateAsync(StockUpdateReq req)
    {
        try
        {
            EndPoint = EndPoint.product;
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Put, GetEndPoint);
            var jsonContent = JsonSerializer.Serialize(req);
            var content = new StringContent(jsonContent, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            var data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var apiData = JsonSerializer.Deserialize<DataResponse<StockUpdateReq>>(data, options)!;

            return apiData!;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }
    public async Task<bool> DeleteAsync(string Id)
    {
        try
        {
            EndPoint = EndPoint.stocking;
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Delete, GetEndPoint);
            var model = new Key()
            {
                Id = Id,
            };
            var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonContent, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
