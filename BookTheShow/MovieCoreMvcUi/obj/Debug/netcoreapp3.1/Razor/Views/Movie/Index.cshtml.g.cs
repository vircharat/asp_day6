#pragma checksum "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276dd8708c9d3195b8842ce9d5dad3f45e7b012a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\_ViewImports.cshtml"
using MovieCoreMvcUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\_ViewImports.cshtml"
using MovieCoreMvcUi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276dd8708c9d3195b8842ce9d5dad3f45e7b012a", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9def9690811f1087cf1eee2c6eccfd640595307", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookTheShowEntity.Moviev>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingEntry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\" row\">\r\n");
#nullable restore
#line 4 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
 foreach (var movie in Model)
{
    string imageBase64Data = Convert.ToBase64String(movie.ImgPoster);
    string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4"">

            <div class=""col-md-4"">
                <div class=""card"" style=""width: 18rem;"">
                    <div class=""bg-image hover-overlay ripple shadow-1-strong rounded""
                     data-mdb-ripple-color=""light"">
                        <img height=""150""");
            BeginWriteAttribute("src", "  src=\"", 576, "\"", 596, 1);
#nullable restore
#line 15 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
WriteAttributeValue("", 583, imageDataURL, 583, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                                              Write(movie.MovievName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 18 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                                            Write(movie.MovievDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "276dd8708c9d3195b8842ce9d5dad3f45e7b012a6212", async() => {
                WriteLiteral("Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"mask\" style=\"background-color: rgba(251, 251, 251, 0.2)\"></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n         </div>\r\n");
#nullable restore
#line 26 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<div class=""row"">
    <div class=""col-12"">
        <h3>Movies</h3>
        <hr/>
        <table class=""table table-light table-bordered table-hover"">
        <thead>
            <tr>
                <th>MovieId</th>
                <th>MovieName</th>-
                <th>MovieDescription</th>
                <th>MovieType</th>
                <th>Movie Ticket Price</th>
                <th>Movie Poster</th>
            
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 49 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
             foreach (var movie in Model) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
              
            {
                    string imageBase64Data = Convert.ToBase64String(movie.ImgPoster);
                    string imageDataURL = string.Format("data:image/jpg;base64,{0}",imageBase64Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 56 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                   Write(movie.MovievId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                   Write(movie.MovievName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                   Write(movie.MovievDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                   Write(movie.MovievType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                   Write(movie.MovieTicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img height=\"50\" width=\"50\"");
            BeginWriteAttribute("src", " src=\"", 2593, "\"", 2612, 1);
#nullable restore
#line 61 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
WriteAttributeValue("", 2599, imageDataURL, 2599, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                \r\n          \r\n                </tr>\r\n");
#nullable restore
#line 65 "C:\c_sharp\BookTheShow\MovieCoreMvcUi\Views\Movie\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookTheShowEntity.Moviev>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
