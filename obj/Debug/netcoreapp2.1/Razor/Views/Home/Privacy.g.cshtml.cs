#pragma checksum "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a79d52c84314d27d3e67fd585208790b6965ba57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "F:\Zaliczenie\Zaliczenie\Views\_ViewImports.cshtml"
using Zaliczenie;

#line default
#line hidden
#line 2 "F:\Zaliczenie\Zaliczenie\Views\_ViewImports.cshtml"
using Zaliczenie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a79d52c84314d27d3e67fd585208790b6965ba57", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4542dc8cf2fad2d1067b49c73eaa0bdc9f210232", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Zaliczenie.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:transparent; border:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Wiadomosci", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/PMRP.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/NMRP.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(94, 85, true);
            WriteLiteral("<style>\r\n    .popup:hover {\r\n        text-decoration: underline;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(179, 4610, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29d54463ea6a4e819d4cca9de9cfae1d", async() => {
                BeginContext(185, 459, true);
                WriteLiteral(@"
    <div class=""col-md-12"" style=""background-color:white"">
        <div class=""col-md-6"">
            <br /><br />  <br />

            <asp:Content ID=""Content1"" ContentPlaceHolderID=""MainContent"" Runat=""Server"">

                <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" style=""overflow:hidden; width:525px;height:300px"">
                    <div class=""carousel-inner"">
                        <!-- Wrapper for slides -->
");
                EndContext();
#line 21 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
                BeginContext(739, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 24 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#line 26 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                             if (i == 0)
                            {

#line default
#line hidden
                BeginContext(893, 97, true);
                WriteLiteral("                                <div class=\"item active\">\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 990, "\"", 1037, 1);
#line 29 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 997, Html.DisplayFor(modelItem => item.Link), 997, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1038, 47, true);
                WriteLiteral(">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1085, "\"", 1130, 1);
#line 30 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 1091, Html.DisplayFor(modelItem => item.Img), 1091, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1131, 313, true);
                WriteLiteral(@" style=""overflow:hidden"" />
                                        <div class=""carousel-caption d-none d-md-block popup"">
                                            <div class=""fixed-bottom"" style=""font-size:21px;text-shadow:   -1px -1px 0 #000,      1px -1px 0 #000,    -1px 1px 0 #000,     1px 1px 0 #000;"">");
                EndContext();
                BeginContext(1445, 40, false);
#line 32 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                                                                                                                                                                                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(1485, 138, true);
                WriteLiteral("</div>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n");
                EndContext();
#line 36 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(1719, 90, true);
                WriteLiteral("                                <div class=\"item\">\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1809, "\"", 1856, 1);
#line 40 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 1816, Html.DisplayFor(modelItem => item.Link), 1816, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1857, 47, true);
                WriteLiteral(">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1904, "\"", 1949, 1);
#line 41 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 1910, Html.DisplayFor(modelItem => item.Img), 1910, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1950, 312, true);
                WriteLiteral(@" style=""overflow:hidden""/>
                                        <div class=""carousel-caption d-none d-md-block popup"">
                                            <div class=""fixed-bottom"" style=""font-size:21px;text-shadow:   -1px -1px 0 #000,      1px -1px 0 #000,    -1px 1px 0 #000,     1px 1px 0 #000;"">");
                EndContext();
                BeginContext(2263, 40, false);
#line 43 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                                                                                                                                                                                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(2303, 140, true);
                WriteLiteral("</div>\r\n                                        </div>\r\n\r\n                                    </a>\r\n                                </div>\r\n");
                EndContext();
#line 48 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                            }

#line default
#line hidden
#line 48 "F:\Zaliczenie\Zaliczenie\Views\Home\Privacy.cshtml"
                             
                            i++;
                        }

#line default
#line hidden
                BeginContext(2535, 665, true);
                WriteLiteral(@"                    </div>

                    <a class=""left carousel-control"" data-target=""#myCarousel"" data-slide=""prev"">
                        <span class=""glyphicon glyphicon-chevron-left""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""right carousel-control"" data-target=""#myCarousel"" data-slide=""next"">
                        <span class=""glyphicon glyphicon-chevron-right""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </asp:Content>

            <!-- Indicators -->

            ");
                EndContext();
                BeginContext(3200, 353, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c82c4cb95b9140aaa0dddf5c83d2641e", async() => {
                    BeginContext(3302, 247, true);
                    WriteLiteral("\r\n                <input type=\"submit\" value=\"Przeczytaj więcej!\" style=\"width:500px;height:100px; background-color:#2f353b;color:white; text-shadow:   -1px -1px 0 #000,      1px -1px 0 #000,    -1px 1px 0 #000,     1px 1px 0 #000;\">\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3553, 337, true);
                WriteLiteral(@"
        </div>
        <div class=""col-lg-4"">
            <h1>Poprzedni mecz</h1>
            <a href=""https://www.google.com/search?gs_ssp=eJzj4tTP1TcwTjLLsjBgBAAR2QKt&q=reprezentacja+polski&oq=repre&aqs=chrome.0.46j69i57j69i60l3j69i59.719j1j4&sourceid=chrome&ie=UTF-8#sie=m;/g/11h22xdxpd;2;/m/0zdsnbj;dt;fp;1;;"">
                ");
                EndContext();
                BeginContext(3890, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b051c08f9c66444db47827429fa7b336", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3920, 370, true);
                WriteLiteral(@"
            </a>
            <hr style=""border:solid; color:red; width:550px"" />
            <h1>Kolejny mecz</h1>
            <a href=""https://www.google.com/search?gs_ssp=eJzj4tTP1TcwTjLLsjBgBAAR2QKt&q=reprezentacja+polski&oq=repre&aqs=chrome.0.46j69i57j69i60l3j69i59.719j1j4&sourceid=chrome&ie=UTF-8#sie=m;/g/11gxs6l2kl;2;/m/0zdsnbj;dt;fp;1;;"">
                ");
                EndContext();
                BeginContext(4290, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4442dadce4a94721bb69b52d068af291", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4321, 461, true);
                WriteLiteral(@"
            </a>
        </div>
        <p style=""clear:both;""></p>
        <hr style=""color:red; border:solid"" />
        <div style=""text-align:center"">
            <a href=""https://www.r-gol.com/sklep-kibica-reprezentacji-polski.html"">
                <img src=""https://media.laczynaspilka.pl/images/pzphp/MWU7MDMsMzIwLDEzODg_/007460f18a858dde2805929a4307b4e3.jpg"" />
            </a>
        </div>

    </div>
    <p style=""clear:both;""></p>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Zaliczenie.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
