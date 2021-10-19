using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;

namespace timan.api.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Category>> categories()
        {
            return await appDbContext.categories.ToListAsync();

        }

       
        public  async Task<Category> GetCategory(int categoryID)
        {
            return await appDbContext.categories
                  .FirstOrDefaultAsync(c => c.CategoryID == categoryID);
        }
    }
}
