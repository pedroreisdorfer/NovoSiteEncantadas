#pragma checksum "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47bd60f3d0b319ef6d147889b31ad3bba3bd301"
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
#line 1 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\_ViewImports.cshtml"
using WebEncantadas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\_ViewImports.cshtml"
using WebEncantadas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47bd60f3d0b319ef6d147889b31ad3bba3bd301", @"/Views/Ingresso/Reserve.cshtml")]
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
  
    ViewData["Title"] = "Ingresso";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47bd60f3d0b319ef6d147889b31ad3bba3bd3014231", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d47bd60f3d0b319ef6d147889b31ad3bba3bd3014497", async() => {
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
            WriteLiteral(@"

<style>
   .salaoMesas{
       background-color: #f1e7c5;
       border: 2px solid #80bca3;
       width: 30rem;
       height: 25rem;
   }
</style>

 <script src=""https://code.jquery.com/jquery-3.6.3.min.js""></script>

<h1>Reserva de ingressos</h1>

<div class=""salaoMesas"">


    <div id=""mesa_circular"">
");
#nullable restore
#line 27 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
         for (int i = 1; i <= 8; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button");
            BeginWriteAttribute("id", " id=\"", 520, "\"", 535, 2);
            WriteAttributeValue("", 525, "cadeira-", 525, 8, true);
#nullable restore
#line 28 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 533, i, 533, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 536, "\"", 562, 3);
            WriteAttributeValue("", 544, "assento-", 544, 8, true);
#nullable restore
#line 28 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
WriteAttributeValue("", 552, i, 552, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 554, "cadeira", 555, 8, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"cadeiraSelecionada(this)\">");
#nullable restore
#line 28 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 29 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <div>
        <div>
            Valor total:
             <span id=""totalCompra""></span>
        </div>
    </div>
</div>


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
#line 52 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
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
#line 68 "C:\Encantadas\NovoSiteEncantadas\WebEncantadas\Views\Ingresso\Reserve.cshtml"
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
