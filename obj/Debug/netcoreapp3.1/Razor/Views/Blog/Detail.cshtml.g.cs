#pragma checksum "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ce966cfa348a0c7ebb272839dd476846b3e4158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
#line 1 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\_ViewImports.cshtml"
using WebBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\_ViewImports.cshtml"
using WebBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce966cfa348a0c7ebb272839dd476846b3e4158", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87faabc78204931c4e49673210491a7b466fd977", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBlog.Models.BlogModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <!--================ Hero sm Banner start =================-->      
  <section class=""mb-30px"">
    <div class=""container"">
      <div class=""hero-banner hero-banner--sm"">
        <div class=""hero-banner__content"">
          <h1>Post Details</h1>
          <nav aria-label=""breadcrumb"" class=""banner-breadcrumb"">
            <ol class=""breadcrumb"">
              <li class=""breadcrumb-item""><a href=""#"">Post</a></li>
              <li class=""breadcrumb-item active"" aria-current=""page"">Details</li>
            </ol>
          </nav>
        </div>
      </div>
    </div>
  </section>
  <!--================ Hero sm Banner end =================-->    

  
  <!--================ Start Blog Post Area =================-->
  <section class=""blog-post-area section-margin mt-4"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-8"">
            <div class=""main_blog_details"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ce966cfa348a0c7ebb272839dd476846b3e41584589", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml"
                                 WriteLiteral("~/img/"+Model.ImagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h4>");
#nullable restore
#line 32 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                <div class=""user_details"">
                  <div class=""float-left"">
                    <a href=""#"">Lifestyle</a>
                    <a href=""#"">Gadget</a>
                  </div>
                  <div class=""float-right mt-sm-0 mt-3"">
                    <div class=""media"">
                      <div class=""media-body"">
                        <h5>Mark wiens</h5>
                        <p>12 Dec, 2017 11:21 am</p>
                      </div>
                      <div class=""d-flex"">
                        <img width=""42"" height=""42"" src=""img/blog/user-img.png""");
            BeginWriteAttribute("alt", " alt=\"", 1785, "\"", 1791, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n                <p>");
#nullable restore
#line 50 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml"
              Write(Html.DisplayFor(modelItem => Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           <blockquote class=\"blockquote\">\r\n             <p class=\"mb-0\">");
#nullable restore
#line 52 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           </blockquote>\r\n           <p>");
#nullable restore
#line 54 "C:\Users\TojuOfe\Desktop\New folder\Blazor\WebBlog\Views\Blog\Detail.cshtml"
         Write(Html.DisplayFor(modelItem => Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
               <div class=""news_d_footer flex-column flex-sm-row"">
                 <a href=""#""><span class=""align-middle mr-2""><i class=""ti-heart""></i></span>Lily and 4 people like this</a>
                 <a class=""justify-content-sm-center ml-sm-auto mt-sm-0 mt-2"" href=""#""><span class=""align-middle mr-2""><i class=""ti-themify-favicon""></i></span>06 Comments</a>
                 <div class=""news_socail ml-sm-auto mt-sm-0 mt-2"">
               <a href=""#""><i class=""fab fa-facebook-f""></i></a>
               <a href=""#""><i class=""fab fa-twitter""></i></a>
               <a href=""#""><i class=""fab fa-dribbble""></i></a>
               <a href=""#""><i class=""fab fa-behance""></i></a>
             </div>
               </div>
              </div>
        </div>

        <!-- Start Blog Post Siddebar -->
        <div class=""col-lg-4 sidebar-widgets"">
            <div class=""widget-wrap"">
              <div class=""single-sidebar-widget newsletter-widget"">
                <h4 class=""font-weight-bo");
            WriteLiteral(@"ld"">Newsletter</h4>
                <div class=""form-group mt-30"">
                  <div class=""col-autos"">
                    <input type=""text"" class=""form-control"" id=""inlineFormInputGroup"" placeholder=""Enter email"" onfocus=""this.placeholder = ''""
                      onblur=""this.placeholder = 'Enter email'"">
                  </div>
                </div>
                <button class=""bbtns d-block mt-20 w-100"">Subcribe</button>
              </div>


              <div class=""single-sidebar-widget post-category-widget"">
                <h4 class=""font-weight-bold"">Category</h4>
                <ul class=""cat-list mt-20"">
                  <li>
                    <a href=""#"" class=""d-flex justify-content-between"">
                      <p>Technology</p>
                      <p>(03)</p>
                    </a>
                  </li>
                  <li>
                    <a href=""#"" class=""d-flex justify-content-between"">
                      <p>Software</p>
           ");
            WriteLiteral(@"           <p>(09)</p>
                    </a>
                  </li>
                  <li>
                    <a href=""#"" class=""d-flex justify-content-between"">
                      <p>Lifestyle</p>
                      <p>(12)</p>
                    </a>
                  </li>
                  <li>
                    <a href=""#"" class=""d-flex justify-content-between"">
                      <p>Shopping</p>
                      <p>(02)</p>
                    </a>
                  </li>
                  <li>
                    <a href=""#"" class=""d-flex justify-content-between"">
                      <p>Food</p>
                      <p>(10)</p>
                    </a>
                  </li>
                </ul>
              </div>
             

                <div class=""single-sidebar-widget tag_cloud_widget"">
                  <h4 class=""font-weight-bold"">Popular Post</h4>
                  <ul class=""list"">
                    <li>
                        <");
            WriteLiteral(@"a href=""#"">project</a>
                    </li>
                    <li>
                        <a href=""#"">love</a>
                    </li>
                    <li>
                        <a href=""#"">technology</a>
                    </li>
                    <li>
                        <a href=""#"">travel</a>
                    </li>
                    <li>
                        <a href=""#"">software</a>
                    </li>
                    <li>
                        <a href=""#"">life style</a>
                    </li>
                    <li>
                        <a href=""#"">design</a>
                    </li>
                    <li>
                        <a href=""#"">illustration</a>
                    </li>
                  </ul>
                </div>

              </div>
            </div>
          </div>
        <!-- End Blog Post Siddebar -->
      </div>
  </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBlog.Models.BlogModel> Html { get; private set; }
    }
}
#pragma warning restore 1591