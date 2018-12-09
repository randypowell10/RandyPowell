#pragma checksum "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ca1034c562beb09332b12e6e360b47f338df3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RandyPowell.Pages.Pages_Projects), @"mvc.1.0.razor-page", @"/Pages/Projects.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Projects.cshtml", typeof(RandyPowell.Pages.Pages_Projects), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ca1034c562beb09332b12e6e360b47f338df3a", @"/Pages/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4b241aa4bff26b0b20e901b1d798d02b9435ea", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
  
    ViewData["Title"] = "Projects";

#line default
#line hidden
            BeginContext(91, 120, true);
            WriteLiteral("\r\n<div class=\"headerPanel projectPanel rounded\">\r\n    <h2 class=\"text-center\">Projects</h2>\r\n</div>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
     foreach (var exp in Model.Experience)
    {

#line default
#line hidden
            BeginContext(262, 48, true);
            WriteLiteral("        <div class=\"col-md-4 p-1\">\r\n            ");
            EndContext();
            BeginContext(310, 1207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "789b810e15624da9b6e2f11075873b68", async() => {
                BeginContext(384, 154, true);
                WriteLiteral("\r\n                <div class=\"card\">\r\n                    <div class=\"card-body projectCard\">\r\n                        <h3 class=\"card-title text-center\">");
                EndContext();
                BeginContext(539, 9, false);
#line 17 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                                      Write(exp.Title);

#line default
#line hidden
                EndContext();
                BeginContext(548, 73, true);
                WriteLiteral("</h3>\r\n                        <h4 class=\"card-subtitle mb-2 text-muted\">");
                EndContext();
                BeginContext(622, 16, false);
#line 18 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                                             Write(exp.Organization);

#line default
#line hidden
                EndContext();
                BeginContext(638, 90, true);
                WriteLiteral("</h4>\r\n                        <p class=\"card-text\"><i class=\"fas fa-map-marker-alt\"></i> ");
                EndContext();
                BeginContext(729, 12, false);
#line 19 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                                                              Write(exp.Location);

#line default
#line hidden
                EndContext();
                BeginContext(741, 87, true);
                WriteLiteral("</p>\r\n                        <p class=\"card-text\"><i class=\"fas fa-calendar-alt\"></i> ");
                EndContext();
                BeginContext(829, 9, false);
#line 20 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                                                            Write(exp.Dates);

#line default
#line hidden
                EndContext();
                BeginContext(838, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 21 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                         if (exp.ExperienceSkills.Count > 0)
                        {

#line default
#line hidden
                BeginContext(933, 67, true);
                WriteLiteral("                            <p class=\"card-text\">Skills Used:</p>\r\n");
                EndContext();
                BeginContext(1002, 51, true);
                WriteLiteral("                            <ul class=\"cardList\">\r\n");
                EndContext();
#line 26 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                 foreach (var skill in exp.ExperienceSkills)
                                {

#line default
#line hidden
                BeginContext(1166, 40, true);
                WriteLiteral("                                    <li>");
                EndContext();
                BeginContext(1207, 61, false);
#line 28 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                   Write(Model.Skills.FirstOrDefault(i => i.ID == skill.SkillId).Title);

#line default
#line hidden
                EndContext();
                BeginContext(1268, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 29 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                }

#line default
#line hidden
                BeginContext(1310, 35, true);
                WriteLiteral("                            </ul>\r\n");
                EndContext();
#line 31 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                        }

#line default
#line hidden
                BeginContext(1372, 45, true);
                WriteLiteral("                        <p class=\"card-text\">");
                EndContext();
                BeginContext(1418, 23, false);
#line 32 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
                                        Write(exp._desc.Split(";")[0]);

#line default
#line hidden
                EndContext();
                BeginContext(1441, 72, true);
                WriteLiteral("</p>\r\n                    </div>\r\n\r\n                </div>\r\n            ");
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
#line 14 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
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
            BeginContext(1517, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 38 "C:\Users\randy\source\repos\RandyPowell\RandyPowell\Pages\Projects.cshtml"
    }

#line default
#line hidden
            BeginContext(1542, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RandyPowell.Pages.ProjectsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RandyPowell.Pages.ProjectsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RandyPowell.Pages.ProjectsModel>)PageContext?.ViewData;
        public RandyPowell.Pages.ProjectsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
