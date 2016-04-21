using System.Collections.Generic;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtualWeb.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }
    }
}