#pragma checksum "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d758aed01b6f23272e45907d936ee516add11215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnalysisQuantities_Index), @"mvc.1.0.view", @"/Views/AnalysisQuantities/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AnalysisQuantities/Index.cshtml", typeof(AspNetCore.Views_AnalysisQuantities_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d758aed01b6f23272e45907d936ee516add11215", @"/Views/AnalysisQuantities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f55be65d6231362ae8823f3c2ef71120deb8d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_AnalysisQuantities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBiopelagos.Web.Models.AnalysisQuantity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AnalysisBases", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
  
    ViewData["Title"] = "Quantité";

#line default
#line hidden
            BeginContext(109, 10, true);
            WriteLiteral("\r\n    <h2>");
            EndContext();
            BeginContext(120, 17, false);
#line 7 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(137, 12, true);
            WriteLiteral("</h2>\r\n\r\n<p>");
            EndContext();
            BeginContext(149, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ce3cf21fab047cfba18af60007eba83", async() => {
                BeginContext(205, 53, true);
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
            BeginContext(262, 122, true);
            WriteLiteral("</p>\r\n\r\n\r\n<h3>Campagne Wallalis</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(385, 50, false);
#line 17 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnalysisBaseId));

#line default
#line hidden
            EndContext();
            BeginContext(435, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(491, 49, false);
#line 20 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantityValue));

#line default
#line hidden
            EndContext();
            BeginContext(540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(596, 48, false);
#line 23 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantityUnit));

#line default
#line hidden
            EndContext();
            BeginContext(644, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(700, 50, false);
#line 26 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnalysisTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(750, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(806, 51, false);
#line 29 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubAnalysisType));

#line default
#line hidden
            EndContext();
            BeginContext(857, 88, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(994, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1042, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a24020ed69614d23a1fc38fdf3941a57", async() => {
                BeginContext(1140, 49, false);
#line 40 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
                                                                                                            Write(Html.DisplayFor(modelItem => item.AnalysisBaseId));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-AnalysisId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
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
            BeginContext(1193, 43, true);
            WriteLiteral("\r\n</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1237, 48, false);
#line 43 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantityValue));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1341, 47, false);
#line 46 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantityUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1444, 64, false);
#line 49 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnalysisType.AnalysisTypeDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1564, 50, false);
#line 52 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubAnalysisType));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1669, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e4088eb8e141adad7c49cf7e6a5ec3", async() => {
                BeginContext(1737, 7, true);
                WriteLiteral("Détails");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-QuantityId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
                                                  WriteLiteral(item.AnalysisBaseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["QuantityId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-QuantityId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["QuantityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1748, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\AnalysisQuantities\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1795, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBiopelagos.Web.Models.AnalysisQuantity>> Html { get; private set; }
    }
}
#pragma warning restore 1591