#pragma checksum "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec8b900983fee36fa8dd5652f35a07602a33535d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
using Fiorello.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
using Fiorello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8b900983fee36fa8dd5652f35a07602a33535d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a49e2990ac978cbe560247a225e6ab963941dad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/_DisplayProductPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n\r\n    <section id=\"img-animation\">\r\n        <div class=\"img-text\">\r\n");
#nullable restore
#line 12 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
             foreach (var item in Model.sliders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"slideText\" class=\"text\">\r\n                    <div class=\"text-top\">\r\n                        <h2>Send <span style=\"color: red;\">flowers</span> like <br>");
#nullable restore
#line 16 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"text-center\">\r\n                        <p>");
#nullable restore
#line 19 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 669, "\"", 704, 2);
            WriteAttributeValue("", 675, "assets/img/", 675, 11, true);
#nullable restore
#line 23 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 686, item.SignatureImg, 686, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 705, "\"", 711, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

    </section>

    <section id=""cards"">
        <div class=""card-filter"">
            <div class=""filter-list"">
                <div id=""filterresponsive"">
                    <p>Category</p>
                    <ul id=""categoryresp"">
                        <li><a href=""#"">All</a></li>
                        <li><a href=""#"">popular</a></li>
                        <li><a href=""#"">winter</a></li>
                        <li><a href=""#"">various</a></li>
                        <li><a href=""#"">exotic</a></li>
                        <li><a href=""#"">greens</a></li>
                        <li><a href=""#"">cactuses</a></li>
                    </ul>
                </div>
                <div class=""filters"">
                    <ul id=""category"">
                        <li class=""categoryF"" id=""1""><a");
            BeginWriteAttribute("href", " href=\"", 1629, "\"", 1636, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n");
#nullable restore
#line 49 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                         foreach (var category in Model.categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"categoryF\"");
            BeginWriteAttribute("id", " id=\"", 1797, "\"", 1826, 1);
#nullable restore
#line 51 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 1802, category.Name.ToLower(), 1802, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 1830, "\"", 1837, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                                                      Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 52 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>

                </div>
                <div class=""filter"">
                    <div class=""text-filter"">
                        <p>FILTER</p>
                    </div>
                    <div class=""Filters"">
                        <div class=""info-price"">
                            <div class=""info"">
                                <h4>Sort By </h4>
                                <ul>
                                    <li>Default</li>
                                    <li>Popularity</li>
                                    <li>Newness</li>
                                    <li>Price: Low To High</li>
                                    <li>Price: High To Low</li>
                                </ul>
                            </div>
                            <div class=""price"">
                                <ul>
                                    <li>Price Range</li>
                                    <li>All</li>
                        ");
            WriteLiteral(@"            <li>$0-$10</li>
                                    <li>$10-$20</li>
                                    <li>$20-$30</li>
                                    <li>$30-$40</li>
                                    <li>40$+</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

            <div class=""cards row"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec8b900983fee36fa8dd5652f35a07602a33535d10319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n\r\n        <section id=\"flower\">\r\n\r\n            <div class=\"container\">\r\n                <div class=\"text\">\r\n                    <div class=\"text-top\">\r\n                        <h2>");
#nullable restore
#line 102 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                       Write(Model.settings.FlowerExTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"text-bottom\">\r\n                        <p>");
#nullable restore
#line 105 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                      Write(Model.settings.FlowerExDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"imgs \">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 111 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                         foreach (var expertPosition in Model.expertsp)
                        {


                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                             foreach (var experts in expertPosition.Expertts)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"img-text col col-lg-3\">\r\n                                    <div class=\"img\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4379, "\"", 4397, 1);
#nullable restore
#line 120 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 4385, experts.Img, 4385, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4398, "\"", 4404, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"text\">\r\n                                        <h6>");
#nullable restore
#line 123 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                       Write(experts.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p>");
#nullable restore
#line 124 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                      Write(expertPosition.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 127 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n        </section>\r\n\r\n\r\n        <section id=\"mypar\">\r\n            <div class=\"parallax-window\" data-parallax=\"scroll\" data-image-src=\"./assets/img/");
#nullable restore
#line 141 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                                                        Write(Model.settings.Parallaximg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n                <div class=\"parallax\">\r\n                    <div class=\"text-input\">\r\n                        <div class=\"text\">\r\n                            <h3>");
#nullable restore
#line 146 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                           Write(Model.settings);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ParallaxTitle</h3>
                        </div>
                        <div class=""myinput-btn"">
                            <input type=""text"" placeholder=""email"">
                            <div class=""mybtn"">
                                <button>Subscribe</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>


        <section id=""blog"">
            <div class=""container"">
                <div class=""texts"">
                    <div class=""text-top"">
                        <h4>");
#nullable restore
#line 164 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                       Write(Model.settings.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"text-bottom\">\r\n                        <p>");
#nullable restore
#line 167 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                      Write(Model.settings.BlogDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"cards row\">\r\n");
#nullable restore
#line 171 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                     foreach (var blog in Model.blogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"mycard  col-lg-4\">\r\n                            <div class=\"img\">\r\n                                <img width=\"358\"");
            BeginWriteAttribute("src", " src=\"", 6334, "\"", 6349, 1);
#nullable restore
#line 175 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 6340, blog.Img, 6340, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6350, "\"", 6356, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text\">\r\n                                <div class=\"name\">\r\n                                    <h6>");
#nullable restore
#line 179 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                   Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <div class=\"desc\">\r\n                                    <p>");
#nullable restore
#line 182 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                  Write(blog.Decsrtipt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 186 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n        <section id=\"slidebar\">\r\n            <div class=\"owl-carousel owl-theme\">\r\n\r\n");
#nullable restore
#line 196 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                 foreach (var carusel in Model.carusels)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\r\n\r\n                        <div class=\"slide\">\r\n                            <div class=\"slide-bar\">\r\n                                <div class=\"img\">\r\n                                    <img style=\"width: 20%;\"");
            BeginWriteAttribute("src", " src=\"", 7320, "\"", 7338, 1);
#nullable restore
#line 203 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 7326, carusel.Img, 7326, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7339, "\"", 7345, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""info-name"">
                                    <div class=""info"">
                                        <p style=""font-size: 1rem;"">
                                            ");
#nullable restore
#line 208 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                       Write(carusel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                    <div class=\"name\">\r\n                                        ");
#nullable restore
#line 212 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                   Write(carusel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> <span>");
#nullable restore
#line 212 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                            Write(carusel.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 218 "C:\Users\HP\Desktop\asp-netCore\task-getdatafrom database\fiorellotask\Fiorello\Fiorello\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </section>\r\n\r\n\r\n\r\n    <div class=\"content\">\r\n        <div class=\"icon \">\r\n            <i class=\"fas fa-chevron-up\"></i>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
