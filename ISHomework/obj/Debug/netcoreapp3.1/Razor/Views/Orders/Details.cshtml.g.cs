#pragma checksum "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52daa855527771aead98aac23fe6ed3ad3f6273e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\_ViewImports.cshtml"
using ISHomework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\_ViewImports.cshtml"
using ISDomain.DomainModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52daa855527771aead98aac23fe6ed3ad3f6273e", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ee7219bab58dd679edce926f1490fb0a89bfd6f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISDomain.DomainModels.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container\">\n    <h2>Tickets in order with id ");
#nullable restore
#line 4 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <div>\n        <a class=\"btn btn-success\">Order for ");
#nullable restore
#line 6 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                                        Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n    </div>\n");
#nullable restore
#line 8 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
     for (int i = 0; i < Model.TicketsInOrder.Count(); i++)
    {
        var item = Model.TicketsInOrder.ElementAt(i).Ticket;

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 15 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 m-4\">\n            <div class=\"card\" style=\"width: 18rem; height: 30rem;\">\n                 <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 546, "\"", 568, 1);
#nullable restore
#line 19 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
WriteAttributeValue("", 552, item.MovieImage, 552, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 50%\" alt=\"Movie Image!\" />\n                 <div class=\"card-body\">\n                    <h3 class=\"card-title\">");
#nullable restore
#line 21 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                                      Write(item.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                                                      Write(item.MovieYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                                    Write(item.MovieGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text\">Start Date: ");
#nullable restore
#line 23 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                                                Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text\">End Date: ");
#nullable restore
#line 24 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                                              Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <h5>Ticket Price: ");
#nullable restore
#line 25 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
                                 Write(item.TicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                 </div>\n            </div>\n        </div>\n");
#nullable restore
#line 29 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
        if (i % 3 == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          ");
            WriteLiteral("</div>\n");
#nullable restore
#line 32 "C:\Users\PC\Desktop\201005-ISHomework\ISHomework\ISHomework\Views\Orders\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISDomain.DomainModels.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
