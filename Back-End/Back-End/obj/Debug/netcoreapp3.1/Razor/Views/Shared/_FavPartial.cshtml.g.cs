#pragma checksum "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819bb54aee0c599f5d0e0e004d70c5fffb413d20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FavPartial), @"mvc.1.0.view", @"/Views/Shared/_FavPartial.cshtml")]
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
#line 1 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\_ViewImports.cshtml"
using Back_End;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\_ViewImports.cshtml"
using Back_End.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\_ViewImports.cshtml"
using Back_End.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\_ViewImports.cshtml"
using Back_End.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819bb54aee0c599f5d0e0e004d70c5fffb413d20", @"/Views/Shared/_FavPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfe4527dfb79db36dc8ffa47b39bcf2cfec6b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FavPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FavItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletefromfav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
  
    Layout = null;
    double totalCount = 0;
    foreach (var item in Model)
    {
        totalCount += item.Price * item.Count;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""ltn__utilize-menu-inner ltn__scrollbar"">
    <div class=""ltn__utilize-menu-head"">
        <span class=""ltn__utilize-menu-title"">Favory</span>
        <button class=""ltn__utilize-close"">×</button>
    </div>
    <div class=""mini-cart-product-area ltn__scrollbar"" id=""favorite"" data-favorite-count=""");
#nullable restore
#line 20 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
                                                                                     Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 21 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mini-cart-item clearfix\">\r\n                <div class=\"mini-cart-img\">\r\n                    <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "819bb54aee0c599f5d0e0e004d70c5fffb413d206397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 708, "~/assets/img/product/", 708, 21, true);
#nullable restore
#line 25 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
AddHtmlAttributeValue("", 729, item.Image, 729, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819bb54aee0c599f5d0e0e004d70c5fffb413d208004", async() => {
                WriteLiteral("\r\n                        <span class=\"mini-cart-item-delete\"><i class=\"icon-cancel\"></i></span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
                                          Write(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
                                                                                                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"mini-cart-info\">\r\n                    <h6><a href=\"#\">");
#nullable restore
#line 31 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                    <span class=\"mini-cart-quantity\"> $");
#nullable restore
#line 32 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"mini-cart-footer\">\r\n        <div class=\"mini-cart-sub-total\">\r\n            <h5>Subtotal: <span>$");
#nullable restore
#line 40 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_FavPartial.cshtml"
                            Write(totalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FavItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
