using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using timan.models;
using System.Text.Json;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Http;
namespace timan.vn.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ProductList> GetProductdetail(int id)
        {
            return await httpClient.GetFromJsonAsync<ProductList>($"api/product/{id}");
        }

        public async Task<IEnumerable<ProductList>> GetProductLists()
        {
            return await httpClient.GetFromJsonAsync<ProductList[]>("api/product/");
           //return await httpClient.GetJsonAsync<ProductList[]>("api/product");
         }
    }
}
