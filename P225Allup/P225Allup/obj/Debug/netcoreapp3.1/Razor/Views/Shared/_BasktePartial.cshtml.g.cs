#pragma checksum "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df2743429620d4ccdb1e86830e3bebb77e04cf2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasktePartial), @"mvc.1.0.view", @"/Views/Shared/_BasktePartial.cshtml")]
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
#line 2 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2743429620d4ccdb1e86830e3bebb77e04cf2f", @"/Views/Shared/_BasktePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d754142dc10bb7594d12a03309532143c1dc13b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasktePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletefrombasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-close deletebasket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
  
    double totalPrice = Model.Sum(m => m.Price * m.Count);
    double totalExTax = Model.Sum(m => m.ExTax * m.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"cart-btn\">\n    <a href=\"#\">\n        <i class=\"icon ion-bag\"></i>\n        <span class=\"text\">Cart :</span>\n        <span class=\"total\">$");
#nullable restore
#line 12 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                         Write((totalPrice + totalExTax).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        <span class=\"count\">");
#nullable restore
#line 13 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                       Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    </a>\n</div>\n<div class=\"mini-cart\">\n    <ul class=\"cart-items\">\n");
#nullable restore
#line 18 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
         foreach (BasketVM basketVM in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n                <div class=\"single-cart-item d-flex\">\n                    <div class=\"cart-item-thumb\">\n                        <a href=\"single-product.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df2743429620d4ccdb1e86830e3bebb77e04cf2f7352", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 702, "~/assets/images/product/", 702, 24, true);
#nullable restore
#line 23 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
AddHtmlAttributeValue("", 726, basketVM.Image, 726, 15, false);

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
            WriteLiteral("</a>\n                        <span class=\"product-quantity\">");
#nullable restore
#line 24 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                                                   Write(basketVM.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("x</span>\n                    </div>\n                    <div class=\"cart-item-content media-body\">\n                        <h5 class=\"product-name\"><a href=\"single-product.html\">");
#nullable restore
#line 27 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                                                                          Write(basketVM.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\n                        <span class=\"product-price\">€");
#nullable restore
#line 28 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                                                Write(basketVM.Price.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df2743429620d4ccdb1e86830e3bebb77e04cf2f10376", async() => {
                WriteLiteral("<i class=\"fal fa-times\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                                                                                   WriteLiteral(basketVM.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </li>\n");
#nullable restore
#line 33 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n    <div class=\"price_content\">\n        <div class=\"cart-subtotals\">\n            <div class=\"products price_inline\">\n                <span class=\"label\">Subtotal</span>\n                <span class=\"value\">€");
#nullable restore
#line 39 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                                Write(totalPrice.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </div>\n            <div class=\"tax price_inline\">\n                <span class=\"label\">Taxes</span>\n                <span class=\"value\">€");
#nullable restore
#line 43 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                                Write(totalExTax.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </div>\n        </div>\n        <div class=\"cart-total price_inline\">\n            <span class=\"label\">Total</span>\n            <span class=\"value\">€");
#nullable restore
#line 48 "C:\Users\onurtis\Desktop\P225_ASP_04-06-2022_Identity_Register_Login_Logout_Authorize-main\P225Allup\P225Allup\Views\Shared\_BasktePartial.cshtml"
                             Write((totalPrice + totalExTax).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </div>\n    </div> <!-- price content -->\n    <div class=\"checkout text-center\">\n        <a href=\"checkout.html\" class=\"main-btn\">Checkout</a>\n    </div>\n</div> <!-- mini cart -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
