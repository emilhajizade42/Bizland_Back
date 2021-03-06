#pragma checksum "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe3f2db4f4c0ebd29294cb2cdfef6d8e32085cf"
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
#line 1 "C:\Users\acer\Desktop\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe3f2db4f4c0ebd29294cb2cdfef6d8e32085cf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de792b11def03855ac65d83b380655e90475260", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <!-- MAIN START -->
    <main>
        <!-- Welcome Section START -->
        <section class=""welcome_to_bizland"">
            <div class=""welcome_box my_container"">
                <h1>Welcome to <span>BizLand</span></h1>
                <p>We are team of talented designers making websites with Bootstrap</p>
                <div class=""welcome_box_btns"">
                    <div class=""welcome_box_btns_get""><a href=""#"">GET STARTED</a></div>
                    <div class=""welcome_box_btns_watch""><a href=""#"">Watch Video</a></div>
                </div>
            </div>
        </section>
        <!-- Welcome Section END -->
        <!-- AboutUs Section START -->
        <section class=""about_us"">
            <div class=""about_us_box my_container"">
                <div class=""about_us_mini_header"">ABOUT</div>
                <h3 class=""about_us_header"">Find Out More <span>About Us</span></h3>
                <div class=""about_us_header_content"">Ut possimus qui ut temporibus culpa velit ev");
            WriteLiteral("eniet modi omnis est adipisci expedita at voluptas atque vitae autem.</div>\r\n                <div class=\"about_us_img_box\">\r\n                    <img src=\"https://bootstrapmade.com/demo/templates/BizLand/assets/img/about.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1297, "\"", 1303, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""about_us_mini_box"">
                        <h3 class=""about_us_mini_box_header"">Voluptatem dignissimos provident quasi corporis voluptates sit assumenda.</h3>
                        <p class=""about_us_mini_box_top_content"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                        <div class=""about_us_mini_box_card"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 1789, "\"", 1795, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1796, "\"", 1802, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div>
                                <h4>Ullamco laboris nisi ut aliquip consequat</h4>
                                <p>Magni facilis facilis repellendus cum excepturi quaerat praesentium libre trade</p>
                            </div>
                        </div>
                        <div class=""about_us_mini_box_card"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 2207, "\"", 2213, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2214, "\"", 2220, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div>
                                <h4>Magnam soluta odio exercitationem reprehenderi</h4>
                                <p>Quo totam dolorum at pariatur aut distinctio dolorum laudantium illo direna pasata redi</p>
                            </div>
                        </div>
                        <p class=""about_us_mini_box_bottom_content"">Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum</p>
                    </div>
                </div>
            </div>
        </section>
         <!-- AboutUs Section END -->
         <!-- Our Hardworking Team Section START -->
        <section class=""team"">
           <div class=""team_box my_container"">
                <div class=""team_box_mini_header"">");
#nullable restore
#line 51 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
                                             Write(Model.Settings.OurTeamMiniHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <h3 class=\"team_box_header\">Our Hardworking <span>Team</span></h3>\r\n                <div class=\"team_box_content\">");
#nullable restore
#line 53 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
                                         Write(Model.Settings.OurTeamContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"team_box_card_box\">\r\n");
#nullable restore
#line 55 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
                     foreach (var card in Model.ourTeamCards)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <div class=\"team_box_card\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3630, "\"", 3645, 1);
#nullable restore
#line 58 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3636, card.Url, 3636, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"foto\">\r\n                            <h4 class=\"team_box_card_name\">");
#nullable restore
#line 59 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
                                                      Write(card.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p class=\"team_box_card_title\">");
#nullable restore
#line 60 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
                                                      Write(card.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\n");
#nullable restore
#line 62 "C:\Users\acer\Desktop\Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n           </div>\r\n        </section>\r\n         <!-- Our Hardworking Team Section END -->\r\n    </main>\r\n    <!-- MAIN END -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
