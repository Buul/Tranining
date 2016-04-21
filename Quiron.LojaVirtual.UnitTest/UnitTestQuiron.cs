using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtualWeb.HtmlHelpers;
using Quiron.LojaVirtualWeb.Models;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void PaginacaoGeradaCorretamente()
        {
            //Arrange
            HtmlHelper html = null;
            var paginacao = new Paginacao
            {
                ItensPorPagina = 10,
                ItensTotal = 28,
                PaginaAtual = 2
            };
            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //Assert

            Assert.AreEqual(
                   @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                 + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                 + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
                 );
        }
    }
}
