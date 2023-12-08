﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _19_Atividade_CRUD.Context;

#nullable disable

namespace _19_Atividade_CRUD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231005113229_migrando")]
    partial class migrando
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("_19_Atividade_CRUD.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("_19_Atividade_CRUD.Models.Perfume", b =>
                {
                    b.Property<int>("PerfumeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("PerfumeId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Perfumes");
                });

            modelBuilder.Entity("_19_Atividade_CRUD.Models.Perfume", b =>
                {
                    b.HasOne("_19_Atividade_CRUD.Models.Categoria", "Categoria")
                        .WithMany("Perfumes")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("_19_Atividade_CRUD.Models.Categoria", b =>
                {
                    b.Navigation("Perfumes");
                });
#pragma warning restore 612, 618
        }
    }
}
