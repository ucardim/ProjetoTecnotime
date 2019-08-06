using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Projeto.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.IdProduto);

            builder.Property(p => p.IdProduto)
                .HasColumnName("IdProduto");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasColumnName("Quantidade")
                .IsRequired();

            builder.Property(p => p.Tipo)
                .HasColumnName("Tipo")
                 .IsRequired();

            builder.Property(p => p.IdCliente)
                .HasColumnName("IdCliente")
                .IsRequired();

            //Mapeamento do relacionamento
            builder.HasOne(p => p.Cliente) //Produto TEM 1 Cliente
                .WithMany(c => c.Produtos) //Cliente TEM N Produtos
                .HasForeignKey(p => p.IdCliente) //chave estrangeira
                .OnDelete(DeleteBehavior.Restrict); //Não Delete Cascade!
        }
    }
}
