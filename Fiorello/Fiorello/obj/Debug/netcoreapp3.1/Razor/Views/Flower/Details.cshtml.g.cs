#pragma checksum "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7489d0e9c3b6a3922fa3ab918999579349d9c2c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flower_Details), @"mvc.1.0.view", @"/Views/Flower/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7489d0e9c3b6a3922fa3ab918999579349d9c2c5", @"/Views/Flower/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1654895ee42ab82a0127eddb0c3e0ffa61bd6332", @"/Views/_ViewImports.cshtml")]
    public class Views_Flower_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/shop.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
  
    ViewData["Title"] = "Details";
    HomeVM homeVM = ViewBag.Product;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <section id=""Productlist"">
        <div class=""container"">
            <div class=""text"">
                <div class=""text-top"">
                    <h1>Product List</h1>
                </div>
                <div class=""text-bottom"">
                    <p>Where flowers are our inspiration</p>
                </div>
            </div>
        </div>
    </section>

    <section id=""adcart"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col col-lg-6"">
                    <div class=""imgs"">
                        <div class=""small-imgs "">
                            <div class=""img"">
                                <img width=""45%"" src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-2-gallery-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 907, "\"", 913, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"img\">\r\n                                <img width=\"45%\" src=\"https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-2-gallery-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1139, "\"", 1145, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"img\">\r\n                                <img width=\"45%\" src=\"https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-2-gallery-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1371, "\"", 1377, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"img\">\r\n                                <img width=\"45%\" src=\"https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-2-gallery-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1603, "\"", 1609, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"largimage\">\r\n                            <img src=\"https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-2-img.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1849, "\"", 1855, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>

                <div class=""sale col-lg-6"">
                    <div class=""text-input"">
                        <div class=""text"">
                            <div class=""name"">
                                <h2>");
#nullable restore
#line 54 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                            <div class=\"cost\">\r\n");
#nullable restore
#line 57 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                 if (Model.DiscauntId == null)
                                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p><small>");
#nullable restore
#line 61 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                         Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</small></p>\r\n");
#nullable restore
#line 62 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p><small style=\"text-decoration:line-through\">239$</small></p>\r\n                                    <p><small>");
#nullable restore
#line 66 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                          Write(Model.Price*(100-Model.Discaunt.Precenet)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n");
#nullable restore
#line 67 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"info\">\r\n                                ");
#nullable restore
#line 70 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""input"">

                                <input type=""number"">
                                <div class=""butn"">
                                    <button>ADD TO CARD</button>
                                </div>

                            </div>

                            <div class=""product-info"">
                                <ul>
                                    <li>SKU :<a");
            BeginWriteAttribute("href", " href=\"", 3411, "\"", 3418, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                                   Write(Model.Skucode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li>\r\n                                        Categories : <a");
            BeginWriteAttribute("href", " href=\"", 3542, "\"", 3549, 0);
            EndWriteAttribute();
            WriteLiteral("><small>\r\n");
#nullable restore
#line 86 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                                foreach (var item in Model.ProductCategorys)
                                               {
                                                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                              Write(item.Category.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                                                      
                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                              </small></a>\r\n                                    </li>\r\n                                    <li>\r\n                                        Tags : <a");
            BeginWriteAttribute("href", " href=\"", 4022, "\"", 4029, 0);
            EndWriteAttribute();
            WriteLiteral("><small>Llilies,</small></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4102, "\"", 4109, 0);
            EndWriteAttribute();
            WriteLiteral(@"><small>Orchids</small></a>
                                    </li>
                                </ul>
                            </div>

                        </div>


                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""info-flower"">
        <div class=""butns-cards"">
            <div class=""butns row"">
                <div class=""butn col-lg-4"" data-id=""description"">DESCRIPTION</div>
                <div class=""butn  col-lg-4"" data-id=""aditional"">ADITIONAL-INFORMATION</div>
                <div class=""butn  col-lg-4"" data-id=""rewiews"">REWIEWS</div>
            </div>
            <div class=""cards"">
                <div style=""padding: 2rem;"" class=""cart"" id=""description"">
                    <div class=""text"">
                        <div class=""text-top"">
                            <h3>The power of flowers</h3>
                        </div>
                        <div class=""text-bottom"">

              ");
            WriteLiteral(@"              Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante

                        </div>
                    </div>
                </div>
                <div style=""padding: 2rem;"" class=""cart "" id=""aditional"">
                    <div class=""text"">
                        <div class=""text-top"">
                            <p>weight: <span> 1kg</span></p>
                        </div>
                        <div class=""text-bottom"">
                            <p>Dimensions: <span> 30 x 30 x 50 cm</span></p>
                        </div>
                    </div>
                </div>");
            WriteLiteral(@"

                <div class=""cart "" id=""rewiews"">
                    <div class=""container"">
                        <div class=""head"">
                            <h3>Rewiews</h3>
                        </div>
                        <div class=""user row"">
                            <div class=""col col-lg-2 user-img"">
                                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/user-img-1-100x100.png""");
            BeginWriteAttribute("alt", " alt=\"", 6620, "\"", 6626, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class="" col col-lg-10"">
                                <div class=""user-name"">
                                    <p>JOSHUA GARCIA</p>
                                </div>
                                <div class=""user-descript"">
                                    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis Theme natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                </div>
                            </div>
                        </div>
                        <div class=""user row"">
                            <div class="" col col-lg-2 user-img"">
                                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/user-img-2-100x100.png""");
            BeginWriteAttribute("alt", " alt=\"", 7533, "\"", 7539, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                            </div>
                            <div class=""col col-lg-10 user-descript"">
                                <div class=""user-name"">
                                    <p>JOAN STANLEY </p>
                                </div>
                                <div class=""user-descript"">
                                    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis Theme natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                                </div>
                            </div>
                        </div>
                        <div class=""form"">
                            <div class=""info"">
                                <h2>Add a review</h2>
                                <P>
                                    Your email address will not be published. Required fields are marked *

                                    <br>  Your revie");
            WriteLiteral("w*\r\n                                </P>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7489d0e9c3b6a3922fa3ab918999579349d9c2c517437", async() => {
                WriteLiteral(@"
                                <input style=""height: 10rem;"" class=""form-control"" type=""textarea"">
                                <label for=""name"">Name*</label>
                                <input class=""form-control"" type=""text"" id=""name"">

                                <label for=""email"">Email*</label>
                                <input class=""form-control"" type=""email"" id=""email"">
                                <input style=""margin-left: -34rem; margin-top: 1rem;"" type=""checkbox"">
                                <div class=""chekbox-text"">
                                    <p>
                                        Save my name, email, and website in this browser for the next time I comment.
                                    </p>

                                </div>
                                <div class=""mybtn"">
                                    <button value=""submit"">SUBMIT</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"




                        </div>
                    </div>
                </div>



            </div>
        </div>
    </section>

    <section id=""cards"">
        <div class=""card-filter"">
            <div class=""cards row"">

               ");
#nullable restore
#line 217 "C:\Users\HP\Desktop\Fiorello\Fiorello_asp\Fiorello\Fiorello\Views\Flower\Details.cshtml"
          Write(await Html.PartialAsync("_DisplayProductPartial",homeVM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <div class=\"content\">\r\n        <div class=\"icon \">\r\n            <i class=\"fas fa-chevron-up\"></i>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7489d0e9c3b6a3922fa3ab918999579349d9c2c520666", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
