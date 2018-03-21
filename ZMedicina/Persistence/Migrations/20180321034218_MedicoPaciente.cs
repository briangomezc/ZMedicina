using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Persistence.Migrations
{
    public partial class MedicoPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicoID",
                table: "Paciente",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_MedicoID",
                table: "Paciente",
                column: "MedicoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Medico_MedicoID",
                table: "Paciente",
                column: "MedicoID",
                principalTable: "Medico",
                principalColumn: "MedicoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Medico_MedicoID",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_MedicoID",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "MedicoID",
                table: "Paciente");
        }
    }
}
