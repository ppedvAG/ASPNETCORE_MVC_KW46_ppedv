#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a59017067b2110778ae08e85e738921435719c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\_ViewImports.cshtml"
using MVCAPP_DI_Samples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\_ViewImports.cshtml"
using MVCAPP_DI_Samples.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a59017067b2110778ae08e85e738921435719c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0258788c26a9ba8682a1da446c7c857bba70d9a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DependencyInversionSample.MockCar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\Home\Index.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 15 "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\Home\Index.cshtml"
Write(Model.Marke);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />  \r\n");
#nullable restore
#line 17 "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\Home\Index.cshtml"
Write(Model.Modell);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 19 "C:\Aktueller Kurs\ASPNETCORE_MVC_KW46_ppedv\ASPNETCORE_MVC\MVCAPP_DI_Samples\Views\Home\Index.cshtml"
Write(Model.Baujahr);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DependencyInversionSample.MockCar> Html { get; private set; }
    }
}
#pragma warning restore 1591
