#pragma checksum "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c0e5d850c661bcf7a3c3a16ec986228f48415b"
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
#line 1 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\_ViewImports.cshtml"
using ForumEtec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\_ViewImports.cshtml"
using ForumEtec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c0e5d850c661bcf7a3c3a16ec986228f48415b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0cf75639295ee3cefd89b1e7d35e0a52d6ab3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ForumEtec.Models.Pergunta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-3"">
        <div class=""list-group"">
            <a href=""#"" class=""list-group-item list-group-item-action active"">
                Cras justo odio
            </a>
            <a href=""#"" class=""list-group-item list-group-item-action"">Dapibus ac facilisis in</a>
            <a href=""#"" class=""list-group-item list-group-item-action"">Morbi leo risus</a>
            <a href=""#"" class=""list-group-item list-group-item-action"">Porta ac consectetur ac</a>
            <a href=""#"" class=""list-group-item list-group-item-action disabled"">Vestibulum at eros</a>
        </div>
    </div>
    <div class=""col-sm-9"">

");
#nullable restore
#line 21 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {
            var id = "Resposta" + item.PerguntaId;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-left mb-3\">\r\n            <div class=\"card-header\">\r\n                <h4>");
#nullable restore
#line 27 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Aluno.NomeAluno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h5 class=\"text-secondary\">");
#nullable restore
#line 28 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Aluno.CursoAluno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 32 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.TituloPergunta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 33 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.DescricaoPergunta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
#nullable restore
#line 36 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                 if (item.Respostas != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1490, "\"", 1518, 3);
            WriteAttributeValue("", 1500, "Mudarestado(\'", 1500, 13, true);
#nullable restore
#line 39 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 1513, id, 1513, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1516, "\')", 1516, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Respostas: ");
#nullable restore
#line 39 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.Respostas.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 1617, "\"", 1625, 1);
#nullable restore
#line 40 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
WriteAttributeValue("", 1622, id, 1622, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\">\r\n\r\n\r\n");
#nullable restore
#line 43 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                         foreach (var resposta in item.Respostas)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card mt-3\">\r\n                            <div class=\"card-header\">\r\n                                <h5>");
#nullable restore
#line 47 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => resposta.Aluno.NomeAluno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h6 class=\"text-secondary\">");
#nullable restore
#line 48 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => resposta.Aluno.CursoAluno));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <blockquote class=\"blockquote mb-0\">\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 52 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => resposta.DescricaoResposta));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <footer class=""blockquote-footer"">Someone famous in <cite title=""Source Title"">Source Title</cite></footer>
                                </blockquote>
                            </div>
                        </div>
");
#nullable restore
#line 57 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 60 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n            \r\n\r\n            <div class=\"card-footer text-muted\">\r\n                2 days ago\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 72 "D:\MeusProjetos\ForumEtec\ForumEtecWeb\ForumEtec\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ForumEtec.Models.Pergunta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
