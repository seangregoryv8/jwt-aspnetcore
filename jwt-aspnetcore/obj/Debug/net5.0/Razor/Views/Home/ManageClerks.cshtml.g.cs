#pragma checksum "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\Home\ManageClerks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e532a6a00931348a32b91b31c712f313961640f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManageClerks), @"mvc.1.0.view", @"/Views/Home/ManageClerks.cshtml")]
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
#line 1 "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\_ViewImports.cshtml"
using JWTASPNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\Home\ManageClerks.cshtml"
using JWTASPNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e532a6a00931348a32b91b31c712f313961640f2", @"/Views/Home/ManageClerks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576a1d5d191c5d4836edbee05c67f94b51374db1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ManageClerks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\Home\ManageClerks.cshtml"
  
    ViewData["Title"] = "Manage Clerks";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Clerks</h1>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>User</th>\r\n            <th>Role</th>\r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\Home\ManageClerks.cshtml"
        foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\Home\ManageClerks.cshtml"
               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\Home\ManageClerks.cshtml"
               Write(user.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\chief\OneDrive\Documents\GitHub\jwt-aspnetcore\jwt-aspnetcore\Views\Home\ManageClerks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591