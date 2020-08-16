﻿// <auto-generated />
using System;
using DashInvestimentos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DashInvestimentos.Migrations
{
    [DbContext(typeof(DashInvestimentosContext))]
    partial class DashInvestimentosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DashInvestimentos.Models.Movimentacao", b =>
                {
                    b.Property<int>("MovimentacaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Status");

                    b.Property<string>("Tipo");

                    b.Property<float>("TotalMovimentacao");

                    b.Property<float>("ValorCompra");

                    b.Property<float>("ValorVenda");

                    b.HasKey("MovimentacaoId");

                    b.ToTable("Movimentacao");
                });
#pragma warning restore 612, 618
        }
    }
}
