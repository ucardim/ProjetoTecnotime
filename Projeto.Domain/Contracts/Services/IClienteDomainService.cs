using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Contracts.Services
{
    public interface IClienteDomainService : IBaseDomainService<Cliente>
    {
        List<Cliente> ConsultarTodos(string nome);
    }
}
