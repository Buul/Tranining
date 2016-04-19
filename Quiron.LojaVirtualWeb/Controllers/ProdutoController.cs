using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtualWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorio _repositorio; 
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var lstProdutos = _repositorio.Produtos.Take(10);
            return View(lstProdutos);
        }
    }
}