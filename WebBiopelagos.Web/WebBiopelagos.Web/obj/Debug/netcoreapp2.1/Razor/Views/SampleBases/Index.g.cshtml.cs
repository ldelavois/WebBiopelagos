#pragma checksum "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4439587fcc432fdb77a13cb435ea08d183ca5948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SampleBases_Index), @"mvc.1.0.view", @"/Views/SampleBases/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SampleBases/Index.cshtml", typeof(AspNetCore.Views_SampleBases_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4439587fcc432fdb77a13cb435ea08d183ca5948", @"/Views/SampleBases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f55be65d6231362ae8823f3c2ef71120deb8d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_SampleBases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBiopelagos.Web.Models.SampleBase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SampleBases", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
  
    ViewData["Title"] = "Echantillons";

#line default
#line hidden
            BeginContext(107, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(114, 17, false);
#line 7 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(131, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(141, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7de275c99ea41a897a2bf2a0255f3aa", async() => {
                BeginContext(197, 53, true);
                WriteLiteral("<input type=\"submit\" value=\"Retour vers l\'accueil\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(254, 39, true);
            WriteLiteral("</p>\r\n<h3>Campagne Wallalis</h3>\r\n\r\n<p>");
            EndContext();
            BeginContext(293, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1062cc72d1794469bb2b033513a2ec91", async() => {
                BeginContext(349, 55, true);
                WriteLiteral("<input type=\"submit\" value=\"Retour vers les espèces\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(408, 17, true);
            WriteLiteral("</p>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(425, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c91bae77a8da47c982cd329ff1046c20", async() => {
                BeginContext(483, 71, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Voir toutes les données\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(558, 15, true);
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n");
            EndContext();
            BeginContext(620, 90, true);
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(711, 44, false);
#line 26 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SampleNo));

#line default
#line hidden
            EndContext();
            BeginContext(755, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(880, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(915, 47, false);
#line 32 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(962, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(1291, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(1326, 53, false);
#line 44 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsPendingAnalysis));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1435, 46, false);
#line 47 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAnalyzed));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1537, 50, false);
#line 50 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QualityStaffId));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(1718, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(1753, 48, false);
#line 56 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LocationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1857, 49, false);
#line 59 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InventoryDate));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1962, 51, false);
#line 62 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LocationDetails));

#line default
#line hidden
            EndContext();
            BeginContext(2013, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2069, 43, false);
#line 65 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2168, 48, false);
#line 68 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(2463, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(2498, 41, false);
#line 77 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(2539, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2595, 40, false);
#line 80 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fish));

#line default
#line hidden
            EndContext();
            BeginContext(2635, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2691, 51, false);
#line 83 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FreezerLocation));

#line default
#line hidden
            EndContext();
            BeginContext(2742, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2798, 53, false);
#line 86 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InventoryLocation));

#line default
#line hidden
            EndContext();
            BeginContext(2851, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2907, 50, false);
#line 89 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InventoryStaff));

#line default
#line hidden
            EndContext();
            BeginContext(2957, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3013, 53, false);
#line 92 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnershipLocation));

#line default
#line hidden
            EndContext();
            BeginContext(3066, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3122, 50, false);
#line 95 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StorageQuality));

#line default
#line hidden
            EndContext();
            BeginContext(3172, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3228, 59, false);
#line 98 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StorageQualityCondition));

#line default
#line hidden
            EndContext();
            BeginContext(3287, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3343, 42, false);
#line 101 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tissue));

#line default
#line hidden
            EndContext();
            BeginContext(3385, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3441, 51, false);
#line 104 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TissueCondition));

#line default
#line hidden
            EndContext();
            BeginContext(3492, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3548, 52, false);
#line 107 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TissueNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3600, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3656, 50, false);
#line 110 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TissuePosition));

#line default
#line hidden
            EndContext();
            BeginContext(3706, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3762, 46, false);
#line 113 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TissueType));

#line default
#line hidden
            EndContext();
            BeginContext(3808, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 119 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(3943, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4004, 43, false);
#line 123 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SampleNo));

#line default
#line hidden
            EndContext();
            BeginContext(4047, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(4187, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(4230, 46, false);
#line 129 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(4276, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(4642, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(4685, 52, false);
#line 141 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsPendingAnalysis));

#line default
#line hidden
            EndContext();
            BeginContext(4737, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4805, 45, false);
#line 144 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsAnalyzed));

#line default
#line hidden
            EndContext();
            BeginContext(4850, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4918, 49, false);
#line 147 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QualityStaffId));

#line default
#line hidden
            EndContext();
            BeginContext(4967, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(5113, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(5156, 47, false);
#line 153 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LocationDate));

#line default
#line hidden
            EndContext();
            BeginContext(5203, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5271, 48, false);
#line 156 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.InventoryDate));

#line default
#line hidden
            EndContext();
            BeginContext(5319, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5387, 50, false);
#line 159 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LocationDetails));

#line default
#line hidden
            EndContext();
            BeginContext(5437, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5505, 42, false);
#line 162 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(5547, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5615, 47, false);
#line 165 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(5662, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(5935, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(5978, 40, false);
#line 174 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(6018, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6086, 46, false);
#line 177 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fish.FishNo));

#line default
#line hidden
            EndContext();
            BeginContext(6132, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6200, 70, false);
#line 180 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FreezerLocation.FreezerLocationDesc));

#line default
#line hidden
            EndContext();
            BeginContext(6270, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6338, 62, false);
#line 183 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.InventoryLocation.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(6400, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6468, 59, false);
#line 186 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.InventoryStaff.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(6527, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6595, 62, false);
#line 189 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OwnershipLocation.CountryId));

#line default
#line hidden
            EndContext();
            BeginContext(6657, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6725, 66, false);
#line 192 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StorageQuality.StorageQualityId));

#line default
#line hidden
            EndContext();
            BeginContext(6791, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6859, 75, false);
#line 195 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StorageQualityCondition.StorageQualityId));

#line default
#line hidden
            EndContext();
            BeginContext(6934, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7002, 59, false);
#line 198 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tissue.TissueConditionId));

#line default
#line hidden
            EndContext();
            BeginContext(7061, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7129, 68, false);
#line 201 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TissueCondition.TissueConditionId));

#line default
#line hidden
            EndContext();
            BeginContext(7197, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7265, 68, false);
#line 204 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TissueNavigation.TissuePositionId));

#line default
#line hidden
            EndContext();
            BeginContext(7333, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7401, 66, false);
#line 207 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TissuePosition.TissuePositionId));

#line default
#line hidden
            EndContext();
            BeginContext(7467, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7535, 58, false);
#line 210 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TissueType.TissueTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(7593, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    ");
            EndContext();
            BeginContext(7662, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0a96aa8475048b9a56f1b7b24f89e1c", async() => {
                BeginContext(7720, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 214 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
                                              WriteLiteral(item.SampleBaseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7731, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7915, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 219 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\SampleBases\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(7968, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBiopelagos.Web.Models.SampleBase>> Html { get; private set; }
    }
}
#pragma warning restore 1591