#pragma checksum "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ef9774b7857ac9a59b164846690f844d8e28609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SampleBases_Details), @"mvc.1.0.view", @"/Views/SampleBases/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SampleBases/Details.cshtml", typeof(AspNetCore.Views_SampleBases_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef9774b7857ac9a59b164846690f844d8e28609", @"/Views/SampleBases/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f55be65d6231362ae8823f3c2ef71120deb8d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_SampleBases_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBiopelagos.Web.Models.SampleBase>
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>SampleBase</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 44, false);
#line 14 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SampleNo));

#line default
#line hidden
            EndContext();
            BeginContext(258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(302, 40, false);
#line 17 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.SampleNo));

#line default
#line hidden
            EndContext();
            BeginContext(342, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(386, 44, false);
#line 20 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PriceUsd));

#line default
#line hidden
            EndContext();
            BeginContext(430, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(474, 40, false);
#line 23 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.PriceUsd));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(558, 47, false);
#line 26 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 43, false);
#line 29 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(692, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(736, 42, false);
#line 32 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsLost));

#line default
#line hidden
            EndContext();
            BeginContext(778, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(822, 38, false);
#line 35 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsLost));

#line default
#line hidden
            EndContext();
            BeginContext(860, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(904, 47, false);
#line 38 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MissingDate));

#line default
#line hidden
            EndContext();
            BeginContext(951, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(995, 43, false);
#line 41 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.MissingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1082, 47, false);
#line 44 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDiscarded));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1173, 43, false);
#line 47 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDiscarded));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1260, 53, false);
#line 50 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsPendingAnalysis));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1357, 49, false);
#line 53 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsPendingAnalysis));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1450, 46, false);
#line 56 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAnalyzed));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1540, 42, false);
#line 59 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAnalyzed));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1626, 50, false);
#line 62 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QualityStaffId));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1720, 46, false);
#line 65 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.QualityStaffId));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1810, 50, false);
#line 68 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastLocationId));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1904, 46, false);
#line 71 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastLocationId));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1994, 48, false);
#line 74 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LocationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2086, 44, false);
#line 77 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.LocationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2174, 49, false);
#line 80 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InventoryDate));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2267, 45, false);
#line 83 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.InventoryDate));

#line default
#line hidden
            EndContext();
            BeginContext(2312, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2356, 51, false);
#line 86 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LocationDetails));

#line default
#line hidden
            EndContext();
            BeginContext(2407, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2451, 47, false);
#line 89 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.LocationDetails));

#line default
#line hidden
            EndContext();
            BeginContext(2498, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2542, 43, false);
#line 92 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2585, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2629, 39, false);
#line 95 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2668, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2712, 48, false);
#line 98 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2760, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2804, 44, false);
#line 101 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2848, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2892, 48, false);
#line 104 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsTransfered));

#line default
#line hidden
            EndContext();
            BeginContext(2940, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2984, 44, false);
#line 107 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsTransfered));

#line default
#line hidden
            EndContext();
            BeginContext(3028, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3072, 58, false);
#line 110 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InventoryLocationIdOld));

#line default
#line hidden
            EndContext();
            BeginContext(3130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3174, 54, false);
#line 113 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.InventoryLocationIdOld));

#line default
#line hidden
            EndContext();
            BeginContext(3228, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3272, 41, false);
#line 116 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(3313, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3357, 37, false);
#line 119 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(3394, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3438, 40, false);
#line 122 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fish));

#line default
#line hidden
            EndContext();
            BeginContext(3478, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3522, 43, false);
#line 125 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fish.FishNo));

#line default
#line hidden
            EndContext();
            BeginContext(3565, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3609, 51, false);
#line 128 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FreezerLocation));

#line default
#line hidden
            EndContext();
            BeginContext(3660, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3704, 67, false);
#line 131 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.FreezerLocation.FreezerLocationDesc));

#line default
#line hidden
            EndContext();
            BeginContext(3771, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3815, 53, false);
#line 134 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InventoryLocation));

#line default
#line hidden
            EndContext();
            BeginContext(3868, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3912, 59, false);
#line 137 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.InventoryLocation.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(3971, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4015, 50, false);
#line 140 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InventoryStaff));

#line default
#line hidden
            EndContext();
            BeginContext(4065, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4109, 56, false);
#line 143 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.InventoryStaff.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(4165, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4209, 53, false);
#line 146 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnershipLocation));

#line default
#line hidden
            EndContext();
            BeginContext(4262, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4306, 59, false);
#line 149 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnershipLocation.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(4365, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4409, 50, false);
#line 152 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StorageQuality));

#line default
#line hidden
            EndContext();
            BeginContext(4459, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4503, 63, false);
#line 155 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.StorageQuality.StorageQualityId));

#line default
#line hidden
            EndContext();
            BeginContext(4566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4610, 59, false);
#line 158 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StorageQualityCondition));

#line default
#line hidden
            EndContext();
            BeginContext(4669, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4713, 72, false);
#line 161 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.StorageQualityCondition.StorageQualityId));

#line default
#line hidden
            EndContext();
            BeginContext(4785, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4829, 42, false);
#line 164 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tissue));

#line default
#line hidden
            EndContext();
            BeginContext(4871, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4915, 56, false);
#line 167 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tissue.TissueConditionId));

#line default
#line hidden
            EndContext();
            BeginContext(4971, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5015, 51, false);
#line 170 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TissueCondition));

#line default
#line hidden
            EndContext();
            BeginContext(5066, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5110, 65, false);
#line 173 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.TissueCondition.TissueConditionId));

#line default
#line hidden
            EndContext();
            BeginContext(5175, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5219, 52, false);
#line 176 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TissueNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(5271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5315, 65, false);
#line 179 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.TissueNavigation.TissuePositionId));

#line default
#line hidden
            EndContext();
            BeginContext(5380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5424, 50, false);
#line 182 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TissuePosition));

#line default
#line hidden
            EndContext();
            BeginContext(5474, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5518, 63, false);
#line 185 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.TissuePosition.TissuePositionId));

#line default
#line hidden
            EndContext();
            BeginContext(5581, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5625, 46, false);
#line 188 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TissueType));

#line default
#line hidden
            EndContext();
            BeginContext(5671, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5715, 55, false);
#line 191 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Details.cshtml"
       Write(Html.DisplayFor(model => model.TissueType.TissueTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(5770, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
            BeginContext(5889, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(5893, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3119c7c16f4d4a1aa936fc8808e1d9ec", async() => {
                BeginContext(5915, 6, true);
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
            BeginContext(5925, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBiopelagos.Web.Models.SampleBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
