#pragma checksum "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263dc554c983fec7bc7b694f26e519e8a0accc75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ArticlProject.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263dc554c983fec7bc7b694f26e519e8a0accc75", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859cebf0b00ca21327ddb5fc327d3e2830c4b190", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid d-block mx-auto mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("me-auto search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_self"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top w-100 d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: Cairo, sans-serif;width: 149.875px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header class=\"text-center text-white bg-primary masthead\">\n    <div class=\"container\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "263dc554c983fec7bc7b694f26e519e8a0accc758961", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <h1 style=""font-family: Cairo, sans-serif;"">نبذات</h1>
        <hr class=""star-light"">
        <h2 class=""font-weight-light mb-0"" style=""font-family: Cairo, sans-serif;"">مرحبا بك في موقع نبذات</h2>
        <h2 class=""font-weight-light mb-0"" style=""font-family: Cairo, sans-serif;margin: 11px;font-size: 21px;"">&nbsp; :) يسعدنا انضمامك معنا&nbsp;</h2>
    </div><button class=""btn btn-primary"" type=""button"" style=""width: 254.5625px;background: var(--bs-blue);font-family: Cairo, sans-serif;height: 50px;margin: 5px;""><i class=""fa fa-sign-in""></i><span style=""margin: 15px;"">انضم الان&nbsp;</span></button>
</header>

<section id=""portfolio"" class=""portfolio"">
    <div class=""container"">
        <h2 class=""text-uppercase text-center text-secondary bounce animated"" style=""font-family: Cairo, sans-serif;"">اخر المقالات</h2>
        <div>
            <nav class=""navbar navbar-dark navbar-expand-lg bg-secondary navigation-clean-search"" style=""margin: 20px;"">
                <div class=""container"">
                ");
            WriteLiteral(@"    <button data-bs-toggle=""collapse"" class=""navbar-toggler"" data-bs-target=""#navcol-1""><span class=""visually-hidden"">Toggle navigation</span><span class=""navbar-toggler-icon""></span></button>
                    <div class=""collapse navbar-collapse"" id=""navcol-1"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item""></li>
                            <li class=""nav-item""></li>
                            <li class=""nav-item""></li>
                        </ul>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7511722", async() => {
                WriteLiteral(@"
                            <div class=""d-flex align-items-center"">
                                <label class=""form-label d-flex mb-0"" for=""search-field"">
                                    <i class=""fa fa-search""></i>
                                </label>
                                <input type=""hidden"" value=""Search"" name=""LoadState"" />

                                <input class=""form-control search-field"" type=""search"" id=""search-field"" name=""search"" placeholder=""ابحث عن مقالة"" style=""font-family: Cairo, sans-serif;"">
                                <input type=""submit"" class=""form-control bg-danger btn-secondary"" value=""بحث"" />
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                        <ul class=\"navbar-nav\">\n");
#nullable restore
#line 44 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
                              
                                foreach (var item in Model.ListOfCategory)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7514283", async() => {
                WriteLiteral(@"
                                        <input type=""hidden"" value=""ByCategory"" name=""LoadState"" />
                                    <li class=""nav-item m-1 "">
                                        <input type=""submit"" class=""form-control m-2"" name=""CategoryName""");
                BeginWriteAttribute("value", " value=\"", 3073, "\"", 3091, 1);
#nullable restore
#line 50 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
WriteAttributeValue("", 3081, item.Name, 3081, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"font-family: Cairo, sans-serif;\" />\n                                    </li>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 53 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7516780", async() => {
                WriteLiteral(@"
                                <input type=""hidden"" value=""All"" name=""LoadState"" />
                            <li class=""nav-item m-1"">
                                <input type=""submit"" class=""form-control m-2"" value=""جميع الاصناف"" style=""font-family: Cairo, sans-serif;"" />
                            </li>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </ul>\n                    </div>\n                </div>\n            </nav>\n        </div>\n        <hr class=\"star-dark mb-5\">\n        <div class=\"row row-cols-3\" id=\"datasection\">\n\n");
#nullable restore
#line 69 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
              

                foreach (var item in Model.ListOfPost)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col\" data-bss-hover-animate=\"pulse\" style=\"margin: 0;margin-top: 10px;\">\n                        <div class=\"card\" style=\"margin: 10;\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "263dc554c983fec7bc7b694f26e519e8a0accc7519276", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4220, "~/Images/", 4220, 9, true);
#nullable restore
#line 75 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
AddHtmlAttributeValue("", 4229, item.PostImageUrl, 4229, 18, false);

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
            WriteLiteral("\n                            <div class=\"card-body\">\n                                <h4 class=\"text-center card-title\" style=\"font-family: Cairo, sans-serif;\">");
#nullable restore
#line 77 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
                                                                                                      Write(item.PostTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7521336", async() => {
                WriteLiteral("قراءة");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
                                                                                                                                                                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 81 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
                }


            

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n        </div>\n    </div>\n    <nav class=\"text-center float-end\" style=\"font-family: Lato, sans-serif;border-color: var(--bs-red);margin: 10px;\">\n        <ul class=\"pagination\">\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7524513", async() => {
                WriteLiteral("\n                    <input type=\"hidden\" value=\"All\" name=\"LoadState\" />\n                    <input type=\"submit\" class=\"form-control bg-danger\" value=\"الصفحة الاولى\" />\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 97 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"

                if (Model.ListOfPost.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7526505", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" value=\"Prev\" name=\"LoadState\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5397, "\"", 5433, 1);
#nullable restore
#line 102 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
WriteAttributeValue("", 5405, Model.ListOfPost.First().Id, 5405, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\n                        <input type=\"submit\" class=\"form-control bg-danger\" value=\"السابق\" />\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 105 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
                }
                if (Model.ListOfPost.Count == Model.NoOfItem)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7528993", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" value=\"Next\" name=\"LoadState\" />\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5842, "\"", 5877, 1);
#nullable restore
#line 110 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
WriteAttributeValue("", 5850, Model.ListOfPost.Last().Id, 5850, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\n                        <input type=\"submit\" class=\"form-control bg-info\" value=\"التالي\" />\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 113 "C:\Users\Mo Dawoud\Desktop\ArticlProject-master\ArticlProject\Pages\Index.cshtml"
                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </ul>
    </nav>
</section>
<section class=""text-white bg-primary mb-0"" id=""about"">
    <div class=""container"">
        <h2 class=""text-uppercase text-center text-white"" style=""font-family: Cairo, sans-serif;"">حول الموقع</h2>
        <hr class=""star-light mb-5"">
        <div class=""row align-items-center"">
            <div class=""col"">
                <p class=""lead text-center"" style=""font-family: Cairo, sans-serif;"">نحن نوفر لك الدعم الكامل لنشر مقالاتك ومشاركتها مع الاخرين . حيث ان موقع نبذة يضمن لك كافة الحقوق للمقالات التي تنشرها&nbsp; على الموقع&nbsp;</p>
            </div>
        </div>
        <div class=""text-center mt-4""><a class=""btn btn-outline-light btn-xl"" role=""button"" href=""#""><i class=""fa fa-american-sign-language-interpreting me-2""></i><span style=""font-family: Cairo, sans-serif;"">اشترك الان وانضم معنا&nbsp;</span></a></div>
    </div>
</section>
<section id=""contact"">
    <div class=""container"">
        <h2 class=""text-uppercase text-center text-secondary mb-0"" style=""font-family:");
            WriteLiteral(" Cairo, sans-serif;\">تواصل معنا&nbsp;</h2>\n        <hr class=\"star-dark mb-5\">\n        <div class=\"row\">\n            <div class=\"col-lg-8 mx-auto\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "263dc554c983fec7bc7b694f26e519e8a0accc7532663", async() => {
                WriteLiteral("\n                    <div class=\"control-group\">\n                        <div class=\"mb-0 form-floating controls pb-2\"><input class=\"form-control\" type=\"text\" id=\"name\"");
                BeginWriteAttribute("required", " required=\"", 7467, "\"", 7478, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""الاسم"" style=""font-family: Cairo, sans-serif;""><label class=""form-label"">Name</label><small class=""form-text text-danger help-block""></small></div>
                    </div>
                    <div class=""control-group"">
                        <div class=""mb-0 form-floating controls pb-2""><input class=""form-control"" type=""email"" id=""email""");
                BeginWriteAttribute("required", " required=\"", 7837, "\"", 7848, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Email Address"" style=""font-family: Cairo, sans-serif;""><label class=""form-label"">Email Address</label><small class=""form-text text-danger help-block""></small></div>
                    </div>
                    <div class=""control-group"">
                        <div class=""mb-0 form-floating controls pb-2""><input class=""form-control"" type=""tel"" id=""phone""");
                BeginWriteAttribute("required", " required=\"", 8222, "\"", 8233, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Phone Number"" style=""font-family: Cairo, sans-serif;""><label class=""form-label"">Phone Number</label><small class=""form-text text-danger help-block""></small></div>
                    </div>
                    <div class=""control-group"">
                        <div class=""mb-5 form-floating controls pb-2""><textarea class=""form-control"" id=""message""");
                BeginWriteAttribute("required", " required=\"", 8599, "\"", 8610, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Message"" style=""height: 150px;font-family: Cairo, sans-serif;""></textarea><label class=""form-label"">Message</label><small class=""form-text text-danger help-block""></small></div>
                    </div>
                    <div id=""success""></div>
                    <div><button class=""btn btn-primary float-end btn-xl"" id=""sendMessageButton"" type=""submit"" style=""font-family: Cairo, sans-serif;"">ارسل</button></div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
