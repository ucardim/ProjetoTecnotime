using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;

namespace Projeto.Domain.Services
{
    public class ProdutoDomainService
        : BaseDomainService<Produto>, IProdutoDomainService
    {
        //atributo
        private readonly IProdutoRepository repository;

        //construtor para injeção de dependência
        public ProdutoDomainService(IProdutoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
