using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Persistence.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PacienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellidos = table.Column<string>(maxLength: 30, nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    Pass = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: false),
                    sexo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
