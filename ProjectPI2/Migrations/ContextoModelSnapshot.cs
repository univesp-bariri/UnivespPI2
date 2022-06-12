﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebPostgreSQL.Models;

#nullable disable

namespace ProjectPI2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectPI2.Models.candidato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("qualificacao")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("usuarioId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("usuarioId");

                    b.ToTable("candidato");
                });

            modelBuilder.Entity("ProjectPI2.Models.candidatura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("candidatoId")
                        .HasColumnType("integer");

                    b.Property<int>("contratanteId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("data")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("expiradata")
                        .HasColumnType("DATE");

                    b.HasKey("id");

                    b.ToTable("candidatura");
                });

            modelBuilder.Entity("ProjectPI2.Models.categoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("candidaturaId")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("trabalhoId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("candidaturaId");

                    b.HasIndex("trabalhoId");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("ProjectPI2.Models.contratante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("setor")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("usuarioId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("usuarioId");

                    b.ToTable("contratante");
                });

            modelBuilder.Entity("ProjectPI2.Models.local", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("candidaturaId")
                        .HasColumnType("integer");

                    b.Property<string>("cep")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("cidade")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("endereco")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("estado")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("pais")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("trabalhoId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("candidaturaId");

                    b.HasIndex("trabalhoId")
                        .IsUnique();

                    b.ToTable("local");
                });

            modelBuilder.Entity("ProjectPI2.Models.trabalho", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("candidaturaId")
                        .HasColumnType("integer");

                    b.Property<int>("categoriaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("dataContratacao")
                        .HasColumnType("DATE");

                    b.Property<int>("localId")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .HasColumnType("varchar(50)");

                    b.Property<double>("salario")
                        .HasColumnType("DOUBLE PRECISION");

                    b.Property<string>("titulo")
                        .HasColumnType("varchar(30)");

                    b.HasKey("id");

                    b.HasIndex("candidaturaId");

                    b.HasIndex("categoriaId");

                    b.ToTable("trabalho");
                });

            modelBuilder.Entity("ProjectPI2.Models.usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("candidatoId")
                        .HasColumnType("integer");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("cnpj")
                        .HasColumnType("VARCHAR(14)");

                    b.Property<int>("contratanteId")
                        .HasColumnType("integer");

                    b.Property<string>("cpf")
                        .HasColumnType("VARCHAR(11)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("pais")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("pjuridica")
                        .HasColumnType("Boolean  DEFAULT FALSE");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("id");

                    b.HasIndex("candidatoId");

                    b.HasIndex("contratanteId");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("ProjectPI2.Models.candidato", b =>
                {
                    b.HasOne("ProjectPI2.Models.usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjectPI2.Models.categoria", b =>
                {
                    b.HasOne("ProjectPI2.Models.candidatura", "Candidatura")
                        .WithMany()
                        .HasForeignKey("candidaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectPI2.Models.trabalho", "Trabalho")
                        .WithMany()
                        .HasForeignKey("trabalhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidatura");

                    b.Navigation("Trabalho");
                });

            modelBuilder.Entity("ProjectPI2.Models.contratante", b =>
                {
                    b.HasOne("ProjectPI2.Models.usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjectPI2.Models.local", b =>
                {
                    b.HasOne("ProjectPI2.Models.candidatura", "Candidatura")
                        .WithMany()
                        .HasForeignKey("candidaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectPI2.Models.trabalho", "Trabalho")
                        .WithOne("Local")
                        .HasForeignKey("ProjectPI2.Models.local", "trabalhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidatura");

                    b.Navigation("Trabalho");
                });

            modelBuilder.Entity("ProjectPI2.Models.trabalho", b =>
                {
                    b.HasOne("ProjectPI2.Models.candidatura", "Candidatura")
                        .WithMany()
                        .HasForeignKey("candidaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectPI2.Models.categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidatura");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ProjectPI2.Models.usuario", b =>
                {
                    b.HasOne("ProjectPI2.Models.candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("candidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectPI2.Models.contratante", "Contratante")
                        .WithMany()
                        .HasForeignKey("contratanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");

                    b.Navigation("Contratante");
                });

            modelBuilder.Entity("ProjectPI2.Models.trabalho", b =>
                {
                    b.Navigation("Local");
                });
#pragma warning restore 612, 618
        }
    }
}