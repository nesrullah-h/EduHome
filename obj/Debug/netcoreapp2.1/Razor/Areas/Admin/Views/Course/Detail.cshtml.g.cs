#pragma checksum "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96229392f6528859b2aa071017fa0453edd5f443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Course_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Course/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Course/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Course_Detail))]
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
#line 1 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96229392f6528859b2aa071017fa0453edd5f443", @"/Areas/Admin/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3109889607af79c9a88ab44a896fdd41fc962b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(57, 25, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(82, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e266bba1447c412d88bb28fd0178dd5b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 92, "~/img/course/", 92, 13, true);
#line 7 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 105, Model.Image, 105, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(146, 134, true);
            WriteLiteral("\r\n\r\n</div>\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-2\">\r\n        <h6>Title</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(281, 11, false);
#line 15 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(292, 156, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>StartTime</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(449, 32, false);
#line 25 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.StartTime.ToString("MMMM"));

#line default
#line hidden
            EndContext();
            BeginContext(481, 154, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Description</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(636, 17, false);
#line 33 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(653, 156, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>ClassDuration</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(810, 19, false);
#line 41 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.ClassDuration);

#line default
#line hidden
            EndContext();
            BeginContext(829, 164, true);
            WriteLiteral(" <span> min</span></p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-2\">\r\n        <h6>Duration</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(994, 14, false);
#line 49 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 171, true);
            WriteLiteral(" <span> Month</span></p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Language</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1180, 14, false);
#line 57 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(1194, 156, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Student Count</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1351, 19, false);
#line 65 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.StudentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 154, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Skill Level</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1525, 15, false);
#line 73 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.SkilLevel);

#line default
#line hidden
            EndContext();
            BeginContext(1540, 155, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>About Course</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1696, 17, false);
#line 81 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.AboutCourse);

#line default
#line hidden
            EndContext();
            BeginContext(1713, 155, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>How to Apply</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1869, 16, false);
#line 89 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.HowToApply);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 156, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Certification</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(2042, 19, false);
#line 97 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.Certification);

#line default
#line hidden
            EndContext();
            BeginContext(2061, 153, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Course Fee</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(2215, 15, false);
#line 105 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
       Write(Model.CourseFee);

#line default
#line hidden
            EndContext();
            BeginContext(2230, 139, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Category</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n");
            EndContext();
#line 113 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
         foreach (var item in Model.CourseCategories)
        {

#line default
#line hidden
            BeginContext(2435, 16, true);
            WriteLiteral("            <p> ");
            EndContext();
            BeginContext(2452, 18, false);
#line 115 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
           Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2470, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 116 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Detail.cshtml"
        }

#line default
#line hidden
            BeginContext(2487, 54, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"row mt-3\">\r\n    ");
            EndContext();
            BeginContext(2541, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d833a867a45a415682d9b78ae38d712e", async() => {
                BeginContext(2584, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2595, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
