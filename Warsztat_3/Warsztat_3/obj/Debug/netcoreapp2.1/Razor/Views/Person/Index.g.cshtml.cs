#pragma checksum "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ef80604c42dccd8bc3afd09989c5126a453aeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Index.cshtml", typeof(AspNetCore.Views_Person_Index))]
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
#line 1 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\_ViewImports.cshtml"
using Warsztat_3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ef80604c42dccd8bc3afd09989c5126a453aeb", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f48b7195d9ef2e691b8b523d7011cd3a842bc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(67, 464, true);
            WriteLiteral(@"
<h2>Index</h2>

<table class=""table"">
    <thead class=""thead=dark"">
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Imię</th>
            <th scope=""col"">Nazwisko</th>
            <th scope=""col"">Nr telefonu</th>
            <th scope=""col"">E-mail</th>
            <th scope=""col"">Utworzono</th>
            <th scope=""col"">Zmodyfikowano</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
         foreach (var personModel in Model)
        {

#line default
#line hidden
            BeginContext(587, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(638, 14, false);
#line 25 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
                           Write(personModel.ID);

#line default
#line hidden
            EndContext();
            BeginContext(652, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(680, 21, false);
#line 26 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
               Write(personModel.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(701, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(729, 20, false);
#line 27 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
               Write(personModel.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(749, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(777, 17, false);
#line 28 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
               Write(personModel.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(794, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(822, 17, false);
#line 29 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
               Write(personModel.Email);

#line default
#line hidden
            EndContext();
            BeginContext(839, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(867, 19, false);
#line 30 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
               Write(personModel.Created);

#line default
#line hidden
            EndContext();
            BeginContext(886, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(914, 19, false);
#line 31 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
               Write(personModel.Updated);

#line default
#line hidden
            EndContext();
            BeginContext(933, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(961, 69, false);
#line 32 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
               Write(Html.ActionLink("Wyświetl", "Show", "Person", new { personModel.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "G:\CodersLab\Warsztat_3\Warsztat_3\Warsztat_3\Views\Person\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1067, 36, true);
            WriteLiteral("        </tbody>\r\n\r\n</table>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
