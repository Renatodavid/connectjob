﻿// <auto-generated />
using ConnectJob.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConnectJob.Migrations
{
    [DbContext(typeof(ConnectjobContext))]
    partial class ConnectjobContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ConnectJob.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "12312312312",
                            Email = "rafaelsantos@hotmail.com",
                            Nome = "Rafael santos",
                            Senha = "123123"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "12312312312",
                            Email = "rafaelnascimento@hotmail.com",
                            Nome = "Rafael nascimento",
                            Senha = "123123"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "12312312312",
                            Email = "renatomdavid811@hotmail.com",
                            Nome = "Renato marques david",
                            Senha = "123123"
                        },
                        new
                        {
                            Id = 4,
                            Cpf = "12312312312",
                            Email = "myllhertavares@hotmail.com",
                            Nome = "Myller Tavares",
                            Senha = "123123"
                        },
                        new
                        {
                            Id = 5,
                            Cpf = "12312312312",
                            Email = "stefanymarques@hotmail.com",
                            Nome = "stefany marques",
                            Senha = "123123"
                        },
                        new
                        {
                            Id = 6,
                            Cpf = "12312312312",
                            Email = "thalessampaio@hotmail.com",
                            Nome = "Thales Sampaio",
                            Senha = "123123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
