#pragma checksum "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83ece0befc018769363004feff3373a95d83bba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TicketSale), @"mvc.1.0.view", @"/Views/Home/TicketSale.cshtml")]
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
#line 1 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/_ViewImports.cshtml"
using SahinTurizim.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/_ViewImports.cshtml"
using SahinTurizim.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/_ViewImports.cshtml"
using SahinTurizim.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83ece0befc018769363004feff3373a95d83bba", @"/Views/Home/TicketSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70beb6cee5c89ecc5a798eca34a0f5cd3e967bce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TicketSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Expedition>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "SeatNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("required", new global::Microsoft.AspNetCore.Html.HtmlString("required"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TicketSale", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h5 class=\"mt-5\">Sefer</h5>\n<h5 class=\"mt-5 d-flex justify-content-center align-items-center\">Sefer</h5>\n<div class=\"card mb-3 shadow\">\n\n    <div class=\"card-title pl-3 pt-3\">\n        <h1>");
#nullable restore
#line 8 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
       Write(Model.StartTerminal);

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 8 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                             Write(Model.EndTerminal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    </div>\n    <div class=\"card-body\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83ece0befc018769363004feff3373a95d83bba6356", async() => {
                WriteLiteral("\n            <div class=\"row no-gutters\">\n\n                <div class=\"col-md-8\">\n                    <h4>");
#nullable restore
#line 15 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                   Write(Model.StartTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 15 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                          Write(Model.EndTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" OTOBÜSÜ</h4>\n                    <p><b>Route: </b> ");
#nullable restore
#line 16 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                 Write(Model.StartTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 16 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                                        Write(Model.FirstTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 16 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                                                               Write(Model.SecondTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 16 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                                                                                       Write(Model.ThirdTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 16 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                                                                                                              Write(Model.EndTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    <p>");
#nullable restore
#line 17 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                  Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("  -  ");
#nullable restore
#line 17 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                  Write(Model.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    <br />\n                    <p>Dolu koltuk sayısı: ");
#nullable restore
#line 19 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
                                      Write(ViewBag.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                </div>

                <div class=""row no-gutters"">

                    <div class=""col-md-12"">
                        <br /><br /><hr /><br />
                        <div class=""form-group"">
                            <input type=""text"" name=""firstName"" class=""form-control  mb-3""");
                BeginWriteAttribute("id", " id=\"", 1133, "\"", 1138, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 1139, "\"", 1158, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Name\" required>\n                        </div>\n                        <div class=\"form-group\">\n                            <input type=\"text\" name=\"lastName\" class=\"form-control  mb-3\"");
                BeginWriteAttribute("id", " id=\"", 1358, "\"", 1363, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 1364, "\"", 1383, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Surname\" required>\n                        </div>\n                        <div class=\"form-group\">\n                            <input type=\"tel\" name=\"PhoneNumber\" class=\"form-control  mb-3\"");
                BeginWriteAttribute("id", " id=\"", 1588, "\"", 1593, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 1594, "\"", 1613, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Phone\" required>\n                        </div>\n                        <div class=\"form-group\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83ece0befc018769363004feff3373a95d83bba11525", async() => {
                    WriteLiteral("\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83ece0befc018769363004feff3373a95d83bba11822", async() => {
                        WriteLiteral("Koltuk Seçiniz");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 37 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.SeatNumbers;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n                    </div>\n                <input type=\"hidden\"  name=\"startLocation\"");
                BeginWriteAttribute("value", " value=\"", 2094, "\"", 2122, 1);
#nullable restore
#line 42 "/Users/mehmetsahin/Desktop/Buss/Buss/SahinTurizim/SahinTurizim.WebUI/Views/Home/TicketSale.cshtml"
WriteAttributeValue("", 2102, Model.StartTerminal, 2102, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                    <button type=\"submit\" class=\"btn btn-danger w-25 offset-8\">Book Ticket</button>\n                    <br />\n                </div><br />\n            </div>\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div><br />\n\n</div>\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Expedition> Html { get; private set; }
    }
}
#pragma warning restore 1591
