#pragma checksum "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d33814c7c41451fd63408e59c41333e76163c2e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_GetContaPorID), @"mvc.1.0.view", @"/Views/Conta/GetContaPorID.cshtml")]
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
#line 1 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\_ViewImports.cshtml"
using atomosDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
using atomosDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33814c7c41451fd63408e59c41333e76163c2e9", @"/Views/Conta/GetContaPorID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69b5d0fbf5df5659160f2aa2f70b40ab5e2025e", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_GetContaPorID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conta>
    {
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3 class=\"display-5\">Dados de uma conta</h3>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d33814c7c41451fd63408e59c41333e76163c2e93533", async() => {
                WriteLiteral("\r\n    <label >ID da Conta</label>\r\n    <input type=\"number\" id=\"id\" name=\"id\">\r\n    <input type=\"submit\" value=\"Procurar\" formmethod=\"POST\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
 if(Model!=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <label><b>Tipo de Conta: </b>\r\n");
#nullable restore
#line 19 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                 switch(@Model.tipo)
                {
                    case 0: 

#line default
#line hidden
#nullable disable
            WriteLiteral("Conta Corrente");
#nullable restore
#line 21 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                                       ; break;
                    case 1: 

#line default
#line hidden
#nullable disable
            WriteLiteral("Conta Poupança");
#nullable restore
#line 22 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                                       ; break;
                    case 2: 

#line default
#line hidden
#nullable disable
            WriteLiteral("Conta Investimento");
#nullable restore
#line 23 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                                           ; break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </label>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <label><b>Agencia: </b>");
#nullable restore
#line 28 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                  Write(Model.agencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <label><b>Conta: </b>");
#nullable restore
#line 31 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                Write(Model.conta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <label><b>Saldo: </b>R$ ");
#nullable restore
#line 34 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                   Write(Model.saldo.ToString("n"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <label><b>Titular da Conta: </b>");
#nullable restore
#line 37 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                           Write(Model.titular_da_conta.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <label><b>CPF: </b>");
#nullable restore
#line 40 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                              Write(Model.titular_da_conta.cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <label><b>Telefone: </b>");
#nullable restore
#line 43 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                   Write(Model.titular_da_conta.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <label><b>Email: </b>");
#nullable restore
#line 46 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
                                Write(Model.titular_da_conta.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\temp\visualStudioCode\Itau - Formacao Especializacao\projetoFinalJavaSpring\api-spring-boot-itautech\atomosDev\Views\Conta\GetContaPorID.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conta> Html { get; private set; }
    }
}
#pragma warning restore 1591
