using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;
using timan.vn.Services;

namespace timan.vn.Pages
{
    public class ProductBase : ComponentBase
    {
        [Inject]
        public IProductService productService { get; set; }
        public IEnumerable< ProductList> Products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = (await productService.GetProductLists()).ToList();
          
        }
    }
}
