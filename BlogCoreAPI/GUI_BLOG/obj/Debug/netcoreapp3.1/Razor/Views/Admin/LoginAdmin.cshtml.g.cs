#pragma checksum "D:\BlogCoreAPI\GUI_BLOG\Views\Admin\LoginAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5951f9ec4f668daeee883d01b259d23de60935bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LoginAdmin), @"mvc.1.0.view", @"/Views/Admin/LoginAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5951f9ec4f668daeee883d01b259d23de60935bc", @"/Views/Admin/LoginAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aeee16f29c6396b8c2610300614445b6a7a4547", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_LoginAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BlogCoreAPI\GUI_BLOG\Views\Admin\LoginAdmin.cshtml"
  
    ViewBag.Title = "Login admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
    function Login() {
        var newData = {
            ""email"": $('#email').val(),
            ""password"": $('#passwork').val(),
            ""rememberMe"": $('#rememberMe').val(),
        }
        console.log(newData);
        alert(newData);
        var dataJson = JSON.stringify(newData);
        $.ajax({
            type: ""POST"",
            datatype: ""json"",
            url: ""https://localhost:5000/Account/LoginAccout"",
            contentType: ""application/json; charset=utf-8"",
            data: dataJson,
            success: function (result) {
                if (result.StatusCode == 200) {
                    window.location.href = ""/User/Index"";
                    console.log(data); //just to show that it went through
                } else {
                    alert(""Login fail!"");
                }
            }
        });
    }
</script>
<!-- ");
            WriteLiteral(@"contact section start -->
<div class=""contact_section layout_padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active"" style=""text-indent: 0; border: none; color: #000; font-size: 18px; text-align: center;"">1</li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1"" style=""text-indent: 0; border: none; color: #000; font-size: 18px; text-align: center;"">2</li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2"" style=""text-indent: 0; border: none; color: #000; font-size: 18px; text-align: center;"">3</li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""3"" style=""text-indent: 0; border: none; color: #000; font-s");
            WriteLiteral(@"ize: 18px; text-align: center;"">4</li>
                    </ol>
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <div class=""contact_img""></div>
                        </div>
                        <div class=""carousel-item"">
                            <div class=""contact_img""></div>
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
");
#nullable restore
#line 64 "D:\BlogCoreAPI\GUI_BLOG\Views\Admin\LoginAdmin.cshtml"
                 using (Html.BeginForm("LoginAdmin", "Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5951f9ec4f668daeee883d01b259d23de60935bc7888", async() => {
                WriteLiteral(@"
                        <div class=""mail_section"" style=""text-align:center !important;"">
                            <h1 class=""contact_taital"">ACCONT ADMIN</h1>
                            <input type=""text"" class=""email_text"" id=""email"" placeholder=""Enter Email....."" name=""email"">
                            <input type=""password"" class=""email_text"" id=""passwork"" placeholder=""Enter Passwork...."" name=""passwork"">
                            <input type=""checkbox"" class=""email_text"" id=""rememberMe"" name=""passwork"">
                            <div style=""margin-top:15px;"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 3687, "\"", 3732, 1);
#nullable restore
#line 73 "D:\BlogCoreAPI\GUI_BLOG\Views\Admin\LoginAdmin.cshtml"
WriteAttributeValue("", 3694, Url.Action("RegisterUser", "Account"), 3694, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><b>register account?</b></a>\r\n                            </div>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3830, "\"", 3871, 1);
#nullable restore
#line 75 "D:\BlogCoreAPI\GUI_BLOG\Views\Admin\LoginAdmin.cshtml"
WriteAttributeValue("", 3837, Url.Action("LoginAdmin", "Admin"), 3837, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <button class=\"btn_login\" type=\"submit\" onclick=\"Login()\">Login</button>");
                WriteLiteral("\r\n                        </div>\r\n                    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 78 "D:\BlogCoreAPI\GUI_BLOG\Views\Admin\LoginAdmin.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- contact section end -->\r\n<!-- footer section start -->\r\n<div class=\"footer_section layout_padding\">\r\n    <div class=\"container\">\r\n        <div class=\"footer_logo\"><a href=\"index.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5951f9ec4f668daeee883d01b259d23de60935bc11252", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5951f9ec4f668daeee883d01b259d23de60935bc12778", async() => {
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
            WriteLiteral("</a></li>\r\n                <li><a href=\"#\">Call : +01 1234567890</a></li>\r\n                <li><a href=\"blog.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5951f9ec4f668daeee883d01b259d23de60935bc13929", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591