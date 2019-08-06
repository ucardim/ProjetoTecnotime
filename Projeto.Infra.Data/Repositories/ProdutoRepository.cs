using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Infra.Data.Context;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;

namespace Projeto.Infra.Data.Repositories
{
    public class ProdutoRepository
        : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly DataContext context;

        public ProdutoRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
