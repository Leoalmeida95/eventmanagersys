#pragma checksum "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "317aab6c0df0294fc7d0c99fd027f73a9c049dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos__Detalhes), @"mvc.1.0.view", @"/Views/Eventos/_Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/_Detalhes.cshtml", typeof(AspNetCore.Views_Eventos__Detalhes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"317aab6c0df0294fc7d0c99fd027f73a9c049dd5", @"/Views/Eventos/_Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed2f5fbd5c0d8f3b6e092331453a5bf55dccddf", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos__Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventos.IO.Application.ViewModels.EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IncluirEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 43, true);
            WriteLiteral("\r\n<p>\r\n    <h3>Endereço</h3>\r\n</p>\r\n<div>\r\n");
            EndContext();
#line 7 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
     if (Model.Endereco != null)
    {

#line default
#line hidden
            BeginContext(142, 124, true);
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(267, 55, false);
#line 13 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(322, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(402, 51, false);
#line 16 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(453, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(533, 56, false);
#line 19 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(589, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(669, 51, false);
#line 22 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(720, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(800, 48, false);
#line 25 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(848, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(928, 51, false);
#line 28 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(979, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1059, 51, false);
#line 31 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1190, 53, false);
#line 34 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Endereco.EventoId));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 210, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1454, 51, false);
#line 42 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1597, 47, false);
#line 45 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1736, 52, false);
#line 48 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1880, 47, false);
#line 51 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2019, 44, false);
#line 54 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2155, 47, false);
#line 57 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2202, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2294, 47, false);
#line 60 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2433, 49, false);
#line 63 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                       Write(Html.DisplayFor(model => model.Endereco.EventoId));

#line default
#line hidden
            EndContext();
            BeginContext(2482, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2573, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46b3756929348818244e7b948195d5a", async() => {
                BeginContext(2656, 127, true);
                WriteLiteral("\r\n                                <span title=\"Editar\" class=\"glyphicon glyphicon-pencil\"></span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                                                                WriteLiteral(Model.Id);

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
            BeginContext(2787, 100, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 73 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2911, 77, true);
            WriteLiteral("        <table>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2988, 241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c8b651d44c4afba508f3b546fba354", async() => {
                BeginContext(3080, 145, true);
                WriteLiteral(" \r\n                        <span title=\"Incluir Endereco\" class=\"glyphicon glyphicon-plus-sign\" ></span> Adicionar Endereço\r\n                    ");
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
#line 79 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
                                                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-modal", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3229, 62, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 85 "C:\Users\leonardo.silva\Desktop\Nova pasta\Eventos.IO\Eventos.IO\src\Eventos.IO.Site\Views\Eventos\_Detalhes.cshtml"
    }

#line default
#line hidden
            BeginContext(3298, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventos.IO.Application.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
