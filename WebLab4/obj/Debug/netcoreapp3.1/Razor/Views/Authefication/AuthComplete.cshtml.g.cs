#pragma checksum "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3575951064c36752100ffcf1c1d95b482aeb65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authefication_AuthComplete), @"mvc.1.0.view", @"/Views/Authefication/AuthComplete.cshtml")]
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
#line 1 "C:\imits\Web4\WebLab4\WebLab4\Views\_ViewImports.cshtml"
using WebLab4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\imits\Web4\WebLab4\WebLab4\Views\_ViewImports.cshtml"
using WebLab4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3575951064c36752100ffcf1c1d95b482aeb65", @"/Views/Authefication/AuthComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17993205effa45825b655c864e9bba4b803f3f45", @"/Views/_ViewImports.cshtml")]
    public class Views_Authefication_AuthComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLab4.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
  
    ViewData["Title"] = "AuthComplete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AuthComplete</h1>\r\n<h2>Sign Up Result</h2>\r\n");
            WriteLiteral("\r\n<ul style=\"list-style-type: none\">\r\n    <li>\r\n        ");
#nullable restore
#line 12 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
   Write(Html.DisplayFor(item => item.UserInfoModel.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        ");
#nullable restore
#line 15 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
   Write(Html.DisplayFor(item => item.UserInfoModel.SecondName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        ");
#nullable restore
#line 18 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
   Write(Html.DisplayFor(item => item.UserInfoModel.Day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        ");
#nullable restore
#line 21 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
   Write(Html.DisplayFor(item => item.UserInfoModel.Month));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        ");
#nullable restore
#line 24 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
   Write(Html.DisplayFor(item => item.UserInfoModel.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        ");
#nullable restore
#line 27 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
   Write(Html.DisplayFor(item => item.PrivateUserInfoModel.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        ");
#nullable restore
#line 30 "C:\imits\Web4\WebLab4\WebLab4\Views\Authefication\AuthComplete.cshtml"
   Write(Html.DisplayFor(item => item.PrivateUserInfoModel.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLab4.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
