#pragma checksum "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05cc98a2381a49a9ab1c964cbc85bb6e8402d098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_GetComments), @"mvc.1.0.view", @"/Views/Articles/GetComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05cc98a2381a49a9ab1c964cbc85bb6e8402d098", @"/Views/Articles/GetComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"211c9736900831adef87e2f345555bf3cf77a9a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Articles_GetComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp6.Models.PaginationBlogCommentViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
  
    ViewData["Title"] = "GetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Comments</h1>\r\n\r\n<p>\r\n");
#nullable restore
#line 10 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
     if (User.IsInRole("Customer"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
   Write(Html.ActionLink("Add comment", "CreateComment", new { articleId = Model.ArticleId }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
                                                                                             
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
           Write(Html.DisplayName("Author"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
           Write(Html.DisplayName("Text"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
         foreach (var item in Model.Collection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.CommentAuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                \r\n");
#nullable restore
#line 41 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
                 if (User.IsInRole("Customer") && ViewBag.NorthwindId == item.CustomerId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
                   Write(Html.ActionLink("Edit", "EditComment", new { id = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 45 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
                   Write(Html.ActionLink("Delete", "DeleteComment", new { id = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 47 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
                }
                else
                if(User.IsInRole("Employee"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 52 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
                   Write(Html.ActionLink("Delete", "DeleteComment", new { id = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 54 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 56 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h1>\r\n\r\n    current page ");
#nullable restore
#line 62 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
            Write(Model.PagingInfo.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n");
#nullable restore
#line 64 "D:\Epam\northwind-ap\module05\WebApp\WebApp6\Views\Articles\GetComments.cshtml"
Write(Html.ActionLink("NextPage", "GetAll", "Articles", new { offset = ++Model.PagingInfo.CurrentPage * PagingInfo.ItemsPerPage, limit = PagingInfo.ItemsPerPage }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp6.Models.PaginationBlogCommentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
