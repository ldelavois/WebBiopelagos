#pragma checksum "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d9ee12fea010ceac427f0ab6eda515a05d4cc4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnalysisBases_Index), @"mvc.1.0.view", @"/Views/AnalysisBases/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AnalysisBases/Index.cshtml", typeof(AspNetCore.Views_AnalysisBases_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d9ee12fea010ceac427f0ab6eda515a05d4cc4b", @"/Views/AnalysisBases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f55be65d6231362ae8823f3c2ef71120deb8d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_AnalysisBases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBiopelagos.Web.Models.AnalysisBase>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AnalysisQuantities", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
  
    ViewData["Title"] = "Analyses";

#line default
#line hidden
            BeginContext(105, 24, true);
            WriteLiteral("\r\n<h2>Analyses</h2>\r\n<p>");
            EndContext();
            BeginContext(129, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c946f8832e3c432d9e619682ccc43630", async() => {
                BeginContext(185, 53, true);
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
            BeginContext(242, 124, true);
            WriteLiteral("</p>\r\n\r\n\r\n<h3>Campagne Wallalis</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 48, false);
#line 17 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(415, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(471, 48, false);
#line 20 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SampleBaseId));

#line default
#line hidden
            EndContext();
            BeginContext(519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(575, 50, false);
#line 23 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnalysisBaseId));

#line default
#line hidden
            EndContext();
            BeginContext(625, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(683, 48, false);
#line 27 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TissueTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(731, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(787, 50, false);
#line 30 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnalysisTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(837, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(893, 48, false);
#line 33 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnalysisDate));

#line default
#line hidden
            EndContext();
            BeginContext(941, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(999, 49, false);
#line 37 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnalyserStaff));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1104, 54, false);
#line 40 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LaboratoryLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1293, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1342, 47, false);
#line 50 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1445, 47, false);
#line 53 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SampleBaseId));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1548, 49, false);
#line 56 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnalysisBaseId));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1655, 60, false);
#line 60 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TissueType.TissueTypeDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1771, 64, false);
#line 63 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnalysisType.AnalysisTypeDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1891, 47, false);
#line 66 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnalysisDate));

#line default
#line hidden
            EndContext();
            BeginContext(1938, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1996, 57, false);
#line 70 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnalyserStaff.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2053, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2109, 66, false);
#line 73 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LaboratoryLocation.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2230, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "381d0508b9cf4159b3b64c08918b34af", async() => {
                BeginContext(2290, 7, true);
                WriteLiteral("Détails");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
                                          WriteLiteral(item.AnalysisBaseId);

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
            BeginContext(2301, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2321, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed791139e0234b6089e338ba7031d082", async() => {
                BeginContext(2404, 8, true);
                WriteLiteral("Quantité");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-AnalysisId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
                                                                 WriteLiteral(item.AnalysisBaseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AnalysisId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-AnalysisId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AnalysisId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2416, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 80 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisBases\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2463, 29, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>");
            EndContext();
            BeginContext(2492, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a85bf01f96ba4362bd61fd096fae1325", async() => {
                BeginContext(2548, 53, true);
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
            BeginContext(2605, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(2614, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4be4283444a48ce88665169f51086c4", async() => {
                BeginContext(2670, 55, true);
                WriteLiteral("<input type=\"submit\" value=\"Retour vers les espèces\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            BeginContext(2729, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBiopelagos.Web.Models.AnalysisBase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
