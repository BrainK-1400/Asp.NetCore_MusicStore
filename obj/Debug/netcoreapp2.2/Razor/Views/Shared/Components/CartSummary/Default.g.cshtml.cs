#pragma checksum "E:\VSProject\MVCMusicStore\MusicStore\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747bd54aa6c6ef662bb22953a7b304e605245305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummary_Default))]
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
#line 1 "E:\VSProject\MVCMusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore;

#line default
#line hidden
#line 2 "E:\VSProject\MVCMusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747bd54aa6c6ef662bb22953a7b304e605245305", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8018c2a0b0564885bf042b2edba49f4f4d24c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\VSProject\MVCMusicStore\MusicStore\Views\Shared\Components\CartSummary\Default.cshtml"
     if (Model.Lines.Count() > 0)
    {

#line default
#line hidden
            BeginContext(65, 30, true);
            WriteLiteral("        <small>\r\n            (");
            EndContext();
            BeginContext(96, 29, false);
#line 6 "E:\VSProject\MVCMusicStore\MusicStore\Views\Shared\Components\CartSummary\Default.cshtml"
        Write(Model.Lines.Sum(x => x.Count));

#line default
#line hidden
            EndContext();
            BeginContext(125, 22, true);
            WriteLiteral(" item(s)\r\n            ");
            EndContext();
            BeginContext(148, 39, false);
#line 7 "E:\VSProject\MVCMusicStore\MusicStore\Views\Shared\Components\CartSummary\Default.cshtml"
       Write(Model.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(187, 19, true);
            WriteLiteral("）\r\n        </small>");
            EndContext();
#line 8 "E:\VSProject\MVCMusicStore\MusicStore\Views\Shared\Components\CartSummary\Default.cshtml"
                }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
