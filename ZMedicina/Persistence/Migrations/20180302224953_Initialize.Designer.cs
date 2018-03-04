﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Persistence;
using System;

namespace Persistence.Migrations
{
    [DbContext(typeof(PacienteDbContext))]
    [Migration("20180302224953_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Paciente", b =>
                {
                    b.Property<int>("PacienteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Pass");

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.Property<string>("sexo")
                        .IsRequired();

                    b.HasKey("PacienteID");

                    b.ToTable("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}
