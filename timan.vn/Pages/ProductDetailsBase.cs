using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;
using timan.vn.Services;

namespace timan.vn.Pages
{
    public class ProductDetailsBase: ComponentBase
    {
        public ProductList productList { get; set; } = new ProductList();
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IProductService productService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            productList = await productService.GetProductdetail(int.Parse(Id));
                }

    }
}
