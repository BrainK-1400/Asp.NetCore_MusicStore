#pragma checksum "E:\VSProject\MVCMusicStore\MusicStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb818f743caaf92821e1ccac4641118b0c1ef76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cb818f743caaf92821e1ccac4641118b0c1ef76", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8018c2a0b0564885bf042b2edba49f4f4d24c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicStore.Models.Album>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/home-showcase.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\VSProject\MVCMusicStore\MusicStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(85, 97, true);
            WriteLiteral("    <h1>Home</h1>\r\n    <div style=\"width:2000px\">\r\n        <div style=\"float:left\">\r\n            ");
            EndContext();
            BeginContext(183, 40, false);
#line 8 "E:\VSProject\MVCMusicStore\MusicStore\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("StoreMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(223, 125, true);
            WriteLiteral("\r\n        </div>\r\n        <div style=\"float:left;padding-left:80px\">\r\n            <div style=\"width:700px\">\r\n                ");
            EndContext();
            BeginContext(348, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cb818f743caaf92821e1ccac4641118b0c1ef764252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(388, 209, true);
            WriteLiteral("\r\n            </div>\r\n            <h3>\r\n                <em>Fresh</em> off the grill\r\n            </h3>\r\n            <div style=\"padding-top:5px;padding-left:20px;height:auto\">\r\n                <!--TO-DO -->\r\n");
            EndContext();
#line 19 "E:\VSProject\MVCMusicStore\MusicStore\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(662, 216, true);
            WriteLiteral("                    <div style=\"width:100px;float:left;padding-right:150px;height:250px\">\r\n                        <div style=\"padding-left:20px;width:auto;width:100px;height:75px;\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 878, "\"", 901, 1);
#line 23 "E:\VSProject\MVCMusicStore\MusicStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 884, item.AlbumArtUrl, 884, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(902, 189, true);
            WriteLiteral(" />\r\n                        </div>\r\n                        <div style=\"padding-left:30px;width:100px;font-size:15px;text-align:center;font-style:italic\">\r\n                                ");
            EndContext();
            BeginContext(1092, 74, false);
#line 26 "E:\VSProject\MVCMusicStore\MusicStore\Views\Home\Index.cshtml"
                           Write(Html.ActionLink(item.Title, "Details", "Store", new { id = item.AlbumId }));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 29 "E:\VSProject\MVCMusicStore\MusicStore\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1247, 56, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    \r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MusicStore.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
