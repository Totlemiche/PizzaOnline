#pragma checksum "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bd3744433e7876768bcfa07460a84aeada3151e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PizzaOnline), @"mvc.1.0.view", @"/Views/Home/PizzaOnline.cshtml")]
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
#line 1 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\_ViewImports.cshtml"
using PizzaOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\_ViewImports.cshtml"
using PizzaOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd3744433e7876768bcfa07460a84aeada3151e", @"/Views/Home/PizzaOnline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec4a0b83f9202a021943c94e3c30da335cb2404", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PizzaOnline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaOnline.Services.ViewModel.PizzasViewModels>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml"
  
    ViewData["Title"] = "Pizzas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pizzas</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nom</th>\r\n            <th scope=\"col\">Liste des ingrédients</th>\r\n        </tr>\r\n    </thead>\r\n    \r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml"
         foreach(var pizza in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml"
               Write(pizza.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml"
                     foreach(var ingredient in pizza.Composition)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 24 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml"
                         Write(ingredient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,</span>\r\n");
#nullable restore
#line 25 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\tomde\source\repos\PizzaOnline\PizzaOnline\Views\Home\PizzaOnline.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaOnline.Services.ViewModel.PizzasViewModels>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
