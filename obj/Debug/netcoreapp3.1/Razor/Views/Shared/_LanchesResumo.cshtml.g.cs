#pragma checksum "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\Shared\_LanchesResumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ce530b82ba5310d3bcb5bf162e10ec5fd8536d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LanchesResumo), @"mvc.1.0.view", @"/Views/Shared/_LanchesResumo.cshtml")]
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
#line 1 "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\_ViewImports.cshtml"
using Lanches_Prof_Macoratti;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\_ViewImports.cshtml"
using Lanches_Prof_Macoratti.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\_ViewImports.cshtml"
using Lanches_Prof_Macoratti.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce530b82ba5310d3bcb5bf162e10ec5fd8536d0", @"/Views/Shared/_LanchesResumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83688713fce37cdba8c63234f05f0be81a6503d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LanchesResumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lanche>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-between\">\r\n        <div class=\"col-3\">\r\n            <div class=\"thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 175, "\"", 197, 1);
#nullable restore
#line 7 "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\Shared\_LanchesResumo.cshtml"
WriteAttributeValue("", 181, Model.ImagemUrl, 181, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-rounded\" alt=\"lanche\" width=\"250px\"/>\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
#nullable restore
#line 10 "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\Shared\_LanchesResumo.cshtml"
                                  Write(Model.Preco.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h3>\r\n                    ");
#nullable restore
#line 12 "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\Shared\_LanchesResumo.cshtml"
               Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <p>");
#nullable restore
#line 14 "C:\Users\tsci\My Private Documents\Estudos\Udemy\Csharp\Lanches Prof Macoratti\Views\Shared\_LanchesResumo.cshtml"
              Write(Model.DescricaoCurta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lanche> Html { get; private set; }
    }
}
#pragma warning restore 1591
