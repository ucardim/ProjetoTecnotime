using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public List<Produto> Produtos { get; set; }

    }
}
