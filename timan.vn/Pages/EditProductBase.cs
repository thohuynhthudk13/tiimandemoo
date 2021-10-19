using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;
using timan.vn.Services;

namespace timan.vn.Pages
{
    public class EditProductBase: ComponentBase
    {
        [Inject]
        public IProductService productService { get; set; }

        public ProductList productList { get; set; } = new ProductList();
     
        [Inject]
        public ICategoryService CategoryService{ get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
      public string cateID { get; set; }
        [Parameter]
        public string id { get; set; }
        protected async override  Task OnInitializedAsync()
        {
            productList = await productService.GetProductdetail(int.Parse(id));
            Categories = (await CategoryService.GetCategories()).ToList();
            cateID = productList.CategoryID.ToString();
        }
    }
}
