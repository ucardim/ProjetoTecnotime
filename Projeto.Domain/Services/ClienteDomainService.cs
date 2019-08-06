using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;

namespace Projeto.Domain.Services
{
    public class ClienteDomainService
        : BaseDomainService<Cliente>, IClienteDomainService
    {
        //atributo
        private readonly IClienteRepository repository;

        //construtor para injeção de dependência
        public ClienteDomainService(IClienteRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public List<Cliente> ConsultarTodos(string nome)
        {
            return repository.SelectAll(nome);
        }
    }
}
