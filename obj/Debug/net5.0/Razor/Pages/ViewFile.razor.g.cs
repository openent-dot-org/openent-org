#pragma checksum "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\ViewFile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3482cc7dc3b9f9c2df57f33fc1ce380ceab0738a"
// <auto-generated/>
#pragma warning disable 1591
namespace ECNcloud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using ECNcloud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using ECNcloud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewFile")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewFile/{FolderParameter}/{FileParameter}/{TypeParameter}")]
    public partial class ViewFile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, 
#nullable restore
#line 5 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\ViewFile.razor"
    FolderParameter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, 
#nullable restore
#line 6 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\ViewFile.razor"
    FileParameter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "iframe");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 7 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\ViewFile.razor"
              path

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, "Link");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\ViewFile.razor"
       
    string path;

    protected override void OnInitialized()
    {
        path = $"files/{FolderParameter}/{FileParameter}.{TypeParameter}";
        Console.WriteLine($"{path}");
    }

    [Parameter]
    public string FolderParameter { get; set; }

    [Parameter]
    public string FileParameter { get; set; }

    [Parameter]
    public string TypeParameter { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
