using Projeto.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.ViewModels
{
    public class ProdutoConsultaViewModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int IdCliente { get; set; }

        public ClienteConsultaViewModel Cliente { get; set; }
    }
}

