#pragma checksum "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90705d87cd675e5d82ae1555066c3fa08e7a7bfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConsultaPagosCliente_PagoCliente), @"mvc.1.0.view", @"/Views/ConsultaPagosCliente/PagoCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90705d87cd675e5d82ae1555066c3fa08e7a7bfa", @"/Views/ConsultaPagosCliente/PagoCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d991fc755cf05b472ee09c3e75803f86f46552", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ConsultaPagosCliente_PagoCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cruz_Saco.Models.PagosClienteClass>>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90705d87cd675e5d82ae1555066c3fa08e7a7bfa3714", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>PagoCliente</title>\r\n    <script type=\"text/javascript\">\r\n\r\n    $(function () \r\n    {        \r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \'");
#nullable restore
#line 19 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
             Write(Url.Action("ListarMenu","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
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
                            '<a class=""nav-link dropdown-toggle"" h");
                WriteLiteral(@"ref=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">' +
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

                // Inserto la variable html dentro del elemento ul
           ");
                WriteLiteral("     $(\"#ulOpciones\").append(html);\r\n\r\n            },\r\n            error: function () {\r\n                alert(\"Error while inserting data\");\r\n            }\r\n        });\r\n    });\r\n\r\n</script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90705d87cd675e5d82ae1555066c3fa08e7a7bfa7577", async() => {
                WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 83 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.Apoderado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 86 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.Parentesco));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 89 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.Estudiante));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.Concepto));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaPago));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 98 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.HoraPago));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 101 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.Monto));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 104 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 107 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayNameFor(model => model.AjusteManual));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 113 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apoderado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.Parentesco));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 122 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estudiante));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 125 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.Concepto));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 128 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaPago));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 131 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoraPago));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 134 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.Monto));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 137 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descuento));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 140 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
           Write(Html.DisplayFor(modelItem => item.AjusteManual));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 144 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\ConsultaPagosCliente\PagoCliente.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cruz_Saco.Models.PagosClienteClass>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
