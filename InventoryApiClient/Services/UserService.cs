using InventoryApiClient.Model;
using InventoryApiClient.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryApiClient.Services;

public class UserService : Service
{
    private readonly HttpClient _httpClient ;
    public UserService()
    {
        _httpClient = new HttpClient();
    }
    public async Task<List<UserResponse>> ReadAllAsync()
    {
        try
        {
            EndPoint = Constant.EndPoint.user;
            var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint);
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var apiData = JsonSerializer.Deserialize<DataResponse<List<UserResponse>>>(data, options)!;

            return apiData.Result!;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }
    public async Task<UserResponse> GetUserAsync(UserRequest req)
    {
        try
        {
            var jsonRequest = JsonSerializer.Serialize(req);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(BaseUrl + "/user/getById", content);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

            var apiData = JsonSerializer.Deserialize<DataResponse<UserResponse>>(data, options);
            return apiData!.Result!;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null!;
        }
    }


}
