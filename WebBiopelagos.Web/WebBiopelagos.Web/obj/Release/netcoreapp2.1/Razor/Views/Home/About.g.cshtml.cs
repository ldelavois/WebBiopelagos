#pragma checksum "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c0e844397a9a5002965653543a79754ce4b58f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\_ViewImports.cshtml"
using WebBiopelagos.Web;

#line default
#line hidden
#line 2 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\_ViewImports.cshtml"
using WebBiopelagos.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c0e844397a9a5002965653543a79754ce4b58f", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f55be65d6231362ae8823f3c2ef71120deb8d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Home\About.cshtml"
  
    ViewData["Title"] = "À propos";

#line default
#line hidden
            BeginContext(44, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(71, 16, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e95038d92c64a8aa3824ee436ce9f9d", async() => {
                BeginContext(77, 3, true);
                WriteLiteral("\r\n ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(87, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(93, 1124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22e64c04548645abbbf9f11e1b198dc8", async() => {
                BeginContext(99, 10, true);
                WriteLiteral("\r\n    <h2>");
                EndContext();
                BeginContext(110, 17, false);
#line 12 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Home\About.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(127, 102, true);
                WriteLiteral("</h2>\r\n\r\n    <p><a href=\"./\"><input type=\"submit\" value=\"Retour vers l\'accueil\" /></a></p>\r\n\r\n    <h3>");
                EndContext();
                BeginContext(230, 19, false);
#line 16 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Home\About.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
                EndContext();
                BeginContext(249, 961, true);
                WriteLiteral(@"</h3>

    <p>Biodiversité des écosystèmes pélagiques océaniques pour une meilleure conservation et gestion des zones naturelles exceptionnelles de Nouvelle-Calédonie et de Wallis & Futuna</p>

    <h4>BIOPELAGOS en bref</h4>


    <p><strong>Durée</strong>: 3 ans, 30 juin 2016 - 29 juin 2019</p>
    <p><strong>Financement</strong>: programme BEST 2.0 (UE) : 400,000€</p>
    <p><strong>Mise en œuvre</strong>: CPS et IRD</p>
    <p><strong>Partenaires</strong>: Wallis et Futuna et Nouvelle-Calédonie</p>
    <p><strong>Objectif</strong>: apporter un soutien aux partenaires pour des prises de décision sur la gestion et la conservation de la biodiversité des écosystèmes océaniques</p>
    <p>
        <strong>Thématiques</strong>
        <ol>
            <li>Acquisition de nouvelles connaissances</li>
            <li>Renforcement des capacités</li>
            <li>Synthèse des connaissances et conseils</li>
        </ol>
    </p>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
