using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;

namespace timan.vn.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductList>> GetProductLists();
        Task<ProductList> GetProductdetail(int id);
    }
}
