#pragma checksum "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22f329b5dad7c45ef1f7b08154f18b5dbaacb5fc"
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
#nullable restore
#line 4 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
using ECNcloud.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
using FileInfo = System.IO.FileInfo;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyFiles")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyFiles/Directory/{subDir}")]
    public partial class MyFiles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"css/wrapper.css\">\n<link rel=\"stylesheet\" href=\"css/sidebars.css\">\n");
            __builder.AddMarkupContent(1, "<h3>My Files</h3>\n");
            __builder.OpenElement(2, "p");
            __builder.AddAttribute(3, "hidden", 
#nullable restore
#line 14 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
            accountErrorMessageHidden

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "style", "color: #ed2939;");
            __builder.AddContent(5, "Error: User not logged in. ");
            __builder.AddMarkupContent(6, "<a href=\"/Login\">[ Login ]</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "hidden", 
#nullable restore
#line 15 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
              hideUploaderAndFileListing

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "<h5 style=\"color: #23ab87;\">+ Upload</h5>\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "background: #ffffff;");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(13);
            __builder.AddAttribute(14, "AutoUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "MaxFileSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                                    BytesConversion.GiB(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.UploaderEvents>(17);
                __builder2.AddAttribute(18, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                         OnChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "hidden", 
#nullable restore
#line 23 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
              hideUploaderAndFileListing

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "<h5 style=\"color: #23ab87;\">+ Directory</h5>\n    ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                  newDir

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newDir = __value, newDir));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-secondary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                                CreateDir

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Create");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
 if (files != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "width: 100%; display: table;");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "style", "display: table-row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "style", "width: 75%; display: table-cell;");
            __builder.OpenElement(37, "ul");
#nullable restore
#line 35 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                     foreach (var file in files)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "li");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "width: 100%; display: table;");
            __builder.AddAttribute(41, "class", "sub-item");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "style", "display: table-row");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "width: 80%; display: table-cell;");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-link");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                                                               () => GetSelectedFileInfo(file.Substring(8))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, 
#nullable restore
#line 41 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                                                                                                               Path.GetFileName(file)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "style", "display: table-cell;");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-danger");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                                                                 () => DeleteFile(file)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "style", "display: table-cell;");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "d-flex flex-column flex-shrink-0 p-3 text-white bg-dark");
            __builder.AddAttribute(62, "style", "width: 100%;");
            __builder.AddMarkupContent(63, @"<a href=""/"" class=""d-flex align-items-center mb-3 mb-md-0 me-md-auto text-white text-decoration-none""><svg class=""bi me-2"" width=""40"" height=""32""><use xlink:href=""#bootstrap""></use></svg>
                        <span class=""fs-4"">File info</span></a>
                    <hr>
                    ");
            __builder.OpenElement(64, "ul");
            __builder.AddAttribute(65, "class", "nav nav-pills flex-column mb-auto");
            __builder.OpenElement(66, "li");
            __builder.AddAttribute(67, "class", "nav-item");
            __builder.OpenElement(68, "a");
            __builder.AddAttribute(69, "class", "nav-link active");
            __builder.AddAttribute(70, "aria-current", "page");
            __builder.AddMarkupContent(71, "<svg class=\"bi me-2\" width=\"16\" height=\"16\"><use xlink:href=\"#home\"></use></svg>\n                                ");
            __builder.AddContent(72, 
#nullable restore
#line 67 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                 filepath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                        ");
            __builder.OpenElement(74, "li");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "class", "nav-link text-white");
            __builder.AddMarkupContent(77, "<svg class=\"bi me-2\" width=\"16\" height=\"16\"><use xlink:href=\"#speedometer2\"></use></svg>\n                                ");
            __builder.AddContent(78, 
#nullable restore
#line 75 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                 filesize

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n                        ");
            __builder.OpenElement(80, "li");
            __builder.OpenElement(81, "a");
            __builder.AddAttribute(82, "class", "nav-link text-white");
            __builder.AddMarkupContent(83, "<svg class=\"bi me-2\" width=\"16\" height=\"16\"><use xlink:href=\"#speedometer2\"></use></svg>\n                                ");
            __builder.AddContent(84, 
#nullable restore
#line 83 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                 created

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                        ");
            __builder.OpenElement(86, "li");
            __builder.OpenElement(87, "a");
            __builder.AddAttribute(88, "class", "nav-link text-white");
            __builder.AddMarkupContent(89, "<svg class=\"bi me-2\" width=\"16\" height=\"16\"><use xlink:href=\"#speedometer2\"></use></svg>\n                                ");
            __builder.AddContent(90, 
#nullable restore
#line 91 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                 modified

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n                        ");
            __builder.OpenElement(92, "li");
            __builder.OpenElement(93, "a");
            __builder.AddAttribute(94, "href", 
#nullable restore
#line 95 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                       shareLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(95, "class", "nav-link");
            __builder.AddAttribute(96, "style", "color: #0099cc;");
            __builder.AddMarkupContent(97, "<svg class=\"bi me-2\" width=\"16\" height=\"16\"><use xlink:href=\"#speedometer2\"></use></svg>\n                                Share Link\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n                        ");
            __builder.OpenElement(99, "li");
            __builder.OpenElement(100, "a");
            __builder.AddAttribute(101, "href", 
#nullable restore
#line 103 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                       downloadLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(102, "target", "_blank");
            __builder.AddAttribute(103, "download");
            __builder.AddAttribute(104, "class", "nav-link");
            __builder.AddAttribute(105, "style", "color: #0099cc;");
            __builder.AddMarkupContent(106, "<svg class=\"bi me-2\" width=\"16\" height=\"16\"><use xlink:href=\"#speedometer2\"></use></svg>\n                                Download Link\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "class", "btn btn-secondary");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
                                            Unlock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(110, "Unlock");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\root\Desktop\OpenentOrg\ECNcloud\Pages\MyFiles.razor"
       
    string key;
    string dir;
    string displayName;
    string message;
    bool accountErrorMessageHidden = true;
    bool hideUploaderAndFileListing = true;
    string[] files;

    string filepath = "Select a file";
    string filesize = "File size";
    string created = "Time created";
    string modified = "Time modified";
    string shareLink = "Share link";
    string downloadLink = "Download link";

    string newDir;
    
    [Parameter]
    public string subDir { get; set; }

    private void GetSelectedFileInfo(string origPath)
    {
        string path = $"wwwroot/{origPath}";
        FileInfo fi = new FileInfo(path);

    //FILE PATH
        double size = fi.Length; //SIZE
        DateTime created2 = fi.CreationTimeUtc; //CREATION TIME
        DateTime modified2 = fi.LastWriteTimeUtc; //MODIFIED TIME
        string shareLink2 = GetShareLink(path); //SHARE LINK
        string downloadLink2 = origPath; //DOWNLOAD LINK

        filepath = Path.GetFileName(path);
        filesize = $"{BytesConversion.BytesToKiB(size)} KiB";
        created = $"Created {created2.ToString("yyyy-MM-dd @ HH:mm:ss UTC")}";
        modified = $"Modified {modified2.ToString("yyyy-MM-dd @ HH:mm:ss UTC")}";
        shareLink = shareLink2;
        downloadLink = downloadLink2;
    }

    private void DeleteFile(string path)
    {
        File.Delete(path);
        _navigationManager.NavigateTo(_navigationManager.Uri, true);
    }

    private string GetShareLink(string path)
    {
        string x = path;
        Console.WriteLine(x);
        x = x.Substring(14);
        string y = ReplaceLastOccurrence(x, ".", "/");
        Console.WriteLine(y);
        return $"viewfile/{y}";
    }

    public static string ReplaceLastOccurrence(string Source, string Find, string Replace)
    {
        int place = Source.LastIndexOf(Find);

        if (place == -1)
            return Source;

        string result = Source.Remove(place, Find.Length).Insert(place, Replace);
        return result;
    }

    private async Task CreateDir()
    {
        var result2 = await _protectedLocalStorage.GetAsync<string>("userdir");
        string userRootDir = result2.Success ? result2.Value : "";
        if (!userRootDir.Equals(""))
        {
            Directory.CreateDirectory($"wwwroot/files/{userRootDir}/{newDir}");
        }
    }
    
    private async Task Unlock()
    {
    //read from browser's localstorage
        var result = await _protectedLocalStorage.GetAsync<string>("userkey");
        key = result.Success ? result.Value : "";
        var result2 = await _protectedLocalStorage.GetAsync<string>("userdir");
        dir = result2.Success ? result2.Value : "";
        var result3 = await _protectedLocalStorage.GetAsync<string>("dname");
        displayName = result3.Success ? result3.Value : "";

        Console.WriteLine($"{key} {dir} {displayName}");

    //if userkey or userdir does not exist
        if (key.Equals("") || dir.Equals(""))
        {
            accountErrorMessageHidden = false;
            Console.WriteLine("[ Error ] Key or directory missing.");
        }
        else
        {
            hideUploaderAndFileListing = false;
        }

    //scan through directory, store file paths in an array
        if (Directory.Exists($"wwwroot/files/{dir}"))
        {
            files = Directory.GetFiles($"wwwroot/files/{dir}");
        }
    }

    private void OnChange(UploadChangeEventArgs args)
    {
        foreach (var file in args.Files)
        {
            Directory.CreateDirectory($"wwwroot/files/{dir}");
            var path = $"wwwroot/files/{dir}/{file.FileInfo.Name}";
            Console.WriteLine(path);
            FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);
            file.Stream.WriteTo(filestream);
            filestream.Close();
            file.Stream.Close();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage _protectedLocalStorage { get; set; }
    }
}
#pragma warning restore 1591
