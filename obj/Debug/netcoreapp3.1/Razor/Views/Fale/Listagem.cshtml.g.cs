#pragma checksum "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf97278f9486307e49d09c10413e5944dd761e97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fale_Listagem), @"mvc.1.0.view", @"/Views/Fale/Listagem.cshtml")]
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
#line 1 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\_ViewImports.cshtml"
using Meadote;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\_ViewImports.cshtml"
using Meadote.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf97278f9486307e49d09c10413e5944dd761e97", @"/Views/Fale/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d5a89bcb9cd6b6faa829c61a6b38d9f168a4369", @"/Views/_ViewImports.cshtml")]
    public class Views_Fale_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Nome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem do Fale Conosco";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<div class=\"titulo\">\r\n    <h4>Lista de Fale Conosco</h4>\r\n</div>\r\n\r\n<center>\r\n    <img src=\"/imagens/somos.jpg\" alt=\"caes e gatos\">\r\n</center>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf97278f9486307e49d09c10413e5944dd761e974920", async() => {
                WriteLiteral("\r\n            <div class=\"form-group mb-2\">\r\n                <select name=\"TipoFiltro\" class=\"form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf97278f9486307e49d09c10413e5944dd761e975316", async() => {
                    WriteLiteral("Nome");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group mb-2 mx-sm-3"">
                <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
            </div>
            <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 33 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <td>Id</td>
                        <td>Nome</td>
                        <td>E-mail</td>
                        <td>Mensagem</td>
                        <td>Operações</td>
                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 47 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
                     foreach (Fale f in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
                           Write(f.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
                           Write(f.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
                           Write(f.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
                           Write(f.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a class=\"font-weight-bold link-primary\" href=\"/Fale/Editar?Id=>f.Id\">Alterar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 59 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Nenhum registro encontrado.</p>\r\n");
#nullable restore
#line 63 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Fale\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
