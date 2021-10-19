using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;

namespace timan.vn.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetCategory(int id);
    }
}
