using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using timan.models;

namespace timan.vn.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;
        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await httpClient.GetFromJsonAsync<Category[]>("api/category");
        }

        public async Task<Category> GetCategory(int id)
        {
            return await httpClient.GetFromJsonAsync<Category>($"api/category/{id}");

        }
    }
}
