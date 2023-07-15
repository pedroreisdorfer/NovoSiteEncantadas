#pragma checksum "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb366cb176723de6cd7297d755c4e357aa63696d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingresso_Reserve), @"mvc.1.0.view", @"/Views/Ingresso/Reserve.cshtml")]
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
#line 2 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\_ViewImports.cshtml"
using WebEncantadas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
using WebEncantadas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
using System.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb366cb176723de6cd7297d755c4e357aa63696d", @"/Views/Ingresso/Reserve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd4f1d23cebd1149838ba995365029b072f776e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ingresso_Reserve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_Reserve.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
  
    ViewData["Title"] = "Ingresso";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
  
    var connection = ConnectionManager.GetConnection();
    connection.Open();
    var command = new SqlCommand("SELECT num_mesa, valor_cadeira FROM dbo.reserva_ingressos WHERE id = 1", connection);
    decimal valor_cadeira = 0;

    int num_mesa = 0;
    var valores_cadeira = new Dictionary<int, decimal>();
    var reader = command.ExecuteReader(); // função é chamada no objeto SqlCommand para executar a consulta SQL e retornar um objeto SqlDataReader que pode ser usado para ler as linhas do resultado da consulta.
     while (reader.Read()) //A instrução if verifica se há alguma linha no resultado da consulta usando o método Read() do objeto SqlDataReader. Se houver pelo menos uma linha, o valor da coluna "valor_cadeira" é lido na variável "valor_cadeira" usando o método GetDecimal() do objeto SqlDataReader.
    {
        num_mesa = reader.GetInt32(0);
        valor_cadeira = reader.GetDecimal(1);; // valor da cadeira
        // use a variável valor para exibir o valor na sua página HTML
        valores_cadeira[num_mesa] = valor_cadeira;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb366cb176723de6cd7297d755c4e357aa63696d5902", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb366cb176723de6cd7297d755c4e357aa63696d6168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n <script src=\"https://code.jquery.com/jquery-3.6.3.min.js\"></script>\r\n\r\n<h1>Reserva de ingressos</h1>\r\n\r\n<div class=\"salaoMesas\">\r\n\r\n    <div class=\"divisao_1\" >\r\n        <div id=\"mesa_circular\">\r\n");
#nullable restore
#line 44 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
             for (int i = 1; i <= 8; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("               <button");
            BeginWriteAttribute("id", " id=\"", 1576, "\"", 1591, 2);
            WriteAttributeValue("", 1581, "cadeira-", 1581, 8, true);
#nullable restore
#line 45 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 1589, i, 1589, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1592, "\"", 1618, 3);
            WriteAttributeValue("", 1600, "assento-", 1600, 8, true);
#nullable restore
#line 45 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 1608, i, 1608, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1610, "cadeira", 1611, 8, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"cadeiraSelecionada(this)\" data-num-mesa=\"1\">");
#nullable restore
#line 45 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 46 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div id=\"mesa_circular2\">\r\n");
#nullable restore
#line 50 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
         for (int i = 1; i <= 8; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button");
            BeginWriteAttribute("id", " id=\"", 1813, "\"", 1828, 2);
            WriteAttributeValue("", 1818, "cadeira-", 1818, 8, true);
#nullable restore
#line 51 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 1826, i, 1826, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1829, "\"", 1855, 3);
            WriteAttributeValue("", 1837, "assento-", 1837, 8, true);
#nullable restore
#line 51 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 1845, i, 1845, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1847, "cadeira", 1848, 8, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"cadeiraSelecionada(this)\" data-num-mesa=\"2\">");
#nullable restore
#line 51 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 52 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n      \r\n    <div class=\"divisao_2\">\r\n             <div id=\"mesa_circular3\">\r\n");
#nullable restore
#line 58 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
             for (int i = 1; i <= 8; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("id", " id=\"", 2110, "\"", 2125, 2);
            WriteAttributeValue("", 2115, "cadeira-", 2115, 8, true);
#nullable restore
#line 59 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 2123, i, 2123, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2126, "\"", 2152, 3);
            WriteAttributeValue("", 2134, "assento-", 2134, 8, true);
#nullable restore
#line 59 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 2142, i, 2142, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2144, "cadeira", 2145, 8, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"cadeiraSelecionada(this)\" data-num-mesa=\"3\">");
#nullable restore
#line 59 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 60 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n           <div id=\"mesa_circular4\">\r\n");
#nullable restore
#line 64 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
             for (int i = 1; i <= 8; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("id", " id=\"", 2362, "\"", 2377, 2);
            WriteAttributeValue("", 2367, "cadeira-", 2367, 8, true);
#nullable restore
#line 65 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 2375, i, 2375, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2378, "\"", 2404, 3);
            WriteAttributeValue("", 2386, "assento-", 2386, 8, true);
#nullable restore
#line 65 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 2394, i, 2394, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2396, "cadeira", 2397, 8, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"cadeiraSelecionada(this)\" data-num-mesa=\"4\">");
#nullable restore
#line 65 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 66 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <div>\r\n            Valor total:\r\n             <span id=\"totalCompra\"></span>\r\n\r\n             \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<p>O valor da mesa é ");
#nullable restore
#line 80 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
                Write(valor_cadeira);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".</p>


<script>
   

   function cadeiraSelecionada(botao) {      
        botao.classList.toggle(""selecionada""); // faz com que adicione class ""selecionada"" caso a mesma não exista. Caso clicar no botão de novo e a class ""selecionada"" existir, eu removo ela.
         atualizarValorTotal();
   }
   
   function atualizarValorTotal() {
        var numero_deCadeiras = $('.cadeira.selecionada').length; // obtém o número de cadeiras selecionadas
        $.ajax({
            url: '");
#nullable restore
#line 94 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
             Write(Url.Action("CalcularValorTotal", "Pagamento"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { numero_deCadeiras: numero_deCadeiras },
            success: function (data) {
                $('#totalCompra').html('R$ ' + data); // atualiza o valor total na tela
            }
        });
    }

    $(function () {
        atualizarValorTotal(); // atualiza o valor total na página carregada
    });

</script>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
