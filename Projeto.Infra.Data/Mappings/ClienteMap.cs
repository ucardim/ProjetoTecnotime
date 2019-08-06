using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Projeto.Infra.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.IdCliente);

            builder.Property(c => c.IdCliente)
                .HasColumnName("IdCliente");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.CpfCnpj)
                .HasColumnName("CpfCnpj")
                 .IsRequired();

            builder.Property(c => c.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("date")
                .IsRequired();
        }

    }
}
