#pragma checksum "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f14cc1400f0e65842a8bfcdd6aaf32f94aaa05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailAreaPArtial), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailAreaPArtial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThumbnailAreaPArtial.cshtml", typeof(AspNetCore.Views_Shared__ThumbnailAreaPArtial))]
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
#line 1 "C:\Projects\Spice\Spice\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Projects\Spice\Spice\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f14cc1400f0e65842a8bfcdd6aaf32f94aaa05", @"/Views/Shared/_ThumbnailAreaPArtial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailAreaPArtial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(150, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(182, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 186, "\"", 285, 4);
            WriteAttributeValue("", 194, "col-12", 194, 6, true);
            WriteAttributeValue(" ", 200, "post", 201, 5, true);
#line 8 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
WriteAttributeValue(" ", 205, Model.FirstOrDefault().Category.Name.Replace(" ",string.Empty), 206, 63, false);

#line default
#line hidden
            WriteAttributeValue(" ", 269, "menu-restaurant", 270, 16, true);
            EndWriteAttribute();
            BeginContext(286, 60, true);
            WriteLiteral(">\r\n    <div class=\"row\">\r\n        <h3 class=\"text-success\"> ");
            EndContext();
            BeginContext(347, 36, false);
#line 10 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                             Write(Model.FirstOrDefault().Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(383, 22, true);
            WriteLiteral(" </h3>\r\n    </div>\r\n\r\n");
            EndContext();
#line 13 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(446, 220, true);
            WriteLiteral("        <div class=\"border border-info rounded col-12\" style=\"margin-bottom:10px; margin-top:10px; padding:10px\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3 col-sm-12\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 666, "\"", 683, 1);
#line 18 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
WriteAttributeValue("", 672, item.Image, 672, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(684, 323, true);
            WriteLiteral(@" width=""99%"" style=""border-radius:5px;border:1px solid #bbb9b9"" />
                </div>
                <div class=""col-md-9 col-sm-12"">
                    <div class=""row pr-3"">
                        <div class=""col-8"">
                            <label class=""text-primary"" style=""font-size:21px;color:maroon"">");
            EndContext();
            BeginContext(1008, 9, false);
#line 23 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                                                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 24 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                             if (item.Spicyness == "1")
                            {

#line default
#line hidden
            BeginContext(1115, 80, true);
            WriteLiteral("                                <img srcset=\"/images/mild.png\" title=\"Mild\" />\r\n");
            EndContext();
#line 27 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1226, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 28 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                             if (item.Spicyness == "2")
                            {

#line default
#line hidden
            BeginContext(1314, 82, true);
            WriteLiteral("                                <img srcset=\"/images/spicy.png\" title=\"Spicy\" />\r\n");
            EndContext();
#line 31 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1427, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 32 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                             if (item.Spicyness == "3")
                            {

#line default
#line hidden
            BeginContext(1515, 91, true);
            WriteLiteral("                                <img srcset=\"/images/veryspicy.png\" title=\"Very Spicy\" />\r\n");
            EndContext();
#line 35 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1637, 142, true);
            WriteLiteral("                        </div>\r\n                        <div class=\"col-4 text-right\" style=\"color:maroon\">\r\n                            <h4>$");
            EndContext();
            BeginContext(1780, 10, false);
#line 38 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                            Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 175, true);
            WriteLiteral("</h4>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"row col-12 text-justify d-none d-md-block\">\r\n                        <p>");
            EndContext();
            BeginContext(1966, 26, false);
#line 44 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                      Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 136, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-12 offset-md-9 text-center\">\r\n                        ");
            EndContext();
            BeginContext(2128, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f14cc1400f0e65842a8bfcdd6aaf32f94aaa059905", async() => {
                BeginContext(2213, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2224, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 52 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
    }

#line default
#line hidden
            BeginContext(2321, 37, true);
            WriteLiteral("    <div class=\"p-4\"></div>\r\n</div>\r\n");
            EndContext();
#line 55 "C:\Projects\Spice\Spice\Views\Shared\_ThumbnailAreaPArtial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
