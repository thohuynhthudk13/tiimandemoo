using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;

namespace timan.api.Models
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductList>> GetProductLists();
        Task<ProductList> GetProduct(int productID);
        Task<ProductList> GetProductbyName(string nameProduct);

        Task<ProductList> UpdateProduct(ProductList productList);
        Task<ProductList> AddProduct(ProductList productList);
        Task<ProductList> DeleteProduct(int productID);
        Task<ProductList> SearchProduct(string nameP);

    }
}
