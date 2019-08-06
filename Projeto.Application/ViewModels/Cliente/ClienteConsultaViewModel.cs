using Projeto.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.ViewModels
{
    public class ClienteConsultaViewModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdProduto { get; set; }

        public ProdutoConsultaViewModel Produto { get; set; }
    }
}
