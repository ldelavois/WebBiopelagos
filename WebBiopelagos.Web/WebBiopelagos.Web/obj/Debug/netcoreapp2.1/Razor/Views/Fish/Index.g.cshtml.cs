#pragma checksum "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c8b49994265bd5678d8ada7c482148c81cda36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fish_Index), @"mvc.1.0.view", @"/Views/Fish/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fish/Index.cshtml", typeof(AspNetCore.Views_Fish_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c8b49994265bd5678d8ada7c482148c81cda36", @"/Views/Fish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f55be65d6231362ae8823f3c2ef71120deb8d6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Fish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBiopelagos.Web.Models.Fish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SetBases", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
  
    ViewData["Title"] = "Espèces";

#line default
#line hidden
            BeginContext(96, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(103, 17, false);
#line 7 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(120, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(130, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f727293c88f4b8f8d3d2a2880094437", async() => {
                BeginContext(186, 53, true);
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
            BeginContext(243, 41, true);
            WriteLiteral("</p>\r\n\r\n\r\n<h3>Campagne Wallalis</h3>\r\n<p>");
            EndContext();
            BeginContext(284, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a26c0b7ccd4c7fa949c08826b5edcf", async() => {
                BeginContext(344, 56, true);
                WriteLiteral("<input type=\"submit\" value=\"Retour vers les stations\" />");
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
            BeginContext(404, 17, true);
            WriteLiteral("</p>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(421, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0c04dac216b4874b56184e498a51ee8", async() => {
                BeginContext(472, 71, true);
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
            BeginContext(547, 60, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(835, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(870, 48, false);
#line 30 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SamplingDate));

#line default
#line hidden
            EndContext();
            BeginContext(918, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(1382, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(1417, 42, false);
#line 45 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FishNo));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(1596, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(1631, 47, false);
#line 51 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnershipId));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(3061, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(3096, 43, false);
#line 90 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(3139, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(3276, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(3311, 48, false);
#line 96 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(3359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3415, 45, false);
#line 99 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Timestamp));

#line default
#line hidden
            EndContext();
            BeginContext(3460, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3516, 41, false);
#line 102 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3613, 47, false);
#line 105 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EditorStaff));

#line default
#line hidden
            EndContext();
            BeginContext(3660, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(3809, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(3844, 44, false);
#line 111 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FishType));

#line default
#line hidden
            EndContext();
            BeginContext(3888, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(4277, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(4312, 43, false);
#line 123 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SetBase));

#line default
#line hidden
            EndContext();
            BeginContext(4355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4411, 39, false);
#line 126 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(4450, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4506, 43, false);
#line 129 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Species));

#line default
#line hidden
            EndContext();
            BeginContext(4549, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(4684, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 138 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
            BeginContext(4802, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
            BeginContext(5070, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(5113, 47, false);
#line 150 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SamplingDate));

#line default
#line hidden
            EndContext();
            BeginContext(5160, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(5672, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(5715, 41, false);
#line 165 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FishNo));

#line default
#line hidden
            EndContext();
            BeginContext(5756, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(5908, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(5951, 46, false);
#line 171 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OwnershipId));

#line default
#line hidden
            EndContext();
            BeginContext(5997, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(7516, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(7559, 42, false);
#line 210 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(7601, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(7753, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(7796, 47, false);
#line 216 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(7843, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7911, 44, false);
#line 219 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Timestamp));

#line default
#line hidden
            EndContext();
            BeginContext(7955, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(8023, 40, false);
#line 222 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TmpId));

#line default
#line hidden
            EndContext();
            BeginContext(8063, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(8131, 55, false);
#line 225 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EditorStaff.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(8186, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(8360, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(8403, 56, false);
#line 231 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FishType.FishTypeDesc));

#line default
#line hidden
            EndContext();
            BeginContext(8459, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(8924, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(8967, 52, false);
#line 243 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SetBase.SetBaseId));

#line default
#line hidden
            EndContext();
            BeginContext(9019, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(9087, 46, false);
#line 246 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sex.SexDesc));

#line default
#line hidden
            EndContext();
            BeginContext(9133, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(9201, 57, false);
#line 249 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Species.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(9258, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(9421, 22, true);
            WriteLiteral("                <td>\r\n");
            EndContext();
            BeginContext(9528, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(9548, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f7554057ce24ac1bea471f4b05e2fd8", async() => {
                BeginContext(9600, 7, true);
                WriteLiteral("Détails");
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
#line 256 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
                                              WriteLiteral(item.FishId);

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
            BeginContext(9611, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(9701, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 260 "C:\Users\ludovicd\source\repos\WebBiopelagos\WebBiopelagos.Web\WebBiopelagos.Web\Views\Fish\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(9754, 29, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>");
            EndContext();
            BeginContext(9783, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca026d0c7e74d29a546038d79063010", async() => {
                BeginContext(9839, 53, true);
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
            BeginContext(9896, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(9905, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d7a7e0aa664b32a15547419d477bd1", async() => {
                BeginContext(9965, 56, true);
                WriteLiteral("<input type=\"submit\" value=\"Retour vers les stations\" />");
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
            BeginContext(10025, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBiopelagos.Web.Models.Fish>> Html { get; private set; }
    }
}
#pragma warning restore 1591