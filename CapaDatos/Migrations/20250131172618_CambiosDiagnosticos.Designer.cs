﻿// <auto-generated />
using System;
using CapaDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CapaDatos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250131172618_CambiosDiagnosticos")]
    partial class CambiosDiagnosticos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("CapaDatos.Models.Consultas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("idPaciente")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("idPaciente");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("CapaDatos.Models.Diagnosticos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaDiagnostico")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdConsulta")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdConsulta");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("CapaDatos.Models.HistorialConsultas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConsultaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Detalles")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaHistorial")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("IdConsultas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaId");

                    b.HasIndex("IdPaciente");

                    b.ToTable("HistorialConsultas");
                });

            modelBuilder.Entity("CapaDatos.Models.Pacientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("DNI")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoSangre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("CapaDatos.Models.Pagos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FechaPago")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("IdConsulta")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MetodoPago")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IdConsulta");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("CapaDatos.Models.Tratamientos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Detalles")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdConsulta")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IdPaciente")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreTratamiento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdConsulta");

                    b.HasIndex("PacienteId");

                    b.ToTable("Tratamientos");
                });

            modelBuilder.Entity("CapaDatos.Models.Consultas", b =>
                {
                    b.HasOne("CapaDatos.Models.Pacientes", "Paciente")
                        .WithMany("Consulta")
                        .HasForeignKey("idPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("CapaDatos.Models.Diagnosticos", b =>
                {
                    b.HasOne("CapaDatos.Models.Consultas", "Consulta")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("CapaDatos.Models.HistorialConsultas", b =>
                {
                    b.HasOne("CapaDatos.Models.Consultas", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapaDatos.Models.Pacientes", "Paciente")
                        .WithMany("HistorialConsultas")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("CapaDatos.Models.Pagos", b =>
                {
                    b.HasOne("CapaDatos.Models.Consultas", "Consulta")
                        .WithMany("Pagos")
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("CapaDatos.Models.Tratamientos", b =>
                {
                    b.HasOne("CapaDatos.Models.Consultas", "Consulta")
                        .WithMany("Tratamientos")
                        .HasForeignKey("IdConsulta");

                    b.HasOne("CapaDatos.Models.Pacientes", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("CapaDatos.Models.Consultas", b =>
                {
                    b.Navigation("Diagnosticos");

                    b.Navigation("Pagos");

                    b.Navigation("Tratamientos");
                });

            modelBuilder.Entity("CapaDatos.Models.Pacientes", b =>
                {
                    b.Navigation("Consulta");

                    b.Navigation("HistorialConsultas");
                });
#pragma warning restore 612, 618
        }
    }
}
