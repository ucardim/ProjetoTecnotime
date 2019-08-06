using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ClienteEdicaoViewModel
    {
        [Required(ErrorMessage = "Informe o id do cliente.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF/CNPJ.")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "Informe a data de cadastro.")]
        public DateTime DataCadastro { get; set; }
    }
}
