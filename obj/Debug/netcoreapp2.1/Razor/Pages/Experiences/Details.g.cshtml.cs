#pragma checksum "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c30982580ed728cada638e9698cc121438f68bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RandyPowell.Pages.Experiences.Pages_Experiences_Details), @"mvc.1.0.razor-page", @"/Pages/Experiences/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Experiences/Details.cshtml", typeof(RandyPowell.Pages.Experiences.Pages_Experiences_Details), @"{id:int}")]
namespace RandyPowell.Pages.Experiences
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\_ViewImports.cshtml"
using RandyPowell;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30982580ed728cada638e9698cc121438f68bbb", @"/Pages/Experiences/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4b241aa4bff26b0b20e901b1d798d02b9435ea", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Experiences_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Work", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Projects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(114, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 8 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
     if (Model.Experience.Type == 0)
    {

#line default
#line hidden
            BeginContext(166, 127, true);
            WriteLiteral("        <div class=\"headerPanel workPanel rounded\">\r\n            <h2 class=\"text-center\">Work Experience</h2>\r\n        </div>\r\n");
            EndContext();
#line 13 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(317, 123, true);
            WriteLiteral("        <div class=\"headerPanel projectPanel rounded\">\r\n            <h2 class=\"text-center\">Projects</h2>\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(447, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 455, "\"", 545, 5);
            WriteAttributeValue("", 463, "w-md-75", 463, 7, true);
            WriteAttributeValue(" ", 470, "mx-auto", 471, 8, true);
#line 20 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
WriteAttributeValue(" ", 478, Model.Experience.Type==0 ? "workCard":"projectCard", 479, 54, false);

#line default
#line hidden
            WriteAttributeValue(" ", 533, "rounded", 534, 8, true);
            WriteAttributeValue(" ", 541, "p-1", 542, 4, true);
            EndWriteAttribute();
            BeginContext(546, 48, true);
            WriteLiteral(">\r\n\r\n        <h3 class=\"card-title text-center\">");
            EndContext();
            BeginContext(595, 48, false);
#line 22 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.Experience.Title));

#line default
#line hidden
            EndContext();
            BeginContext(643, 64, true);
            WriteLiteral("</h3>\r\n        <h4 class=\"text-muted text-center card-subtitle\">");
            EndContext();
            BeginContext(708, 55, false);
#line 23 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Experience.Organization));

#line default
#line hidden
            EndContext();
            BeginContext(763, 96, true);
            WriteLiteral("</h4>\r\n        <p class=\"text-center card-text mt-2 mb-0\"><i class=\"fas fa-map-marker-alt\"></i> ");
            EndContext();
            BeginContext(860, 51, false);
#line 24 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
                                                                                    Write(Html.DisplayFor(model => model.Experience.Location));

#line default
#line hidden
            EndContext();
            BeginContext(911, 93, true);
            WriteLiteral("</p>\r\n        <p class=\"text-center card-text mt-2 mb-0\"><i class=\"fas fa-calendar-alt\"></i> ");
            EndContext();
            BeginContext(1005, 48, false);
#line 25 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Experience.Dates));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 27 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
         if (Model.Experience.ExperienceSkills.Count > 0)
        {

#line default
#line hidden
            BeginContext(1131, 42, true);
            WriteLiteral("            <p class=\"\">Skills Used:</p>\r\n");
            EndContext();
            BeginContext(1175, 50, true);
            WriteLiteral("            <ul id=\"skillList\" class=\"cardList\">\r\n");
            EndContext();
            BeginContext(1435, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 37 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1465, 14, true);
            WriteLiteral("        <ul>\r\n");
            EndContext();
#line 39 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
             foreach (var desc in Model.Experience._desc.Split(";"))
            {

#line default
#line hidden
            BeginContext(1564, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1585, 4, false);
#line 41 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
               Write(desc);

#line default
#line hidden
            EndContext();
            BeginContext(1589, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 42 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1611, 36, true);
            WriteLiteral("        </ul>\r\n\r\n\r\n\r\n        <div>\r\n");
            EndContext();
#line 48 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
             if (Model.Experience.Type == 0)
            {

#line default
#line hidden
            BeginContext(1708, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1724, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "141625e2460841ff9aff7ce22af83177", async() => {
                BeginContext(1779, 46, true);
                WriteLiteral("Return to List <i class=\"fas fa-undo-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1829, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1879, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1895, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e5b4b98a714bf2863b22efdc479e72", async() => {
                BeginContext(1954, 46, true);
                WriteLiteral("Return to List <i class=\"fas fa-undo-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2004, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2021, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2074, 125, true);
                WriteLiteral("\r\n        <script>\r\n            $(document).ready(function () {\r\n                var options = {};\r\n                var id = ");
                EndContext();
                BeginContext(2200, 19, false);
#line 63 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Experiences\Details.cshtml"
                    Write(Model.Experience.ID);

#line default
#line hidden
                EndContext();
                BeginContext(2219, 581, true);
                WriteLiteral(@";
                options.url = ""/api/skill/""+id;
                options.type = ""GET"";
                options.dataType = ""json"";
                options.success = function (data) {
                    data.forEach(function (element) {
                        $(""#skillList"").append(""<li>"" + element + ""</li>"");
                    });
                };
                options.error = function () {
                    $(""#msg"").html(""Error while calling the Web API!"");
                };
                $.ajax(options);
            });

        </script>
    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RandyPowell.Pages.Experiences.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RandyPowell.Pages.Experiences.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RandyPowell.Pages.Experiences.DetailsModel>)PageContext?.ViewData;
        public RandyPowell.Pages.Experiences.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
