using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Persistence.Migrations
{
    public partial class tipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historials_Medico_MedicoID",
                table: "Historials");

            migrationBuilder.DropForeignKey(
                name: "FK_Historials_Paciente_PacienteID",
                table: "Historials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historials",
                table: "Historials");

            migrationBuilder.RenameTable(
                name: "Historials",
                newName: "Historial");

            migrationBuilder.RenameIndex(
                name: "IX_Historials_PacienteID",
                table: "Historial",
                newName: "IX_Historial_PacienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Historials_MedicoID",
                table: "Historial",
                newName: "IX_Historial_MedicoID");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Medico",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Medico",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historial",
                table: "Historial",
                column: "HistorialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Historial_Medico_MedicoID",
                table: "Historial",
                column: "MedicoID",
                principalTable: "Medico",
                principalColumn: "MedicoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historial_Paciente_PacienteID",
                table: "Historial",
                column: "PacienteID",
                principalTable: "Paciente",
                principalColumn: "PacienteID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historial_Medico_MedicoID",
                table: "Historial");

            migrationBuilder.DropForeignKey(
                name: "FK_Historial_Paciente_PacienteID",
                table: "Historial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historial",
                table: "Historial");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Medico");

            migrationBuilder.RenameTable(
                name: "Historial",
                newName: "Historials");

            migrationBuilder.RenameIndex(
                name: "IX_Historial_PacienteID",
                table: "Historials",
                newName: "IX_Historials_PacienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Historial_MedicoID",
                table: "Historials",
                newName: "IX_Historials_MedicoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historials",
                table: "Historials",
                column: "HistorialID");

            migrationBuilder.AddForeignKey(
                name: "FK_Historials_Medico_MedicoID",
                table: "Historials",
                column: "MedicoID",
                principalTable: "Medico",
                principalColumn: "MedicoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historials_Paciente_PacienteID",
                table: "Historials",
                column: "PacienteID",
                principalTable: "Paciente",
                principalColumn: "PacienteID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
