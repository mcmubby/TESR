#pragma checksum "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5974a2243da90c510a731f9728d42af6c1e062bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CvGeneration_CvTwo), @"mvc.1.0.view", @"/Views/CvGeneration/CvTwo.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\_ViewImports.cshtml"
using DelicateCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\_ViewImports.cshtml"
using DelicateCV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5974a2243da90c510a731f9728d42af6c1e062bd", @"/Views/CvGeneration/CvTwo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d825c98f936d0976be83dea06feaff27fe1fd22", @"/Views/_ViewImports.cshtml")]
    public class Views_CvGeneration_CvTwo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DelicateCV.Models.CvGenerationViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5974a2243da90c510a731f9728d42af6c1e062bd3484", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>CV Template 2</title>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"css/template2.css\">\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5974a2243da90c510a731f9728d42af6c1e062bd4682", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <section class=\"out\">\r\n            <div class=\"head\">\r\n                <div class=\"my-name\">");
#nullable restore
#line 19 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                Write(Model.Fullname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <div class=\"my-title\">");
#nullable restore
#line 20 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                 Write(Model.JobTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <div class=\"contact\">\r\n                    <span><i class=\"fas fa-phone\"></i> &nbsp; ");
#nullable restore
#line 22 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                                         Write(Model.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    <span><i class=\"fas fa-envelope\"></i> &nbsp; ");
#nullable restore
#line 23 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                                            Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </div>\r\n                <p>");
#nullable restore
#line 25 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
              Write(Model.Summary);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>
            </div>
        </section>

        <section class=""seco"">
            <div class=""section-title"">Experience</div>
            <div class=""info"">
                <div class=""job-title-container"">
                    <div>
                        <div class=""job-company"">");
#nullable restore
#line 34 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                            Write(Model.Company);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <small><em> -: ");
#nullable restore
#line 34 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                                                          Write(Model.ExperienceStart);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 34 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                                                                                   Write(Model.ExperienceEnd);

#line default
#line hidden
#nullable disable
                WriteLiteral("</em></small></div>\r\n                        <div class=\"job-title\">");
#nullable restore
#line 35 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                          Write(Model.JobTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral(@"            </div>
        </section>

        <section class=""seco"">
            <div class=""section-title"">Education</div>
            <div class=""info"">
                <div class=""job-title-container"">
                    <div>
                        <div class=""job-company"">");
#nullable restore
#line 50 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                                          Write(Model.Institution);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small><em> - ");
#nullable restore
#line 50 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                                                                          Write(Model.GradYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</em></small></div>\r\n                        <div class=\"job-title\"></div>\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral(@"            </div>
        </section>



        <section class=""seco"">
            <div class=""section-title"">Skill</div>
            <div class=""list"">
                <div class=""skill-container"">
                    <ul>
                        <li>");
#nullable restore
#line 68 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                       Write(Model.Skills);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
                WriteLiteral("                    </ul>\r\n                </div>\r\n");
                WriteLiteral("            </div>\r\n        </section>\r\n\r\n        <div class=\"interest\">\r\n            <div class=\"section-title\">Certification</div>\r\n            <div class=\"interest-container\">\r\n                <p>");
#nullable restore
#line 84 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
              Write(Model.Certifications);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
                WriteLiteral("            </div>\r\n\r\n            <section class=\"seco\">\r\n                <div class=\"section-title\">Languages</div>\r\n                <div class=\"ref\">\r\n");
                WriteLiteral("                    <div class=\"reference\">");
#nullable restore
#line 93 "C:\Users\mcmubby\Desktop\Secure\DelicateResume\Views\CvGeneration\CvTwo.cshtml"
                                      Write(Model.Languages);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
                WriteLiteral("                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DelicateCV.Models.CvGenerationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591