#pragma checksum "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Adocao\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cefbff6f82fc5eca7c4232c59d108f18b18a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adocao_Cadastro), @"mvc.1.0.view", @"/Views/Adocao/Cadastro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cefbff6f82fc5eca7c4232c59d108f18b18a76", @"/Views/Adocao/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d5a89bcb9cd6b6faa829c61a6b38d9f168a4369", @"/Views/_ViewImports.cshtml")]
    public class Views_Adocao_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Adocao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formAdocao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validaAdocao()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 08 - PROJETO INTEGRADOR\NOEMI_ET06_PI\Meadote\Views\Adocao\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro de Adocao";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<div class=\"titulo\">\r\n    <h4>Adoção</h4>\r\n</div>\r\n\r\n<center>\r\n    <img src=\"/imagens/somos.jpg\" alt=\"caes e gatos\">\r\n</center>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cefbff6f82fc5eca7c4232c59d108f18b18a765093", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""lblnome"">Nome:</label>
            <input type=""text"" name=""txtnome"" id=""txtnome"">
            <span class=""msg-erro msg-nome""></span>
        </div>
        <div class=""form-group col-md-6"">
            <label for=""lblemail"">E-mail:</label>
            <input type=""text"" name=""txtemail"" id=""txtemail"">
            <span class=""msg-erro msg-email""></span>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""lbltelefone"">Telefone:</label>
            <input type=""text"" name=""txttelefone"" id=""txttelefone"">
            <span class=""msg-erro msg-telefone""></span>
        </div>
        <div class=""form-group col-md-6"">
            <label for=""lbldatanascimento"">Data de Nascimento:</label>
            <input type=""date"" name=""txtdatanascimento"" id=""txtdatanascimento"">
            <span class=""msg-erro msg-datanascimento""></span>
      ");
                WriteLiteral(@"  </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-12"">
            <label for=""lblendereco"">Endereço:</label>
            <input type=""text"" name=""txtendereco"" id=""txtendereco"" placeholder=""Apto, casa, número"">
            <span class=""msg-erro msg-endereco""></span>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""lblcidade"">Cidade:</label>
            <input type=""text"" name=""txtcidade"" id=""txtcidade"">
            <span class=""msg-erro msg-cidade""></span>
        </div>

        <div class=""form-group col-md-4"">
            <label for=""lblestado"">Estado:</label>
            <input type=""text"" name=""txtestado"" id=""txtestado"">
            <span class=""msg-erro msg-estado""></span>
        </div>
        <div class=""form-group col-md-2"">
            <label for=""lblcep"">CEP:</label>
            <input type=""text"" name=""txtcep"" id=""txtcep"">
            <span class=""msg-erro msg-cep""></sp");
                WriteLiteral(@"an>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""form-group col-md-12"">
            <label for=""lblanimal"">Animal:</label>
            <input type=""text"" name=""txtanimal"" id=""txtanimal"">
            <span class=""msg-erro msg-animal""></span>
        </div>
    </div>
    </div>

    <center><button type=""submit"" class=""btn btn-primary"">CADASTRAR</button></center>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Adocao> Html { get; private set; }
    }
}
#pragma warning restore 1591
