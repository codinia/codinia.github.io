#pragma checksum "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68001db84357e32ded309ddfc88d5bf1d194f4d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_SingleBlog), @"mvc.1.0.view", @"/Views/Blogs/SingleBlog.cshtml")]
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
#line 1 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\_ViewImports.cshtml"
using codiniatestmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\_ViewImports.cshtml"
using codiniatestmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68001db84357e32ded309ddfc88d5bf1d194f4d8", @"/Views/Blogs/SingleBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e5295077abce261ed9326852876e0b8a0f79ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_SingleBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<codiniatestmvc.Models.Blog>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 91, "\"", 122, 1);
#nullable restore
#line 7 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
WriteAttributeValue("", 101, ViewBag.MetaKeywords, 101, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 156, "\"", 187, 1);
#nullable restore
#line 8 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
WriteAttributeValue("", 166, ViewBag.MetaKeywords, 166, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <title>");
#nullable restore
#line 9 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
      Write(ViewBag.Titles);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"container  pb50 margin\">\r\n\r\n    <div class=\"row\">\r\n        <h6 class=\"text-capitalize\"> ");
#nullable restore
#line 21 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                Write(Html.DisplayFor(model => model.Blog_Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n        <div class=\"col-md-9 mb40\">\r\n\r\n            <article>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 479, "\"", 528, 1);
#nullable restore
#line 25 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
WriteAttributeValue("", 485, Html.DisplayFor(model => model.Blog_Image), 485, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 529, "\"", 535, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid mb30\">\r\n                <div class=\"post-content\">\r\n\r\n                    <ul class=\"post-meta list-inline\">\r\n                        <li class=\"list-inline-item\">\r\n                            <i class=\"fa fa-user-circle-o\"></i> <a");
            BeginWriteAttribute("class", " class=\"", 785, "\"", 793, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 794, "\"", 801, 0);
            EndWriteAttribute();
            WriteLiteral(">  ");
#nullable restore
#line 30 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Author_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li class=\"list-inline-item\">\r\n                            <i class=\"fa fa-calendar-o\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1011, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                                                   Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                        <li class=\"list-inline-item\">\r\n                            <i class=\"fa fa-tags\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 1175, "\"", 1182, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                                             Write(Html.DisplayFor(model => model.BlogPost_Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n                    </ul>\r\n\r\n\r\n                    <div> ");
#nullable restore
#line 41 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                     Write(Html.Raw(Model.blog_Content ?? ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <hr class=""mb40"">
                    <h4 class=""mb40 text-uppercase font500"">Author</h4>
                    <div class=""media mb40"">
                        <i class=""d-flex mr-3 fa fa-user-circle fa-5x text-primary""></i>
                        <div class=""media-body"">
                            <h3 style=""font-weight:bold"" class=""text-capitalize""> ");
#nullable restore
#line 47 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                                                             Write(Html.DisplayFor(model => model.Author_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                    </div>


                    <div class=""container"">
                        <div id=""disqus_thread""></div>
                        <script type=""text/javascript"">
    var disqus_config = function () {
        this.page.url = """);
#nullable restore
#line 56 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                    Write(Context.Request.Scheme);

#line default
#line hidden
#nullable disable
            WriteLiteral("://");
#nullable restore
#line 56 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                              Write(Context.Request.Host);

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                                                   Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        this.page.identifier = \"");
#nullable restore
#line 57 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                           Write(Context.Request.Scheme);

#line default
#line hidden
#nullable disable
            WriteLiteral("://");
#nullable restore
#line 57 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                                     Write(Context.Request.Host);

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\.NET CORE\codiniatestmvc\codiniatestmvc\Views\Blogs\SingleBlog.cshtml"
                                                                          Write(Context.Request.Path);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    };
    (function () {
        var d = document, s = d.createElement('script');
        s.src = '//codinia-com.disqus.com/embed.js';
        s.setAttribute('data-timestamp', +new Date());
        (d.head || d.body).appendChild(s);
    })();
                        </script>
                        <noscript>Please enable JavaScript to view the <a href=""https://disqus.com/?ref_noscript"">comments powered by Disqus.</a></noscript>
                        <script id=""dsq-count-scr"" src=""//codinia-com.disqus.com/count.js"" async></script>
                    </div>
                </div>





        </div>
        </article>

        <div class=""col-md-3  border-left-25 mb40"">
            <div class=""mb40"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68001db84357e32ded309ddfc88d5bf1d194f4d811176", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search..."" aria-describedby=""basic-addon2"">
                        <button class=""input-group-addon"" id=""basic-addon2""><i class=""fa fa-search""></i></button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <div class=""mb40"">
                <h4 class=""sidebar-title"">Categories</h4>
                <ul class=""list-unstyled categories"">
                    <li><a href=""#"">WEB Development</a></li>
                    <li><a href=""#"">Sale</a></li>
                    <li class=""active"">
                        <a href=""#"">Apartment</a>
                        <ul class=""list-unstyled"">
                            <li><a href=""#"">Office</a></li>
                            <li><a href=""#"">Godown</a></li>
                            <li><a href=""#"">Gerage</a></li>
                        </ul>
                    </li>
                    
                </ul>
            </div>


        </div>
    </div>

</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<codiniatestmvc.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
