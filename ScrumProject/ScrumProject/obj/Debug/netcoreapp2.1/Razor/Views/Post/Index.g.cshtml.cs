#pragma checksum "E:\Nam3-hk2-2019\GITHUB\Axon_ScrumProject\ScrumProject\ScrumProject\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574fafaee266bbe45ea0cbd86efc4ace90622ae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 1 "E:\Nam3-hk2-2019\GITHUB\Axon_ScrumProject\ScrumProject\ScrumProject\Views\_ViewImports.cshtml"
using ScrumProject;

#line default
#line hidden
#line 2 "E:\Nam3-hk2-2019\GITHUB\Axon_ScrumProject\ScrumProject\ScrumProject\Views\_ViewImports.cshtml"
using ScrumProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574fafaee266bbe45ea0cbd86efc4ace90622ae9", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e9e2dc6b73540410acf4262e8a87fefde5b282", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScrumProject.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\Nam3-hk2-2019\GITHUB\Axon_ScrumProject\ScrumProject\ScrumProject\Views\Post\Index.cshtml"
  
    Layout = null;
    List<HouseType> TypeList = (List<HouseType>) ViewBag.TypeList;

#line default
#line hidden
            BeginContext(251, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(290, 1093, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716297efc8de4183ab48153d845c36db", async() => {
                BeginContext(296, 1080, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">

    <title>Agency - Start Bootstrap Theme</title>

    <!-- Bootstrap core CSS -->
    <link href=""vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Custom fonts for this template -->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>

    <!-- Custom styles for this template -->
 ");
                WriteLiteral("   <link href=\"css/agency.min.css\" rel=\"stylesheet\">\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1383, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1387, 6334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ab2fc2f6554eb5a912bcb69b6ec6ab", async() => {
                BeginContext(1407, 1791, true);
                WriteLiteral(@"

    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg navbar-dark fixed-top"" id=""mainNav"">
        <div class=""container"">
            <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">Student Accomodation</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                Menu
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav text-uppercase ml-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#services"">Home</a>
                    </li>

                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#about"">About</a>
                    </li>
                    ");
                WriteLiteral(@"<li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#team"">Team</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#contact"">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Header
    <header class=""masthead"">
        <div class=""container"">
            <div class=""intro-text"">
                <div class=""intro-lead-in"">Welcome To Our Studio!</div>
                <div class=""intro-heading text-uppercase"">It's Nice To Meet You</div>

            </div>
        </div>
    </header> -->

    <section>
        <div class=""container"">
            ");
                EndContext();
                BeginContext(3198, 2379, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b5bd5c447b44a3bc92ad9a4ccb8f34", async() => {
                    BeginContext(3204, 2366, true);
                    WriteLiteral(@"
                <div class=""form-group"">
                  <label for=""exampleInputEmail1"">Tiêu đề</label>
                  <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder="""">
                  <!-- <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
                </div> -->
                <div class=""form-group"">
                  <label for=""exampleInputPassword1"">Diện tích </label>
                  <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder="""">
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Giá cho thuê</label>
                    <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder="""">
                  </div>
                  <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Người cho thuê</label>
     ");
                    WriteLiteral(@"               <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder="""">
                  </div>
                  <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Số điện thoại</label>
                    <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder="""">
                  </div>
                  <div class=""form-group"">
                    <label for=""exampleInputPassword1"">Hình ảnh</label>
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <label></label>
                            <div class=""input-group"">
                                <span class=""input-group-btn"">
                                    <span class=""btn btn-default btn-file"">
                                         <input type=""file"" id=""imgInp"">
                                    </span>
                                </span>
                           ");
                    WriteLiteral(@"     
                            </div>
                            <img id='img-upload'/>
                        </div>
                    </div>
                  </div>
                
                </div>
                <button type=""submit"" class=""btn btn-primary"">Đăng bài</button>
              ");
                    EndContext();
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
                EndContext();
                BeginContext(5577, 2137, true);
                WriteLiteral(@"
        </div>
    </section>


    <!-- Footer -->
    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4"">
                    <span class=""copyright"">Copyright &copy; CL-Five Team 2019</span>
                </div>
                <div class=""col-md-4"">
                    <ul class=""list-inline social-buttons"">
                        <li class=""list-inline-item"">
                            <a href=""#"">
                                <i class=""fab fa-twitter""></i>
                            </a>
                        </li>
                        <li class=""list-inline-item"">
                            <a href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                            </a>
                        </li>
                        <li class=""list-inline-item"">
                            <a href=""#"">
                                <i class=""fab fa-linkedin-in""></i>
               ");
                WriteLiteral(@"             </a>
                        </li>
                    </ul>
                </div>
                <div class=""col-md-4"">
                    <ul class=""list-inline quicklinks"">
                        <li class=""list-inline-item"">
                            <a href=""#"">Privacy Policy</a>
                        </li>
                        <li class=""list-inline-item"">
                            <a href=""#"">Terms of Use</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>




    <!-- Bootstrap core JavaScript -->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Plugin JavaScript -->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Contact form JavaScript -->
    <script src=""js/jqBootstrapValidation.js""></script>
    <script src=""js/contact_me.js""></script>

    <!");
                WriteLiteral("-- Custom scripts for this template -->\r\n    <script src=\"js/agency.min.js\"></script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7721, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScrumProject.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
