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
    partial class PacienteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Medico", b =>
                {
                    b.Property<int>("MedicoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Cedula");

                    b.Property<string>("Celular");

                    b.Property<string>("Email");

                    b.Property<string>("Especializaciones");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Nombre");

                    b.Property<string>("Pass");

                    b.Property<string>("Telefono");

                    b.Property<string>("TipoMedico");

                    b.Property<string>("sexo");

                    b.HasKey("MedicoID");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("Model.Paciente", b =>
                {
                    b.Property<int>("PacienteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Cedula");

                    b.Property<string>("Celular");

                    b.Property<string>("Email");

                    b.Property<DateTime>("Fecha");

                    b.Property<int?>("MedicoID")
                        .IsRequired();

                    b.Property<string>("Nombre");

                    b.Property<string>("Pass");

                    b.Property<string>("Telefono");

                    b.Property<string>("sexo");

                    b.HasKey("PacienteID");

                    b.HasIndex("MedicoID");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Model.Paciente", b =>
                {
                    b.HasOne("Model.Medico", "Medico")
                        .WithMany("Pacientes")
                        .HasForeignKey("MedicoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
