using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Projeto.Infra.Data.Mappings;
using Projeto.Domain.Entities;

namespace Projeto.Infra.Data.Context
{
        
        public class DataContext : DbContext
        {
            //Construtor
            public DataContext(DbContextOptions<DataContext> builder) : base(builder)
            {

            }
            
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //adicionar cada classe mapeada no projeto
                modelBuilder.ApplyConfiguration(new ClienteMap());
                modelBuilder.ApplyConfiguration(new ProdutoMap());
            }

            //Declarar uma propriedade set/get para cada entidade
            //utilizando a classe DbSet do EntityFramework (LAMBDA)
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Produto> Produto { get; set; }
        }
}
