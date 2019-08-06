using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        List<Cliente> SelectAll(string nome);
    }
}
