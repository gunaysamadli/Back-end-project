#pragma checksum "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24758dfb8ff32342f4cf82ef48d050cc61a69c60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductModalView), @"mvc.1.0.view", @"/Views/Shared/_ProductModalView.cshtml")]
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
#nullable restore
#line 5 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24758dfb8ff32342f4cf82ef48d050cc61a69c60", @"/Views/Shared/_ProductModalView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a078de14807cd3e400faa6f7e3ce4dfa031dae", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductModalView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-6 col-12\">\r\n        <div class=\"modal-product-img\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24758dfb8ff32342f4cf82ef48d050cc61a69c604247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 137, "~/uploads/product/", 137, 18, true);
#nullable restore
#line 7 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
AddHtmlAttributeValue("", 155, Model.ProductImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 155, 67, false);

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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-6 col-12\">\r\n        <div class=\"modal-product-info\">\r\n            <div class=\"product-ratting\">\r\n                <ul>\r\n");
#nullable restore
#line 14 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                     for (int i = 1; i <= 5; i++)
                    {
                        if (i <= Model.Rate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"#\"><i class=\"fas fa-star star-on\"></i></a></li>\r\n");
#nullable restore
#line 19 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"#\"><i class=\"fas fa-star\"></i></a></li>\r\n");
#nullable restore
#line 24 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n            <h3><a href=\"product-details.html\">");
#nullable restore
#line 29 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                                          Write(Model.Rooms);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rooms ");
#nullable restore
#line 29 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                                                             Write(Model.City.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n            <div class=\"product-price\">\r\n                <span>$");
#nullable restore
#line 31 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                  Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <hr>\r\n            <div class=\"modal-product-brief\">\r\n                <p>");
#nullable restore
#line 35 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
              Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""modal-product-meta ltn__product-details-menu-1 d-none"">
                <ul>
                    <li>
                        <strong>Categories:</strong>
                        <span>
                            <a href=""#"">");
#nullable restore
#line 42 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                                   Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </span>
                    </li>
                </ul>
            </div>
            <div class=""ltn__product-details-menu-2 d-none"">
                <ul>
                    <li>
                        <div class=""cart-plus-minus"">
                            <input type=""text"" value=""02"" name=""qtybutton"" class=""cart-plus-minus-box"">
                        </div>
                    </li>
                    <li>
                        <a href=""#"" class=""theme-btn-1 btn btn-effect-1"" title=""Add to Cart"" data-bs-toggle=""modal"" data-bs-target=""#add_to_cart_modal"">
                            <i class=""fas fa-shopping-cart""></i>
                            <span>ADD TO CART</span>
                        </a>
                    </li>
                </ul>
            </div>
            <!-- <hr> -->
            <div class=""ltn__product-details-menu-3"">
                <ul>
                    <li>
                        <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 2505, "\"", 2513, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Wishlist"" data-bs-toggle=""modal"" data-bs-target=""#liton_wishlist_modal"">
                            <i class=""far fa-heart""></i>
                            <span>Add to Wishlist</span>
                        </a>
                    </li>
                    <li>
                        <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 2830, "\"", 2838, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Compare"" data-bs-toggle=""modal"" data-bs-target=""#quick_view_modal"">
                            <i class=""fas fa-exchange-alt""></i>
                            <span>Compare</span>
                        </a>
                    </li>
                </ul>
            </div>
            <hr>
            <div class=""ltn__social-media"">
                <ul>
                    Tags:
");
#nullable restore
#line 83 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                     for (int i = 0; i < Model.ProductTags.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\">");
#nullable restore
#line 85 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                               Write(Model.ProductTags[i].Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 86 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                    Write(i!=Model.ProductTags.Count-1?",":"");

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\LENOVO\Desktop\Back-end-project\Back-End\Back-End\Views\Shared\_ProductModalView.cshtml"
                                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n            <label class=\"float-end mb-0\"><a class=\"text-decoration\" href=\"product-details.html\"><small>View Details</small></a></label>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
