using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapaDatos.Migrations
{
    /// <inheritdoc />
    public partial class FixingTratamientos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tratamientos_Consultas_ConsultaId",
                table: "Tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_Tratamientos_ConsultaId",
                table: "Tratamientos");

            migrationBuilder.DropColumn(
                name: "ConsultaId",
                table: "Tratamientos");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_IdConsulta",
                table: "Tratamientos",
                column: "IdConsulta");

            migrationBuilder.AddForeignKey(
                name: "FK_Tratamientos_Consultas_IdConsulta",
                table: "Tratamientos",
                column: "IdConsulta",
                principalTable: "Consultas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tratamientos_Consultas_IdConsulta",
                table: "Tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_Tratamientos_IdConsulta",
                table: "Tratamientos");

            migrationBuilder.AddColumn<int>(
                name: "ConsultaId",
                table: "Tratamientos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_ConsultaId",
                table: "Tratamientos",
                column: "ConsultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tratamientos_Consultas_ConsultaId",
                table: "Tratamientos",
                column: "ConsultaId",
                principalTable: "Consultas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
