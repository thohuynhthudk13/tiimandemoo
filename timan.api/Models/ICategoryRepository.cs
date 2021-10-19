using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;

namespace timan.api.Models
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> categories();
       Task<Category> GetCategory(int categoryID);
    }
}
