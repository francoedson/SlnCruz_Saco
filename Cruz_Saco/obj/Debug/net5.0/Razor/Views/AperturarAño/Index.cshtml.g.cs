#pragma checksum "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff35f8e7d5c40e537d52cf9487195027b6436ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AperturarAño_Index), @"mvc.1.0.view", @"/Views/AperturarAño/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff35f8e7d5c40e537d52cf9487195027b6436ebd", @"/Views/AperturarAño/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d991fc755cf05b472ee09c3e75803f86f46552", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AperturarAño_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cruz_Saco.Models.Matricula>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff35f8e7d5c40e537d52cf9487195027b6436ebd4582", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff35f8e7d5c40e537d52cf9487195027b6436ebd4937", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff35f8e7d5c40e537d52cf9487195027b6436ebd6740", async() => {
                WriteLiteral("\r\n    <h2>Nuevo año escolar</h2>\r\n<p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff35f8e7d5c40e537d52cf9487195027b6436ebd7043", async() => {
                    WriteLiteral("Aperturar Nuevo Año");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Año));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimerDíaDeClases));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DíaDePago));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n             <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Año));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimerDíaDeClases));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DíaDePago));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    $(function () \r\n    {        \r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \'");
#nullable restore
#line 71 "C:\Users\franc\Downloads\fer\last\SlnCruz_Saco\Cruz_Saco\Views\AperturarAño\Index.cshtml"
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
                WriteLiteral("     $(\"#ulOpciones\").append(html);\r\n\r\n            },\r\n            error: function () {\r\n                alert(\"Error while inserting data\");\r\n            }\r\n        });\r\n    });\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cruz_Saco.Models.Matricula>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
