#pragma checksum "D:\BlogCoreAPI\GUI_BLOG\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a340deb3f29190436798e28b398d1464418ad6e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "D:\BlogCoreAPI\GUI_BLOG\Views\_ViewImports.cshtml"
using GUI_BLOG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlogCoreAPI\GUI_BLOG\Views\_ViewImports.cshtml"
using GUI_BLOG.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a340deb3f29190436798e28b398d1464418ad6e2", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aeee16f29c6396b8c2610300614445b6a7a4547", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/footer-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/call-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/mail-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BlogCoreAPI\GUI_BLOG\Views\Account\Index.cshtml"
  
    ViewBag.Title = "homepage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a340deb3f29190436798e28b398d1464418ad6e24622", async() => {
                WriteLiteral(@"

    <!-- basic -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- mobile metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""viewport"" content=""initial-scale=1, maximum-scale=1"">
    <!-- site metas -->
    <title>Bloscot</title>
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 563, "\"", 573, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 605, "\"", 615, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 642, "\"", 652, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <!-- bootstrap css -->
    <link rel=""stylesheet"" type=""text/css"" href=""css/bootstrap.min.css"">
    <!-- style css -->
    <link rel=""stylesheet"" type=""text/css"" href=""css/style.css"">
    <!-- Responsive-->
    <link rel=""stylesheet"" href=""css/responsive.css"">
    <!-- fevicon -->
    <link rel=""icon"" href=""images/fevicon.png"" type=""image/gif"" />
    <!-- Scrollbar Custom CSS -->
    <link rel=""stylesheet"" href=""css/jquery.mCustomScrollbar.min.css"">
    <!-- Tweaks for older IEs-->
    <link rel=""stylesheet"" href=""https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css"">
    <!-- owl stylesheets -->
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesoeet"" href=""css/owl.theme.default.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css"" media=""screen"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <style>
        .btn_readm");
                WriteLiteral("e {\r\n            padding: 3px 12px;\r\n            background-color: black;\r\n            color: white;\r\n        }\r\n\r\n            .btn_readme:hover {\r\n                opacity: 0.5;\r\n            }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a340deb3f29190436798e28b398d1464418ad6e27919", async() => {
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            loadData();
        });
        function loadData() {
            $.ajax({
                url: ""https://localhost:5000/Admin/GetAllPost"",
                type: ""GET"",
                success: function (rs) {
                    console.log(rs);
                    var str = """";
                    $.each(rs, function (i, item) {
                        $('#load_data').append(`
                        <div class=""col-lg-8 col-sm-12"">
                            <div class=""about_img""><img src=""./${item.slug}""></div>
                            <div class=""like_icon""><img src=""./images/like-icon.png""></div>
                            <p class=""post_text"">Post By :${item.createAT}</p>
                            <h2 class=""most_text"">${item.title}</h2>
                            <p class=""lorem_text"">${item.content}</p>
                            <div class=""social_icon_main"">
                                <div class=""");
                WriteLiteral(@"social_icon"">
                                    <ul>
                                        <li><a href=""#""><img src=""./images/fb-icon.png""></a></li>
                                        <li><a href=""#""><img src=""./images/twitter-icon.png""></a></li>
                                        <li><a href=""#""><img src=""./images/instagram-icon.png""></a></li>
                                    </ul>
                                </div>
                                <div class=""read_bt""><a href=""Account/DetailPost/${item.postID}"">Read More</a></div>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-sm-12"">
                            <h1 class=""about_taital"">About Us</h1>
                            <p class=""about_text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis</p>
                            <div class=""read_bt_1""><a ");
                WriteLiteral(@"href=""#"">Read More</a></div>
                        </div>`);

                    });

                }
            });
        }
      
    </script>
    <!-- header section start -->
    <!-- header section end -->
    <div class=""container"">
        <div class=""touch_setion"">

            <div class=""box_main"">
                <div class=""image_2 active"">
                    <h4 class=""who_text active"">Who am i</h4>
                </div>
            </div>
            <div class=""box_main"">
                <div class=""image_3"">
                    <h4 class=""who_text"">Get In Touch</h4>
                </div>
            </div>
            <div class=""box_main"">
                <div class=""image_4"">
                    <h4 class=""who_text"">Facebook</h4>
                </div>
            </div>
        </div>
    </div>
    <!-- about section start -->
    <div class=""about_section layout_padding"">
        <div class=""container"">
            <div class=""row"">
");
                WriteLiteral(@"                <div class=""col-lg-8 col-sm-12"">
                    <div id=""load_data"">
                    </div>
                </div>
                <div class=""col-lg-4 col-sm-12"">
                    <h1 class=""about_taital"">About Us</h1>
                    <p class=""about_text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis</p>
                    <div class=""read_bt_1""><a href=""#"">Read More</a></div>
                </div>
            </div>
        </div>
    </div>

    <!-- recent section end -->
    <!-- tag section start -->
    <div class=""tag_section layout_padding"">
        <div class=""container"">
            <h1 class=""tag_taital"">Tag</h1>
            <div class=""tag_bt"">
                <ul>
                    <li class=""active""><a href=""#"">Ectetur</a></li>
                    <li><a href=""#"">Onsectetur</a></li>
                    <li><a href=""#"">Consectetur<");
                WriteLiteral(@"/a></li>
                    <li><a href=""#"">Consectetur</a></li>
                    <li><a href=""#"">Consectetur</a></li>
                </ul>
            </div>
            <div class=""tag_bt_2"">
                <ul>
                    <li><a href=""#"">Tetur</a></li>
                    <li><a href=""#"">Conse</a></li>
                    <li><a href=""#"">Nsectetur</a></li>
                    <li><a href=""#"">Sectetur</a></li>
                    <li><a href=""#"">Consectetur</a></li>
                </ul>
            </div>
        </div>
    </div>
    <!-- tag section end -->
    <!-- contact section start -->
    <div class=""contact_section layout_padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                        <ol class=""carousel-indicators"">
                            <li data-target=""#carouselExampleIndicators"" ");
                WriteLiteral(@"data-slide-to=""0"" class=""active"" style=""text-indent: 0; border: none; color: #000; font-size: 18px; text-align: center;"">1</li>
                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1"" style=""text-indent: 0; border: none; color: #000; font-size: 18px; text-align: center;"">2</li>
                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2"" style=""text-indent: 0; border: none; color: #000; font-size: 18px; text-align: center;"">3</li>
                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""3"" style=""text-indent: 0; border: none; color: #000; font-size: 18px; text-align: center;"">4</li>
                        </ol>
                        <div class=""carousel-inner"">
                            <div class=""carousel-item active"">
                                <div class=""contact_img""></div>
                            </div>
                            <div class=""carousel-item"">
                           ");
                WriteLiteral(@"     <div class=""contact_img""></div>
                            </div>
                            <div class=""carousel-item"">
                                <div class=""contact_img""></div>
                            </div>
                            <div class=""carousel-item"">
                                <div class=""contact_img""></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""mail_section"">
                        <h1 class=""contact_taital"">Contact us</h1>
                        <input type=""text"" class=""email_text"" placeholder=""Name"" name=""Name"">
                        <input type=""text"" class=""email_text"" placeholder=""Phone"" name=""Phone"">
                        <input type=""text"" class=""email_text"" placeholder=""Email"" name=""Email"">
                        <textarea class=""massage_text"" placeholder=""Message"" rows=""5"" id=""comment"" name=""");
                WriteLiteral(@"Message""></textarea>
                        <div class=""send_bt""><a href=""#"">send</a></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- contact section end -->
    <!-- footer section start -->
    <div class=""footer_section layout_padding"">
        <div class=""container"">
            <div class=""footer_logo""><a href=""index.html"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a340deb3f29190436798e28b398d1464418ad6e216228", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a></div>
            <div class=""footer_menu"">
                <ul>
                    <li><a href=""index.html"">Home</a></li>
                    <li><a href=""about.html"">About</a></li>
                    <li><a href=""blog.html"">Blog</a></li>
                    <li><a href=""features.html"">Features</a></li>
                    <li><a href=""contact.html"">contact us</a></li>
                </ul>
            </div>
            <div class=""contact_menu"">
                <ul>
                    <li><a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a340deb3f29190436798e28b398d1464418ad6e217858", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a></li>\r\n                    <li><a href=\"#\">Call : +01 1234567890</a></li>\r\n                    <li><a href=\"blog.html\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a340deb3f29190436798e28b398d1464418ad6e219073", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a></li>
                    <li><a href=""features.html"">demo@gmail.com</a></li>
                </ul>
            </div>
        </div>
    </div>
    <!-- footer section end -->
    <!-- copyright section start -->
    <div class=""copyright_section"">
        <div class=""container"">
            <p class=""copyright_text"">Copyright 2020 All Right Reserved By.<a href=""https://html.design""> Free  html Templates</a></p>
        </div>
    </div>
    <!-- copyright section end -->
    <!-- Javascript files-->
    <script src=""js/jquery.min.js""></script>
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.bundle.min.js""></script>
    <script src=""js/jquery-3.0.0.min.js""></script>
    <script src=""js/plugin.js""></script>
    <!-- sidebar -->
    <script src=""js/jquery.mCustomScrollbar.concat.min.js""></script>
    <script src=""js/custom.js""></script>
    <!-- javascript -->
    <script src=""js/owl.carousel.js""></script>
    <script src=""https:cdnjs.cloudflare.com/ajax/");
                WriteLiteral("libs/fancybox/2.1.5/jquery.fancybox.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
