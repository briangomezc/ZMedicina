using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Persistence.Migrations
{
    public partial class Medico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "Paciente",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Paciente",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Paciente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Paciente",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Paciente",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Apellidos",
                table: "Paciente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedicoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellidos = table.Column<string>(nullable: true),
                    Cedula = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Especializaciones = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    TipoMedico = table.Column<string>(nullable: true),
                    sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedicoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Paciente",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Apellidos",
                table: "Paciente",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
