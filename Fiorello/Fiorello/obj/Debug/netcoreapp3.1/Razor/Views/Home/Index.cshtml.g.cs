#pragma checksum "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e886d1d2429830c00d6a67c6aea854af7a4715a2"
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
#line 1 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e886d1d2429830c00d6a67c6aea854af7a4715a2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1654895ee42ab82a0127eddb0c3e0ffa61bd6332", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
      
        ViewData["Title"] = "Index";
        
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <main>

        <section id=""img-animation"">
            <div class=""img-text"">
               
                    <div id=""slideText"" class=""text"">
                        <div class=""text-top"">
                            <h2>Send <span style=""color: red;"">flowers</span> like <br>");
#nullable restore
#line 17 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                                                  Write(Model.sliders.FirstOrDefault().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n                        <div class=\"text-center\">\r\n                            <p>");
#nullable restore
#line 20 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                          Write(Model.sliders.FirstOrDefault().Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                        <div class=\"img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 697, "\"", 758, 2);
            WriteAttributeValue("", 703, "assets/img/", 703, 11, true);
#nullable restore
#line 24 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 714, Model.sliders.FirstOrDefault().SignatureImg, 714, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 759, "\"", 765, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                
            </div>

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
            BeginWriteAttribute("href", " href=\"", 1774, "\"", 1781, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n");
#nullable restore
#line 50 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                             foreach (var category in Model.categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"categoryF\"");
            BeginWriteAttribute("id", " id=\"", 1954, "\"", 1983, 1);
#nullable restore
#line 52 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 1959, category.Name.ToLower(), 1959, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 1987, "\"", 1994, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                                                          Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 53 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>

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
                                        <li>Price Ra");
            WriteLiteral(@"nge</li>
                                        <li>All</li>
                                        <li>$0-$10</li>
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
#nullable restore
#line 92 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("_DisplayProductPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    
                </div>
            </div>
        </section>



        <section id=""flower"">

            <div class=""container"">
                <div class=""text"">
                    <div class=""text-top"">
                        <h2>");
#nullable restore
#line 105 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                       Write(Model.settings.FlowerExTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"text-bottom\">\r\n                        <p>");
#nullable restore
#line 108 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                      Write(Model.settings.FlowerExDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"imgs \">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 114 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                         foreach (var expertPosition in Model.expertsp)
                        {


                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                             foreach (var experts in expertPosition.Expertts)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"img-text col col-lg-3\">\r\n                                    <div class=\"img\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4723, "\"", 4741, 1);
#nullable restore
#line 123 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 4729, experts.Img, 4729, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4742, "\"", 4748, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"text\">\r\n                                        <h6>");
#nullable restore
#line 126 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                       Write(experts.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p>");
#nullable restore
#line 127 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                      Write(expertPosition.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 130 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n        </section>\r\n\r\n\r\n        <section id=\"mypar\">\r\n            <div class=\"parallax-window\" data-parallax=\"scroll\" data-image-src=\"./assets/img/");
#nullable restore
#line 144 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                                                        Write(Model.settings.Parallaximg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n                <div class=\"parallax\">\r\n                    <div class=\"text-input\">\r\n                        <div class=\"text\">\r\n                            <h3>");
#nullable restore
#line 149 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
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
#line 167 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                       Write(Model.settings.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"text-bottom\">\r\n                        <p>");
#nullable restore
#line 170 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                      Write(Model.settings.BlogDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"cards row\">\r\n");
#nullable restore
#line 174 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                     foreach (var blog in Model.blogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"mycard  col-lg-4\">\r\n                            <div class=\"img\">\r\n                                <img width=\"358\"");
            BeginWriteAttribute("src", " src=\"", 6678, "\"", 6693, 1);
#nullable restore
#line 178 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 6684, blog.Img, 6684, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6694, "\"", 6700, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text\">\r\n                                <div class=\"name\">\r\n                                    <h6>");
#nullable restore
#line 182 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                   Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <div class=\"desc\">\r\n                                    <p>");
#nullable restore
#line 185 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                  Write(blog.Decsrtipt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 189 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n        <section id=\"slidebar\">\r\n            <div class=\"owl-carousel owl-theme\">\r\n\r\n");
#nullable restore
#line 199 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                 foreach (var carusel in Model.carusels)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\r\n\r\n                        <div class=\"slide\">\r\n                            <div class=\"slide-bar\">\r\n                                <div class=\"img\">\r\n                                    <img style=\"width: 20%;\"");
            BeginWriteAttribute("src", " src=\"", 7664, "\"", 7682, 1);
#nullable restore
#line 206 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 7670, carusel.Img, 7670, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7683, "\"", 7689, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""info-name"">
                                    <div class=""info"">
                                        <p style=""font-size: 1rem;"">
                                            ");
#nullable restore
#line 211 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                       Write(carusel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                    <div class=\"name\">\r\n                                        ");
#nullable restore
#line 215 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                   Write(carusel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> <span>");
#nullable restore
#line 215 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                                                            Write(carusel.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 221 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </section>\r\n\r\n\r\n\r\n        <div class=\"content\">\r\n            <div class=\"icon \">\r\n                <i class=\"fas fa-chevron-up\"></i>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </main>\r\n\r\n");
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
