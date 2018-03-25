using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Persistence.Migrations
{
    public partial class pacienteMedico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "pacienteMedico",
                columns: table => new
                {
                    PacienteID = table.Column<int>(nullable: false),
                    MedicoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacienteMedico", x => new { x.PacienteID, x.MedicoID });
                    table.ForeignKey(
                        name: "FK_pacienteMedico_Medico_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medico",
                        principalColumn: "MedicoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pacienteMedico_Paciente_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Paciente",
                        principalColumn: "PacienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pacienteMedico_MedicoID",
                table: "pacienteMedico",
                column: "MedicoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pacienteMedico");

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
