#pragma checksum "E:\VSProject\MVCMusicStore\MusicStore\Views\Store\GenreMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aec37abf7bc21343e0841fb37a87b49fc61963d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_GenreMenu), @"mvc.1.0.view", @"/Views/Store/GenreMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/GenreMenu.cshtml", typeof(AspNetCore.Views_Store_GenreMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aec37abf7bc21343e0841fb37a87b49fc61963d8", @"/Views/Store/GenreMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8018c2a0b0564885bf042b2edba49f4f4d24c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_GenreMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicStore.Models.Genre>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\VSProject\MVCMusicStore\MusicStore\Views\Store\GenreMenu.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(78, 18, true);
            WriteLiteral("    <li>\r\n        ");
            EndContext();
            BeginContext(97, 58, false);
#line 5 "E:\VSProject\MVCMusicStore\MusicStore\Views\Store\GenreMenu.cshtml"
   Write(Html.ActionLink(item.Name, "Browse", new { item.GenreId }));

#line default
#line hidden
            EndContext();
            BeginContext(155, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 7 "E:\VSProject\MVCMusicStore\MusicStore\Views\Store\GenreMenu.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MusicStore.Models.Genre>> Html { get; private set; }
    }
}
#pragma warning restore 1591
