using Microsoft.AspNetCore.Mvc.Routing;
using PhoneStore.Models;
using PhoneStore.Service;

public class PhoneApiService : IPhonesApiService
{

    private string BASE_URL = "https://localhost:5015";
    private readonly HttpClient _httpClient;


    public PhoneApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(BASE_URL);
    }

    public async Task<IEnumerable<Product>?> GetProducts()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("/api/v1/products");
    }
}