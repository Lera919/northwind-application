#pragma checksum "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4686e671eaf09394467c36293766758f8ab6005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_GetAll), @"mvc.1.0.view", @"/Views/Articles/GetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4686e671eaf09394467c36293766758f8ab6005", @"/Views/Articles/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211c9736900831adef87e2f345555bf3cf77a9a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Articles_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp6.Models.PaginationArticleViewModel>
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
#line 3 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
  
    ViewData["Title"] = "GetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetAll</h1>\r\n\r\n<p>\r\n");
#nullable restore
#line 10 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
     if (User.IsInRole("Employee"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4686e671eaf09394467c36293766758f8ab60053930", async() => {
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
#line 13 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
           Write(Html.DisplayName("Author"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
           Write(Html.DisplayName("Title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
           Write(Html.DisplayName("Publication Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
         foreach (var item in Model.Collection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.PublicationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
#nullable restore
#line 47 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                 if (User.IsInRole("Employee") && ViewBag.NorthwindId == item.AuthorId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 51 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                   Write(Html.ActionLink("Read", "Details", new { id = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 52 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 54 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 58 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                   Write(Html.ActionLink("Read", "Details", new { id = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 60 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 62 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h1>\r\n\r\n    current page ");
#nullable restore
#line 68 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
            Write(Model.PagingInfo.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n");
#nullable restore
#line 70 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
 if (Model.PagingInfo.CurrentPage < Model.PagingInfo.TotalPages)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
Write(Html.ActionLink("NextPage", "GetAll", "Articles", new { page = ++Model.PagingInfo.CurrentPage }, null));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                                                                                                           
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
 if (Model.PagingInfo.CurrentPage > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
Write(Html.ActionLink("PrevPage", "GetAll", "Articles", new { page = --Model.PagingInfo.CurrentPage }, null));

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetAll.cshtml"
                                                                                                           
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp6.Models.PaginationArticleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
