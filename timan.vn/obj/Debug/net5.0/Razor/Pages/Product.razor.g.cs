#pragma checksum "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf5e0aea24c8c03b944b75cf76284ae1338e557"
// <auto-generated/>
#pragma warning disable 1591
namespace timan.vn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using timan.vn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using timan.vn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lenovo\source\repos\timan\timan.vn\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Product : ProductBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Product</h3>");
#nullable restore
#line 5 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
 if (Products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner\"></div>");
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "showhere");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "detailshow row ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row colcus col-xxl-3 col-xl-3 col-lg-3 col-md-3 col-sm-4 col-6");
#nullable restore
#line 14 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
             foreach (var product in Products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "productShow");
            __builder.AddAttribute(10, "style", "min-width:18rem; max-width:30.5%");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "productThumnail ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 19 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
                                  $"/productdetail/{product.ProductID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "imglink");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "class", "imgsource");
            __builder.AddAttribute(18, "width", "170");
            __builder.AddAttribute(19, "height", "170");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 21 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
                                       product.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "alt", "Image");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "priceP");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
                                             product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "ProContent");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "contentin");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 26 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
                                                    $"/productdetail/{product.ProductID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, 
#nullable restore
#line 26 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
                                                                                            product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.AddMarkupContent(34, @"<div class=""starcontent""><i class=""fas fa-star fas1 starDe""></i>
                        <i class=""fas fa-star fas1 starDe""></i>
                        <i class=""fas fa-star fas1 starDe""></i>
                        <i class=""fas fa-star fas1 starDe""></i>
                        <i class=""fas fa-star-half fas1 starH""></i></div>
                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-footer text-center");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 37 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
                                  $"/productdetail/{product.ProductID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "class", "btn-light m-1");
            __builder.AddContent(40, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", 
#nullable restore
#line 38 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
                                   $"/editproduct/{product.ProductID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "class", "btn-light m-1");
            __builder.AddContent(45, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.AddMarkupContent(47, "<a href=\"#\" class=\"btn-light m-1\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\lenovo\source\repos\timan\timan.vn\Pages\Product.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
