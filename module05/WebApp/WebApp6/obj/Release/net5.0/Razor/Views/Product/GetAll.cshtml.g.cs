#pragma checksum "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6aed0031c0baa934fd1551f412d2818049bcfc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetAll), @"mvc.1.0.view", @"/Views/Product/GetAll.cshtml")]
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
#line 1 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\_ViewImports.cshtml"
using WebApp6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\_ViewImports.cshtml"
using WebApp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6aed0031c0baa934fd1551f412d2818049bcfc6", @"/Views/Product/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211c9736900831adef87e2f345555bf3cf77a9a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp6.Models.PaginationProductViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
  
    ViewData["Title"] = "GetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>NorthwindProducts</h1>\r\n<p>\r\n");
#nullable restore
#line 11 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
     if (User.IsInRole("Employee"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6aed0031c0baa934fd1551f412d2818049bcfc63926", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<div class=\"block-left\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
               Write(Html.DisplayName("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
               Write(Html.DisplayName("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
               Write(Html.DisplayName("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
               Write(Html.DisplayName("Units in stock"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 37 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
             foreach (var item in Model.Collection)
            {
                var price = item.UnitPrice.ToString("c");

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 50 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 55 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                     if (User.IsInRole("Employee"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 58 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new {  id = item.ProductId}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 59 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 60 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { id = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 62 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n");
#nullable restore
#line 66 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                             using (Html.BeginForm("Index", "Cart"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                           Write(Html.HiddenFor(x => x.Collection.First(x => x.ProductId == item.ProductId).ProductId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                           Write(Html.Hidden("returnUrl", ViewContext.HttpContext.Request.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"submit\" value=\"+ Add to cart\" />\r\n");
#nullable restore
#line 71 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n");
#nullable restore
#line 73 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 75 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <h1>\r\n\r\n        current page ");
#nullable restore
#line 80 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
                Write(Model.PagingInfo.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    ");
#nullable restore
#line 82 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
Write(Html.ActionLink("NextPage", "GetAll", "Product", new { page = ++Model.PagingInfo.CurrentPage, category = Model.CurrentCategory }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n<div class=\"block-right\">\r\n\r\n    ");
#nullable restore
#line 90 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Product\GetAll.cshtml"
Write(await Component.InvokeAsync("NavigationMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp6.Models.PaginationProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
