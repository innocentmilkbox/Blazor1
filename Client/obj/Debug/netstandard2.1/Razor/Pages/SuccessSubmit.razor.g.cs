#pragma checksum "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\Pages\SuccessSubmit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b341cfc0ed4ec4e5c0a7264c8c788ff9c5dad548"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using BlazorDemo2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\_Imports.razor"
using BlazorDemo2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\Pages\SuccessSubmit.razor"
using BlazorDemo2.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/complaintsuccess")]
    public partial class SuccessSubmit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-success");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "    \r\n    ");
            __builder.AddMarkupContent(4, "<p>Thank you, your complaint has been submitted successfully</p>\r\n    <hr>\r\n    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Your complaint reference number is ");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\Pages\SuccessSubmit.razor"
                                           refnum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Dell\Desktop\DxcOnJobTraining\BlazorNo1\practice\DemoBlazor2\BlazorDemo2\Client\Pages\SuccessSubmit.razor"
           
    string refnum;
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        refnum = await Http.GetFromJsonAsync<string>("complaint");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591