#pragma checksum "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab346a6538849175d5c30088e33b03972cfa208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\_ViewImports.cshtml"
using Cruz_Saco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\_ViewImports.cshtml"
using Cruz_Saco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab346a6538849175d5c30088e33b03972cfa208", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d991fc755cf05b472ee09c3e75803f86f46552", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab346a6538849175d5c30088e33b03972cfa2083712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""home-container"">
    <h1 class=""text-center"">Bienvenido a la Intranet del Colegio Cruz Saco</h1>
    <p class=""text-center"">Aquí podrás hacer tus pagos de pensiones y otros servicios del colegio</p>
</div>


<script type=""text/javascript"">
    $(function () {
        
        // Guardo el codigo del perfil en un input hidden ubicado en el layout

        $.ajax({
            type: ""POST"",
            url: '");
#nullable restore
#line 20 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\Home\Index.cshtml"
             Write(Url.Action("ListarMenu","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            //data: JSON.stringify(nPerfil),
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {
            
                // variable que acumulará la construccion del menu dinamico
                var html = '';

                // variable que me ayuda a controlar la iteracion, si es un cambio de padre/opcion principal
                var Cod_Padre = -1;

                data.forEach(function (item) 
                {
                    //debugger;
                    // Es un registro de tipo padre?
                    if (item.cod_Padre == 0)
                    {
                        if (Cod_Padre != -1)
                        {
                            html = html + '</div>' +
                                '</li>';
                        }

                        Cod_Padre = item.cod_Padre

                        html = html + '<li class=""nav-item dropdown"">' +
                    ");
            WriteLiteral(@"        '<a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">' +
                            item.nombre +
                            '</a>' +
                            '<div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">';
                    }
                    else
                    {
                        html = html + '<a class=""dropdown-item"" href=""' + item.ruta + '"">' + item.nombre + '</a>';
                    }
                    
                });

                // Completo el cierre de etiquetas div y li de la ultima iteracion
                html = html + '</div>' +
                                '</li>';

                // Agrego estaticamente la opcion de cerrar sesion
                html = html + '<li class=""nav-item"">' +
                    '<a class=""nav-link text-dark"" href=""/Seguridad/Index"">Cerrar Sesión</a>' +
                    '</li>';

           ");
            WriteLiteral(@"     // Inserto la variable html dentro del elemento ul
                $(""#ulOpciones"").append(html);

            },
            error: function () {
                alert(""Error while inserting data"");
            }
        });

        
                
    });
</script>");
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