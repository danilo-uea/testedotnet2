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
                });

            modelBuilder.Entity("API_LancamentoHoras.Models.ProjetoDesenvolvedor", b =>
                {
                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.HasKey("ProjetoId", "DesenvolvedorId");

                    b.HasIndex("DesenvolvedorId");

                    b.ToTable("ProjetoDesenvolvedor");
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

            modelBuilder.Entity("API_LancamentoHoras.Models.ProjetoDesenvolvedor", b =>
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
