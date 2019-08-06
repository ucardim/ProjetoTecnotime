using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ProdutoCadastroViewModel
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade.")]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o tipo de medida.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Informe o Id do cliente.")]
        public int IdCliente { get; set; }
    }
}
