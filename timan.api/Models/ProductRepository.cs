using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;

namespace timan.api.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<ProductList> AddProduct(ProductList productList)
        {
            var result = await appDbContext.productLists.AddAsync(productList);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public  async Task<ProductList> DeleteProduct(int productID)
        {
            var result = await appDbContext.productLists
                .FirstOrDefaultAsync(p => p.ProductID == productID);
            if(result != null)
            {
                appDbContext.productLists.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<ProductList> GetProduct(int productID)
        {
            return await appDbContext.productLists
                .Include(c => c.Category)
                .FirstOrDefaultAsync(p => p.ProductID == productID);
        }

        public async Task<ProductList> GetProductbyName(string nameProduct)
        {
            return await appDbContext.productLists
                 .FirstOrDefaultAsync(n => n.ProductName == nameProduct);
        }

        public async Task<IEnumerable<ProductList>> GetProductLists()
        {
            return await appDbContext.productLists.ToListAsync();
        }

        public async Task<ProductList> UpdateProduct(ProductList productList)
        {
            var result = await appDbContext.productLists
                .FirstOrDefaultAsync(p => p.ProductID == productList.ProductID);
            if(result != null)
            {
                result.ProductName = productList.ProductName;
                result.CategoryID = productList.CategoryID;
                result.Desc1 = productList.Desc1;
                result.Desc2 = productList.Desc2;
                result.Desc3 = productList.Desc3;
                result.Desc4 = productList.Desc4;
                result.Photo = productList.Photo;
                result.Price = productList.Price;
                result.Rate = productList.Rate;
                result.Sold = productList.Sold;
                
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        /*  public async Task<IEnumerable<ProductList>> Search(string name)
          {
              IQueryable<ProductList> query = appDbContext.productLists;
              if (!string.IsNullOrEmpty(name))
              {
                  query = query.Where(p => p.ProductName.Contains(name));
              }
              return await query.ToListAsync();
          }
        */
        public async Task<IEnumerable<ProductList>> SearchProduct(string nameP)
        {
            IQueryable<ProductList> query = appDbContext.productLists;
            if (!string.IsNullOrEmpty(nameP))
            {
                query = query.Where( p => p.ProductName.Contains( nameP) );
            }
            return await query.ToListAsync();
        }

        Task<ProductList> IProductRepository.SearchProduct(string nameP)
        {
            throw new NotImplementedException();
        }
    }
}
