using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapaDatos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {//Esto es lo que se ejecuta al hacer la migración
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    DNI = table.Column<int>(type: "INTEGER", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TipoSangre = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Motivo = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdConsulta = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    FechaDiagnostico = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Consultas_IdConsulta",
                        column: x => x.IdConsulta,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialConsultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    IdConsultas = table.Column<int>(type: "INTEGER", nullable: false),
                    ConsultaId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaHistorial = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Detalles = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialConsultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialConsultas_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialConsultas_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdConsulta = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaPago = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    MetodoPago = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Consultas_IdConsulta",
                        column: x => x.IdConsulta,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tratamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreTratamiento = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    IdConsulta = table.Column<int>(type: "INTEGER", nullable: true),
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: true),
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Detalles = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tratamientos_Consultas_IdConsulta",
                        column: x => x.IdConsulta,
                        principalTable: "Consultas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tratamientos_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_idPaciente",
                table: "Consultas",
                column: "idPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_IdConsulta",
                table: "Diagnosticos",
                column: "IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialConsultas_ConsultaId",
                table: "HistorialConsultas",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialConsultas_IdPaciente",
                table: "HistorialConsultas",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdConsulta",
                table: "Pagos",
                column: "IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_IdConsulta",
                table: "Tratamientos",
                column: "IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_PacienteId",
                table: "Tratamientos",
                column: "PacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "HistorialConsultas");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Tratamientos");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
