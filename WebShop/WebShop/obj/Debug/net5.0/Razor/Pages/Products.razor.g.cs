#pragma checksum "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd11e225df0d857464a46b8f5bb9673749eeb1e0"
// <auto-generated/>
#pragma warning disable 1591
namespace WebShop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using WebShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using WebShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\_Imports.razor"
using WebShop.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5  min-height");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
#nullable restore
#line 6 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor"
         if (products == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p>Getting products...</p>");
#nullable restore
#line 9 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WebShop.Shared.ProductCard>(5);
            __builder.AddAttribute(6, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebShop.Models.Product>(
#nullable restore
#line 14 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor"
                                    product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\ahmed\skola\Assignments-Back\WebShop\WebShop\Pages\Products.razor"
       
#nullable enable
    private Product[]? products;

    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<Product[]>("https://localhost:44314/api/Products");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
