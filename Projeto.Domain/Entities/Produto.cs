using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
        public int IdCliente { get; set; }

        public Cliente Cliente { get; set; }
    }
}
