#pragma checksum "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e567ab316fafe1d3c00bdcfda84a8e9ae2a9b0fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fish_Details), @"mvc.1.0.view", @"/Views/Fish/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fish/Details.cshtml", typeof(AspNetCore.Views_Fish_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e567ab316fafe1d3c00bdcfda84a8e9ae2a9b0fd", @"/Views/Fish/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f55be65d6231362ae8823f3c2ef71120deb8d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Fish_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBiopelagos.Web.Models.Fish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Espèces</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 49, false);
#line 14 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TmpPredatorId));

#line default
#line hidden
            EndContext();
            BeginContext(254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(298, 45, false);
#line 17 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.TmpPredatorId));

#line default
#line hidden
            EndContext();
            BeginContext(343, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(387, 43, false);
#line 20 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CsiroId));

#line default
#line hidden
            EndContext();
            BeginContext(430, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(474, 39, false);
#line 23 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.CsiroId));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(557, 48, false);
#line 26 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SamplingDate));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 44, false);
#line 29 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.SamplingDate));

#line default
#line hidden
            EndContext();
            BeginContext(693, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(737, 45, false);
#line 32 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CatchTime));

#line default
#line hidden
            EndContext();
            BeginContext(782, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(826, 41, false);
#line 35 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.CatchTime));

#line default
#line hidden
            EndContext();
            BeginContext(867, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(911, 42, false);
#line 38 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HookNo));

#line default
#line hidden
            EndContext();
            BeginContext(953, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(997, 38, false);
#line 41 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.HookNo));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1079, 42, false);
#line 44 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReelNo));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1165, 38, false);
#line 47 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReelNo));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1247, 42, false);
#line 50 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DropNo));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1333, 38, false);
#line 53 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.DropNo));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1415, 42, false);
#line 56 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FishNo));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1501, 38, false);
#line 59 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.FishNo));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1583, 48, false);
#line 62 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsOfInterest));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1675, 44, false);
#line 65 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsOfInterest));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1763, 47, false);
#line 68 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnershipId));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1854, 43, false);
#line 71 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnershipId));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1941, 44, false);
#line 74 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LengthMm));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2029, 40, false);
#line 77 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.LengthMm));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2113, 45, false);
#line 80 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LengthMm2));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2202, 41, false);
#line 83 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.LengthMm2));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2287, 45, false);
#line 86 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LengthMm3));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2376, 41, false);
#line 89 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.LengthMm3));

#line default
#line hidden
            EndContext();
            BeginContext(2417, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2461, 50, false);
#line 92 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CalculatedWtGr));

#line default
#line hidden
            EndContext();
            BeginContext(2511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2555, 46, false);
#line 95 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.CalculatedWtGr));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2645, 44, false);
#line 98 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeightGr));

#line default
#line hidden
            EndContext();
            BeginContext(2689, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2733, 40, false);
#line 101 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeightGr));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2817, 49, false);
#line 104 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GonadWeightGr));

#line default
#line hidden
            EndContext();
            BeginContext(2866, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2910, 45, false);
#line 107 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.GonadWeightGr));

#line default
#line hidden
            EndContext();
            BeginContext(2955, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2999, 42, false);
#line 110 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo1));

#line default
#line hidden
            EndContext();
            BeginContext(3041, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3085, 38, false);
#line 113 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Photo1));

#line default
#line hidden
            EndContext();
            BeginContext(3123, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3167, 42, false);
#line 116 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo2));

#line default
#line hidden
            EndContext();
            BeginContext(3209, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3253, 38, false);
#line 119 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Photo2));

#line default
#line hidden
            EndContext();
            BeginContext(3291, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3335, 42, false);
#line 122 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo3));

#line default
#line hidden
            EndContext();
            BeginContext(3377, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3421, 38, false);
#line 125 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Photo3));

#line default
#line hidden
            EndContext();
            BeginContext(3459, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3503, 42, false);
#line 128 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo4));

#line default
#line hidden
            EndContext();
            BeginContext(3545, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3589, 38, false);
#line 131 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Photo4));

#line default
#line hidden
            EndContext();
            BeginContext(3627, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3671, 53, false);
#line 134 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataReceptionDate));

#line default
#line hidden
            EndContext();
            BeginContext(3724, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3768, 49, false);
#line 137 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataReceptionDate));

#line default
#line hidden
            EndContext();
            BeginContext(3817, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3861, 48, false);
#line 140 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaiementDate));

#line default
#line hidden
            EndContext();
            BeginContext(3909, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3953, 44, false);
#line 143 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaiementDate));

#line default
#line hidden
            EndContext();
            BeginContext(3997, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4041, 43, false);
#line 146 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(4084, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4128, 39, false);
#line 149 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(4167, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4211, 48, false);
#line 152 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EnteredByOld));

#line default
#line hidden
            EndContext();
            BeginContext(4259, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4303, 44, false);
#line 155 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.EnteredByOld));

#line default
#line hidden
            EndContext();
            BeginContext(4347, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4391, 48, false);
#line 158 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(4439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4483, 44, false);
#line 161 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(4527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4571, 45, false);
#line 164 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Timestamp));

#line default
#line hidden
            EndContext();
            BeginContext(4616, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4660, 41, false);
#line 167 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Timestamp));

#line default
#line hidden
            EndContext();
            BeginContext(4701, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4745, 41, false);
#line 170 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(4786, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4830, 37, false);
#line 173 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(4867, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4911, 47, false);
#line 176 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EditorStaff));

#line default
#line hidden
            EndContext();
            BeginContext(4958, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5002, 53, false);
#line 179 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.EditorStaff.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(5055, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5099, 60, false);
#line 182 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EditorStaffId2Navigation));

#line default
#line hidden
            EndContext();
            BeginContext(5159, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5203, 66, false);
#line 185 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.EditorStaffId2Navigation.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(5269, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5313, 44, false);
#line 188 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FishType));

#line default
#line hidden
            EndContext();
            BeginContext(5357, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5401, 51, false);
#line 191 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.FishType.FishTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(5452, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5496, 46, false);
#line 194 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LengthCode));

#line default
#line hidden
            EndContext();
            BeginContext(5542, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5586, 55, false);
#line 197 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.LengthCode.LengthCodeId));

#line default
#line hidden
            EndContext();
            BeginContext(5641, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5685, 59, false);
#line 200 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LengthCodeId2Navigation));

#line default
#line hidden
            EndContext();
            BeginContext(5744, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5788, 68, false);
#line 203 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.LengthCodeId2Navigation.LengthCodeId));

#line default
#line hidden
            EndContext();
            BeginContext(5856, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5900, 59, false);
#line 206 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LengthCodeId3Navigation));

#line default
#line hidden
            EndContext();
            BeginContext(5959, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6003, 68, false);
#line 209 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.LengthCodeId3Navigation.LengthCodeId));

#line default
#line hidden
            EndContext();
            BeginContext(6071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6115, 43, false);
#line 212 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SetBase));

#line default
#line hidden
            EndContext();
            BeginContext(6158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6202, 46, false);
#line 215 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.SetBase.GearId));

#line default
#line hidden
            EndContext();
            BeginContext(6248, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6292, 39, false);
#line 218 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(6331, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6375, 41, false);
#line 221 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sex.SexId));

#line default
#line hidden
            EndContext();
            BeginContext(6416, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6460, 43, false);
#line 224 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Species));

#line default
#line hidden
            EndContext();
            BeginContext(6503, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6547, 54, false);
#line 227 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.Species.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(6601, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6645, 46, false);
#line 230 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeightCode));

#line default
#line hidden
            EndContext();
            BeginContext(6691, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6735, 55, false);
#line 233 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeightCode.WeightCodeId));

#line default
#line hidden
            EndContext();
            BeginContext(6790, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
            BeginContext(6903, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(6907, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6365fd88d224dfd9469c0a3db604caf", async() => {
                BeginContext(6929, 6, true);
                WriteLiteral("Retour");
                EndContext();
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
            EndContext();
            BeginContext(6939, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBiopelagos.Web.Models.Fish> Html { get; private set; }
    }
}
#pragma warning restore 1591
