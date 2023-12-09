using InventoryApiClient.Constant;
using InventoryApiClient.Model;
using InventoryApiClient.Model.Product;
using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace InventoryApiClient.Services;

public class ProductService : Service
{
    private readonly HttpClient _httpClient;
    public ProductService()
    {
         _httpClient = new HttpClient();
    }
    public async Task<List<ProductResponse>> ReadAllAsync()
    {
        try
        {
            EndPoint = EndPoint.product;
            var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
            var apiData = JsonSerializer.Deserialize<DataResponse<List<ProductResponse>>>(data, options)!;

            return apiData.Result!;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }

    public async Task<List<ProductResponse>> GetProductByCategory(string category)
    {
        try
        {
            var products = await ReadAllAsync();
            var result = products.Where(e=>e.CategoryId == category).ToList();
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }
    public async Task<List<ProductResponse>> CreateAsync()
    {
        try
        {
            EndPoint = EndPoint.product;
            var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var apiData = JsonSerializer.Deserialize<DataResponse<List<ProductResponse>>>(data, options)!;

            return apiData.Result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }

    public bool DeleteAsync(string productId)
    {
        try
        {
            return true;
        }catch(Exception ex) 
        {
            return false;
        }
    }
}