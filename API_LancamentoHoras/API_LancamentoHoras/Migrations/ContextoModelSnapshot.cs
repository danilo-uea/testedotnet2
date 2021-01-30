﻿// <auto-generated />
using System;
using API_LancamentoHoras.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_LancamentoHoras.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("API_LancamentoHoras.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Desenvolvedor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "15648548545",
                            Nome = "Lauro"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "94851451545",
                            Nome = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "45180084610",
                            Nome = "Ronaldo"
                        },
                        new
                        {
                            Id = 4,
                            Cpf = "00451104001",
                            Nome = "Rodrigo"
                        },
                        new
                        {
                            Id = 5,
                            Cpf = "74050048122",
                            Nome = "Alexandre"
                        });
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.DesenvolvedorProjeto", b =>
                {
                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.HasKey("ProjetoId", "DesenvolvedorId");

                    b.HasIndex("DesenvolvedorId");

                    b.ToTable("ProjetoDesenvolvedor");

                    b.HasData(
                        new
                        {
                            ProjetoId = 3,
                            DesenvolvedorId = 4
                        },
                        new
                        {
                            ProjetoId = 1,
                            DesenvolvedorId = 2
                        },
                        new
                        {
                            ProjetoId = 2,
                            DesenvolvedorId = 5
                        },
                        new
                        {
                            ProjetoId = 2,
                            DesenvolvedorId = 1
                        },
                        new
                        {
                            ProjetoId = 1,
                            DesenvolvedorId = 3
                        });
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.LancamentoHoras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesenvolvedorId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("LancamentoHoras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataFinal = new DateTime(2018, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DesenvolvedorId = 4,
                            ProjetoId = 3
                        },
                        new
                        {
                            Id = 2,
                            DataFinal = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DesenvolvedorId = 2,
                            ProjetoId = 1
                        },
                        new
                        {
                            Id = 3,
                            DataFinal = new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DesenvolvedorId = 5,
                            ProjetoId = 2
                        },
                        new
                        {
                            Id = 4,
                            DataFinal = new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DesenvolvedorId = 1,
                            ProjetoId = 2
                        },
                        new
                        {
                            Id = 5,
                            DataFinal = new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicial = new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DesenvolvedorId = 3,
                            ProjetoId = 1
                        });
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projeto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Agendamento e Horas"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Bar e Mercadinhos"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Empresa"
                        });
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.DesenvolvedorProjeto", b =>
                {
                    b.HasOne("API_LancamentoHoras.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany("ProjetosDesenvolvedores")
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_LancamentoHoras.Models.Projeto", "Projeto")
                        .WithMany("ProjetosDesenvolvedores")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desenvolvedor");

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.LancamentoHoras", b =>
                {
                    b.HasOne("API_LancamentoHoras.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany("LancamentosHoras")
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_LancamentoHoras.Models.Projeto", "Projeto")
                        .WithMany("LancamentosHoras")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desenvolvedor");

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.Desenvolvedor", b =>
                {
                    b.Navigation("LancamentosHoras");

                    b.Navigation("ProjetosDesenvolvedores");
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.Projeto", b =>
                {
                    b.Navigation("LancamentosHoras");

                    b.Navigation("ProjetosDesenvolvedores");
                });
#pragma warning restore 612, 618
        }
    }
}
