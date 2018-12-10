#pragma checksum "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1b4113f312391b2e14782f2a8117844d57ae04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RandyPowell.Pages.Pages_Work), @"mvc.1.0.razor-page", @"/Pages/Work.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Work.cshtml", typeof(RandyPowell.Pages.Pages_Work), null)]
namespace RandyPowell.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1b4113f312391b2e14782f2a8117844d57ae04", @"/Pages/Work.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4b241aa4bff26b0b20e901b1d798d02b9435ea", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Work : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cardLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Experiences/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
  
    ViewData["Title"] = "Work";

#line default
#line hidden
            BeginContext(83, 124, true);
            WriteLiteral("\r\n<div class=\"headerPanel workPanel rounded\">\r\n    <h2 class=\"text-center\">Work Experience</h2>\r\n</div>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
     foreach (var exp in Model.Experience)
    {

#line default
#line hidden
            BeginContext(258, 40, true);
            WriteLiteral("    <div class=\"col-md-4 p-1\">\r\n        ");
            EndContext();
            BeginContext(298, 1096, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e51b90c3a0242daa843a4ef7e292c9a", async() => {
                BeginContext(372, 139, true);
                WriteLiteral("\r\n            <div class=\"card\">\r\n                <div class=\"card-body workCard\">\r\n                    <h3 class=\"card-title text-center\">");
                EndContext();
                BeginContext(512, 9, false);
#line 17 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                                                  Write(exp.Title);

#line default
#line hidden
                EndContext();
                BeginContext(521, 69, true);
                WriteLiteral("</h3>\r\n                    <h4 class=\"card-subtitle mb-2 text-muted\">");
                EndContext();
                BeginContext(591, 16, false);
#line 18 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                                                         Write(exp.Organization);

#line default
#line hidden
                EndContext();
                BeginContext(607, 86, true);
                WriteLiteral("</h4>\r\n                    <p class=\"card-text\"><i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(694, 12, false);
#line 19 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                                                                          Write(exp.Location);

#line default
#line hidden
                EndContext();
                BeginContext(706, 83, true);
                WriteLiteral("</p>\r\n                    <p class=\"card-text\"><i class=\"fas fa-calendar-alt\"></i> ");
                EndContext();
                BeginContext(790, 9, false);
#line 20 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                                                                        Write(exp.Dates);

#line default
#line hidden
                EndContext();
                BeginContext(799, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 21 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                     if (exp.ExperienceSkills.Count > 0)
                    {

#line default
#line hidden
                BeginContext(886, 59, true);
                WriteLiteral("                    <p class=\"card-text\">Skills Used:</p>\r\n");
                EndContext();
                BeginContext(947, 43, true);
                WriteLiteral("                    <ul class=\"cardList\">\r\n");
                EndContext();
#line 26 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                         foreach (var skill in exp.ExperienceSkills)
                        {

#line default
#line hidden
                BeginContext(1087, 32, true);
                WriteLiteral("                            <li>");
                EndContext();
                BeginContext(1120, 61, false);
#line 28 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                           Write(Model.Skills.FirstOrDefault(i => i.ID == skill.SkillId).Title);

#line default
#line hidden
                EndContext();
                BeginContext(1181, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 29 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                        }

#line default
#line hidden
                BeginContext(1215, 27, true);
                WriteLiteral("                    </ul>\r\n");
                EndContext();
#line 31 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                    }

#line default
#line hidden
                BeginContext(1265, 41, true);
                WriteLiteral("                    <p class=\"card-text\">");
                EndContext();
                BeginContext(1307, 23, false);
#line 32 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                                    Write(exp._desc.Split(";")[0]);

#line default
#line hidden
                EndContext();
                BeginContext(1330, 60, true);
                WriteLiteral("</p>\r\n                </div>\r\n\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
                                                             WriteLiteral(exp.ID);

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
            BeginContext(1394, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 38 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Work.cshtml"
    }

#line default
#line hidden
            BeginContext(1415, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RandyPowell.Pages.WorkModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RandyPowell.Pages.WorkModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RandyPowell.Pages.WorkModel>)PageContext?.ViewData;
        public RandyPowell.Pages.WorkModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
