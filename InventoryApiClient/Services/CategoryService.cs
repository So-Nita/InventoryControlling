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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryApiClient.Services;

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

    public async Task<CategoryResponse> ReadAsync(string id)
    {
        try
        {
            var category = await ReadAllAsync();
            var result = category.FirstOrDefault(e=>e.Id== id);
            return result;
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
            EndPoint = Constant.EndPoint.category;
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
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public async Task<bool> CreateAsync(CategoryCreateReq req)
    {
        try
        {
            EndPoint = Constant.EndPoint.category;
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
            var apiData = JsonSerializer.Deserialize<DataResponse<CategoryResponse>>(data, options)!;

            return (apiData.Status==200) ? true : false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false!;
        }
    }

    public async Task<bool> UpdateAsync(CategoryUpdateReq req)
    {
        try
        {
            EndPoint = Constant.EndPoint.category;
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
            var apiData = JsonSerializer.Deserialize<DataResponse<CategoryResponse>>(data, options)!;

            return (apiData.Status == 200) ? true : false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false!;
        }
    }
}