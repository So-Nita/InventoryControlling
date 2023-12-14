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

    public async Task<List<ProductResponse>> ReadProductSellAsync()
    {
        try
        {
            var products = await ReadAllAsync();
            var result = products.Where(e=>e.Qty>0).ToList();
            return result;
        }catch (Exception ex)
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
    public async Task<DataResponse<string>> CreateAsync(ProductCreateReq req)
    {
        try
        {
            EndPoint = EndPoint.product;
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, GetEndPoint);
            var jsonContent = JsonSerializer.Serialize(req);
            var content = new StringContent(jsonContent, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            var data = response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            var apiData = new DataResponse<string>();
            if (data.StatusCode.Equals(200))
            {
                apiData.Status = 200;
            }
           /* var data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var apiData = JsonSerializer.Deserialize<DataResponse<string>>(data, options)!;*/

            //return apiData;
            return apiData;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }
    public async Task<DataResponse<ProductResponse>> UpdateAsync(ProductUpdateReq req)
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
            var apiData = JsonSerializer.Deserialize<DataResponse<ProductResponse>>(data, options)!;

            return apiData!;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }

    public ProductResponse Read(string Id)
    {
        try
        {
            var product =  ReadAllAsync().Result.FirstOrDefault(e => e.Code == Id);
            return product!;
        }
        catch
        {
            throw new Exception();
        }
    }
    public async Task<bool> DeleteAsync(string productId)
    {
        try
        {
            EndPoint = EndPoint.product;
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Delete, GetEndPoint);
            var model = new Key()
            {
                Id = productId,
            };
            var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonContent, null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            return true;
        }catch(Exception ex) 
        {
            return false;
        }
    }
}