using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Projeto.Infra.Data.Repositories
{
    public class ClienteRepository
        : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DataContext context;

        public ClienteRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public List<Cliente> SelectAll(string nome)
        {
            return context.Cliente
                  .Include(c => c.Produtos)
                  .Where(c => c.Nome.Contains(nome))
                  .OrderBy(c => c.Nome)
                  .ToList();
        }
    }
}
