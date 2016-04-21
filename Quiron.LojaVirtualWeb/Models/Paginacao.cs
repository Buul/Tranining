using System;

namespace Quiron.LojaVirtualWeb.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; }
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        public int TotalPagina => (int) Math.Ceiling((decimal) ItensTotal/ItensPorPagina);
    }
}