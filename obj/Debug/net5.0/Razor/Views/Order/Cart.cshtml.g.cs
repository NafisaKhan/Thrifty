#pragma checksum "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f2384017f47281e3324f959c465f4f5f4b3c56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
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
#line 1 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\_ViewImports.cshtml"
using Thrifty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\_ViewImports.cshtml"
using Thrifty.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\_ViewImports.cshtml"
using Thrifty.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\_ViewImports.cshtml"
using Thrifty.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f2384017f47281e3324f959c465f4f5f4b3c56", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc511025bea63ceeddbb9883bd11c77c5d7b84f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bd-placeholder-img embed-responsive-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("orderList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger small text-uppercase mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-instagram text-white font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""font-weight-bold text-uppercase text-center"">Shopping Cart</h3>
<section class=""container"">
    <div class=""row"">
        <div class=""col-lg-8 px-5"">
            <h5 class=""mb-4 font-weight-bold"">My Order</h5>
            <hr />            
            <div class=""row mb-4"">
                <div class=""col-md-5 col-lg-3 col-xl-3"">
                    <div class=""embed-responsive embed-responsive-1by1"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "44f2384017f47281e3324f959c465f4f5f4b3c567018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 619, "~/", 619, 2, true);
#nullable restore
#line 16 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
AddHtmlAttributeValue("", 621, Model.pImage, 621, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-7 col-lg-9 col-xl-9"">
                    <div>
                        <!--Ordered Product Info-->
                        <div class=""d-flex justify-content-between"">
                            <div>
                                <h5>");
#nullable restore
#line 24 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                               Write(Model.pName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"mb-1 text-muted small\">Section: ");
#nullable restore
#line 25 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                                     Write(Model.pSection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-0 text-muted small\">Type: ");
#nullable restore
#line 26 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                                  Write(Model.pType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-0 text-muted small\">Color: ");
#nullable restore
#line 27 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                                   Write(Model.pColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-3 text-muted small\">Size: ");
#nullable restore
#line 28 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                                  Write(Model.pSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div>\r\n                                <p class=\"mb-0\"><span class=\"font-weight-bold\">x ");
#nullable restore
#line 31 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                                            Write(Model.pQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                            </div>
                        </div>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <!--Delete Order Button-->
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f2384017f47281e3324f959c465f4f5f4b3c5611414", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <p class=\"mb-0\"><span class=\"font-weight-bold\">BDT ");
#nullable restore
#line 41 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                                          Write(Model.pPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        </div>
                    </div>
                </div>
            </div>
            <hr class=""mb-4"">
            <!--Order Time-->
            <div class="" col-12 mb-3 mx-auto font-italic font-weight-bold"">
                <p>Order Date: ");
#nullable restore
#line 49 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                          Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>                            
        </div>
        <!--Order Details-->
        <div class=""col-lg-4 row px-4"">
            <h5 class=""font-weight-bold pl-3"">Order Details</h5>
            <!--Order Info-->
            <div class=""col-12"">
                <ul class=""list-group list-group-flush specialCard"">
                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                        <p class=""font-weight-bold"">Total Quantity:</p>
                        <span class=""text-monospace"">x ");
#nullable restore
#line 60 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                  Write(Model.pQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </li>
                    <li class=""list-group-item d-flex justify-content-between align-items-center"">
                        <p class=""font-weight-bold"">Total Amount:</p>
                        <span class=""text-monospace"">Tk. ");
#nullable restore
#line 64 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                    Write(Model.pPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <!--Checkout Button-->\r\n            <div class=\"col-4 my-2 mx-auto\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f2384017f47281e3324f959c465f4f5f4b3c5615484", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "E:\Visual Studio Projects\Project_SD2\Final\Thrifty\Views\Order\Cart.cshtml"
                                                                      WriteLiteral(Model.pId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
