using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapaDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarRelacionTratamientos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tratamientos_Consultas_IdConsulta",
                table: "Tratamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tratamientos_Pacientes_PacienteId",
                table: "Tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_Tratamientos_IdConsulta",
                table: "Tratamientos");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "Tratamientos",
                newName: "ConsultaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tratamientos_PacienteId",
                table: "Tratamientos",
                newName: "IX_Tratamientos_ConsultaId");

            migrationBuilder.AlterColumn<int>(
                name: "IdPaciente",
                table: "Tratamientos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_IdPaciente",
                table: "Tratamientos",
                column: "IdPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_Tratamientos_Consultas_ConsultaId",
                table: "Tratamientos",
                column: "ConsultaId",
                principalTable: "Consultas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tratamientos_Pacientes_IdPaciente",
                table: "Tratamientos",
                column: "IdPaciente",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tratamientos_Consultas_ConsultaId",
                table: "Tratamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tratamientos_Pacientes_IdPaciente",
                table: "Tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_Tratamientos_IdPaciente",
                table: "Tratamientos");

            migrationBuilder.RenameColumn(
                name: "ConsultaId",
                table: "Tratamientos",
                newName: "PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Tratamientos_ConsultaId",
                table: "Tratamientos",
                newName: "IX_Tratamientos_PacienteId");

            migrationBuilder.AlterColumn<int>(
                name: "IdPaciente",
                table: "Tratamientos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_IdConsulta",
                table: "Tratamientos",
                column: "IdConsulta");

            migrationBuilder.AddForeignKey(
                name: "FK_Tratamientos_Consultas_IdConsulta",
                table: "Tratamientos",
                column: "IdConsulta",
                principalTable: "Consultas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tratamientos_Pacientes_PacienteId",
                table: "Tratamientos",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
