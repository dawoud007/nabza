#pragma checksum "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e010d477a1c1db0f43af5e8d926e250e7af14523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ArticlProject.Pages.Pages_AllUsers), @"mvc.1.0.razor-page", @"/Pages/AllUsers.cshtml")]
namespace ArticlProject.Pages
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
#line 1 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\_ViewImports.cshtml"
using ArticlProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\_ViewImports.cshtml"
using ArticlProject.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e010d477a1c1db0f43af5e8d926e250e7af14523", @"/Pages/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859cebf0b00ca21327ddb5fc327d3e2830c4b190", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_AllUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("me-auto search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_self"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section class=""bounce animated article-clean"">
    <div class=""container"">
        <section class=""team-boxed"">
            <div class=""container"">
                <div class=""intro"">
                    <h2 class=""text-center"" style=""font-family: Cairo, sans-serif;"">ناشرونا</h2>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e010d477a1c1db0f43af5e8d926e250e7af145235684", async() => {
                WriteLiteral(@"
                    <div class=""d-flex align-items-center"">
                        <label class=""form-label d-flex mb-0"" for=""search-field"">
                            <i class=""fa fa-search""></i>
                        </label>
                        <input type=""hidden"" value=""Search"" name=""LoadState"" />

                        <input class=""form-control search-field"" type=""search"" id=""search-field"" name=""search"" placeholder=""ابحث عن ناشر"" style=""font-family: Cairo, sans-serif;"">
                        <input type=""submit"" class=""form-control bg-danger btn-secondary"" value=""بحث"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <div class=\"row people\">\n\n");
#nullable restore
#line 27 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
                      
                        foreach (var item in Model.ListOfAuthor)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6 col-lg-4 item\" data-aos=\"zoom-out\">\n                                <div class=\"box\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e010d477a1c1db0f43af5e8d926e250e7af145238284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1433, "~/Images/", 1433, 9, true);
#nullable restore
#line 32 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
AddHtmlAttributeValue("", 1442, item.ProfileImageUrl, 1442, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    <h3 style=\"font-family:Cairo\" class=\"name\">");
#nullable restore
#line 33 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
                                                                          Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                    <p style=\"font-family:Cairo\" class=\"description\">");
#nullable restore
#line 34 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
                                                                                Write(item.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                    <div class=\"social\"><a");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1742, 1);
#nullable restore
#line 35 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
WriteAttributeValue("", 1729, item.Facbook, 1729, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-facebook-official\"></i></a><a");
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1809, 1);
#nullable restore
#line 35 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
WriteAttributeValue("", 1796, item.Twitter, 1796, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-twitter\"></i></a><a");
            BeginWriteAttribute("href", " href=\"", 1846, "\"", 1868, 1);
#nullable restore
#line 35 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
WriteAttributeValue("", 1853, item.Instagram, 1853, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-instagram\"></i></a></div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 38 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </div>\n            </div>\n            <nav class=\"text-center float-end\" style=\"font-family: Lato, sans-serif;border-color: var(--bs-red);margin: 10px;\">\n                <ul class=\"pagination\">\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e010d477a1c1db0f43af5e8d926e250e7af1452312529", async() => {
                WriteLiteral("\n                            <input type=\"hidden\" value=\"All\" name=\"LoadState\" />\n                            <input type=\"submit\" class=\"form-control bg-danger\" value=\"الصفحة الاولى\" />\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 52 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"

                        if (Model.ListOfAuthor.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e010d477a1c1db0f43af5e8d926e250e7af1452314573", async() => {
                WriteLiteral("\n                                <input type=\"hidden\" value=\"Prev\" name=\"LoadState\" />\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2827, "\"", 2865, 1);
#nullable restore
#line 57 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
WriteAttributeValue("", 2835, Model.ListOfAuthor.First().Id, 2835, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\n                                <input type=\"submit\" class=\"form-control bg-danger\" value=\"السابق\" />\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 60 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
                        }
                        if (Model.ListOfAuthor.Count == Model.NoOfItem)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e010d477a1c1db0f43af5e8d926e250e7af1452317132", async() => {
                WriteLiteral("\n                                <input type=\"hidden\" value=\"Next\" name=\"LoadState\" />\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3340, "\"", 3377, 1);
#nullable restore
#line 65 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
WriteAttributeValue("", 3348, Model.ListOfAuthor.Last().Id, 3348, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\n                                <input type=\"submit\" class=\"form-control bg-info\" value=\"التالي\" />\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 68 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\AllUsers.cshtml"
                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </ul>\n            </nav>\n        </section>\n    </div>\n</section>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticlProject.Pages.AllUsersModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArticlProject.Pages.AllUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArticlProject.Pages.AllUsersModel>)PageContext?.ViewData;
        public ArticlProject.Pages.AllUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
