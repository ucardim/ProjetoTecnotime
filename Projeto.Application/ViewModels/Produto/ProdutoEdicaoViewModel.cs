using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ProdutoEdicaoViewModel
    {
        [Required(ErrorMessage = "Informe o id do produto.")]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o tipo de medida.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Informe o id do cliente.")]
        public int IdCliente { get; set; }
    }
}