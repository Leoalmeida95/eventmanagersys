#pragma checksum "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "966e5d17a650ddb4b42cba826ad16d21d66b3650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Index), @"mvc.1.0.view", @"/Views/Eventos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Index.cshtml", typeof(AspNetCore.Views_Eventos_Index))]
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
#line 1 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Site;

#line default
#line hidden
#line 2 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\_ViewImports.cshtml"
using Eventos.IO.Site.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"966e5d17a650ddb4b42cba826ad16d21d66b3650", @"/Views/Eventos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed2f5fbd5c0d8f3b6e092331453a5bf55dccddf", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
  
    ViewData["Title"] = "Lista dos próximos eventos";

#line default
#line hidden
            BeginContext(135, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(142, 17, false);
#line 7 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(159, 102, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"pull-left\">\r\n            ");
            EndContext();
            BeginContext(261, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3814daf22561451eb0aaaafb5402620d", async() => {
                BeginContext(308, 105, true);
                WriteLiteral("\r\n            Novo <span class=\"glyphicon glyphicon-plus-sign\" title=\"Novo Evento\" ></span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 130, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(548, 40, false);
#line 23 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(588, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(644, 46, false);
#line 26 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(690, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(746, 43, false);
#line 29 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(789, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(845, 41, false);
#line 32 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(886, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(942, 42, false);
#line 35 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(984, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1102, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1151, 39, false);
#line 44 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1246, 35, false);
#line 47 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(item.DataInicio.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1281, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1337, 32, false);
#line 50 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
           Write(item.DataFim.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1369, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 53 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                   
                    if (item.Gratuito)
                    {
                        

#line default
#line hidden
            BeginContext(1517, 28, false);
#line 56 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                   Write(Html.DisplayName("Gratuito"));

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                                     
                    }
                    else
                    {
                    

#line default
#line hidden
            BeginContext(1640, 40, false);
#line 60 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
#line 60 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                                             
                    }
                

#line default
#line hidden
            BeginContext(1724, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 65 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                  
                    if (item.Online)
                    {
                        

#line default
#line hidden
            BeginContext(1867, 23, false);
#line 68 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                   Write(Html.DisplayName("Sim"));

#line default
#line hidden
            EndContext();
#line 68 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                                
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1989, 23, false);
#line 72 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                   Write(Html.DisplayName("Não"));

#line default
#line hidden
            EndContext();
#line 72 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                                
                    }
                

#line default
#line hidden
            BeginContext(2056, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2109, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2050bc61ace43e0ad649b41099fcdbc", async() => {
                BeginContext(2178, 89, true);
                WriteLiteral("\r\n                    <span class=\"glyphicon glyphicon-pencil\" ></span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2271, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2289, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92e48e1137864da58633f729524f24ed", async() => {
                BeginContext(2361, 88, true);
                WriteLiteral("\r\n                    <span class=\"glyphicon glyphicon-search\"></span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2453, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2471, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e52d9f344b08482f9c3ddd48f0470ea2", async() => {
                BeginContext(2541, 87, true);
                WriteLiteral("\r\n                    <span class=\"glyphicon glyphicon-trash\"></span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2632, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 88 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2671, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eventos.IO.Application.ViewModels.EventoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
