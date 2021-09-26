#pragma checksum "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Shared\TopNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "509b342f92c5d4108c17b6f3c447f8926fd09048"
// <auto-generated/>
#pragma warning disable 1591
namespace ECNcloud.Shared
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
#nullable restore
#line 1 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Shared\TopNavBar.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    public partial class TopNavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddAttribute(1, "class", "p-3 bg-dark text-white");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start");
            __builder.AddMarkupContent(6, "<a href=\"/\" class=\"d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none\"><svg class=\"bi me-2\" width=\"40\" height=\"32\" role=\"img\" aria-label=\"Bootstrap\"><use xlink:href=\"#bootstrap\"></use></svg></a>\r\n\r\n            ");
            __builder.AddMarkupContent(7, @"<ul class=""nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0""><li><a href=""/"" class=""nav-link px-2 text-secondary"">Home</a></li>
                <li><a href=""/myfiles"" class=""nav-link px-2 text-white"">Files</a></li>
                <li><a href=""/messages"" class=""nav-link px-2 text-white"">Messages</a></li>
                <li><a href=""/calendar"" class=""nav-link px-2 text-white"">Calendar</a></li></ul>

            

            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "text-end");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "class", "btn btn-warning");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Shared\TopNavBar.razor"
                                                                        ToAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Account");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-outline-light me-2");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Shared\TopNavBar.razor"
                                                                                   ToLogout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Shared\TopNavBar.razor"
       

    private void ToAccount()
    {
        _navigationManager.NavigateTo("/account");
    }

    private void ToLogout()
    {
        Delete();
    }

    private async Task Delete()
    {
        await _protectedLocalStorage.DeleteAsync("userkey");
        await _protectedLocalStorage.DeleteAsync("userdir");
        await _protectedLocalStorage.DeleteAsync("dname");
        _navigationManager.NavigateTo(_navigationManager.Uri, true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage _protectedLocalStorage { get; set; }
    }
}
#pragma warning restore 1591
