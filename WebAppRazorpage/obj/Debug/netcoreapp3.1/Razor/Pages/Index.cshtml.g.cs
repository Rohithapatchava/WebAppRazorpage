#pragma checksum "D:\Rohitha\MVC\WebAppRazorpage\WebAppRazorpage\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b108f572f8105f422bf7f4e02629d9e6c362ddd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppRazorpage.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebAppRazorpage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Rohitha\MVC\WebAppRazorpage\WebAppRazorpage\Pages\_ViewImports.cshtml"
using WebAppRazorpage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b108f572f8105f422bf7f4e02629d9e6c362ddd7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72fbd01dc6d0962def3ddabbad7befa13ec7c26", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Rohitha\MVC\WebAppRazorpage\WebAppRazorpage\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n        <h2>");
#nullable restore
#line 10 "D:\Rohitha\MVC\WebAppRazorpage\WebAppRazorpage\Pages\Index.cshtml"
       Write(DateTime.Now.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Time is: ");
#nullable restore
#line 11 "D:\Rohitha\MVC\WebAppRazorpage\WebAppRazorpage\Pages\Index.cshtml"
                Write(DateTime.Now.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Date is: ");
#nullable restore
#line 12 "D:\Rohitha\MVC\WebAppRazorpage\WebAppRazorpage\Pages\Index.cshtml"
                Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n       \r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
