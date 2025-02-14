using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.Interfaces;
using CapaDatos.Models;
using OfficeOpenXml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaLogica.Servicios
{
    public class ExportarExcel : IExportarExcel
    {
        private readonly IPacientesServices _pacientesServices;
        private readonly IConsultasServices consultasServices;
        private readonly ITratamientosServices tratamientosServices;
        private readonly IPagosServices pagosServices;
        private readonly IDiagnosticosServices diagnosticosServices;
        public ExportarExcel(IPacientesServices pacientesServices, IConsultasServices consultasServices, ITratamientosServices tratamientos, IPagosServices pagosServices, IDiagnosticosServices diagnosticosServices)
        {
            this._pacientesServices = pacientesServices;
            this.consultasServices = consultasServices;
            this.tratamientosServices = tratamientos;
            this.pagosServices = pagosServices;
            this.diagnosticosServices = diagnosticosServices;
        }
        public async Task ExportarAExcel(string tabla, string rutaArchivo)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(tabla);

                int row = 2;

                switch (tabla)
                {
                    case "Consultas":
                        var consultas = await consultasServices.GetConsultasWithRealtiosnAsync();
                        worksheet.Cells[1, 1].Value = "ID Consulta";
                        worksheet.Cells[1, 2].Value = "Paciente";
                        worksheet.Cells[1, 3].Value = "Fecha";
                        worksheet.Cells[1, 4].Value = "Motivo";
                        worksheet.Cells[1, 5].Value = "Observaciones";

                        foreach (var consulta in consultas)
                        {
                            worksheet.Cells[row, 1].Value = consulta.Id;
                            worksheet.Cells[row, 2].Value = $"{consulta.Paciente.Nombre} {consulta.Paciente.Apellido}";
                            worksheet.Cells[row, 3].Value = consulta.Fecha;
                            worksheet.Cells[row, 4].Value = consulta.Motivo;
                            worksheet.Cells[row, 5].Value = consulta.Observaciones;
                            row++;
                        }
                        break;

                    case "Pacientes":
                        var pacientes = await _pacientesServices.GetPacientesAsync();
                        worksheet.Cells[1, 1].Value = "ID Paciente";
                        worksheet.Cells[1, 2].Value = "Nombre";
                        worksheet.Cells[1, 3].Value = "Apellido";
                        worksheet.Cells[1, 4].Value = "Edad";
                        worksheet.Cells[1, 5].Value = "DNI";
                        worksheet.Cells[1, 6].Value = "Teléfono";
                        worksheet.Cells[1, 7].Value = "Email";
                        worksheet.Cells[1, 8].Value = "Tipo de sangre";
                        worksheet.Cells[1, 9].Value = "Fecha de Nacimiento";

                        foreach (var paciente in pacientes)
                        {
                            worksheet.Cells[row, 1].Value = paciente.Id;
                            worksheet.Cells[row, 2].Value = paciente.Nombre;
                            worksheet.Cells[row, 3].Value = paciente.Apellido;
                            worksheet.Cells[row, 4].Value = paciente.Edad;
                            worksheet.Cells[row, 5].Value = paciente.DNI;
                            worksheet.Cells[row, 6].Value = paciente.Telefono;
                            worksheet.Cells[row, 7].Value = paciente.Email;
                            worksheet.Cells[row, 8].Value = paciente.TipoSangre;
                            worksheet.Cells[row, 9].Value = paciente.FechaNacimiento;
                            row++;
                        }
                        break;

                    case "Tratamientos":
                        var tratamientos = await tratamientosServices.GetTratamientosWithRealtiosnAsync();
                        var datos = tratamientos.Select(t => new
                        {
                            t.Id,
                            t.NombreTratamiento,
                            t.Paciente.Nombre,
                            t.Paciente.Apellido,
                            t.FechaInicio,
                            t.FechaFin,
                            t.Detalles,
                        });
                        worksheet.Cells[1, 1].Value = "ID Tratamiento";
                        worksheet.Cells[1, 2].Value = "Nombre";
                        worksheet.Cells[1, 3].Value = "Apellido";
                        worksheet.Cells[1, 4].Value = "Fecha Inicio";
                        worksheet.Cells[1, 5].Value = "Fecha Fin";
                        worksheet.Cells[1, 6].Value = "Detalles";
                        foreach(var tratamiento in datos)
                        {
                            worksheet.Cells[row, 1].Value = tratamiento.Id;
                            worksheet.Cells[row, 2].Value = tratamiento.NombreTratamiento;
                            worksheet.Cells[row, 3].Value = tratamiento.Nombre;
                            worksheet.Cells[row, 4].Value = tratamiento.FechaInicio;
                            worksheet.Cells[row, 5].Value = tratamiento.FechaFin;
                            worksheet.Cells[row, 6].Value = tratamiento.Detalles;
                            row++;
                        }
                        break;
                    case "Diagnosticos":
                        var diagnosticos = await diagnosticosServices.GetAllRelationsAsync();
                        var diagnostico = diagnosticos.Select(d => new
                        {
                            d.Id,
                            d.Descripcion,
                            d.FechaDiagnostico,
                            d.Consulta.Fecha,
                            d.Consulta.Paciente.Nombre,
                            d.Consulta.Paciente.Apellido
                        });
                        worksheet.Cells[1, 1].Value = "ID Diagnóstico";
                        worksheet.Cells[1, 2].Value = "Nombre";
                        worksheet.Cells[1, 3].Value = "Apellido";
                        worksheet.Cells[1, 4].Value = "Descripcion";
                        worksheet.Cells[1, 5].Value = "Fecha de Diagnóstico";
                        worksheet.Cells[1, 6].Value = "Fecha de Consulta";
                        foreach (var diagnostico1 in diagnostico)
                        {
                            worksheet.Cells[row, 1].Value = diagnostico1.Id;
                            worksheet.Cells[row, 2].Value = diagnostico1.Nombre;
                            worksheet.Cells[row, 3].Value = diagnostico1.Apellido;
                            worksheet.Cells[row, 4].Value = diagnostico1.Descripcion;
                            worksheet.Cells[row, 5].Value = diagnostico1.FechaDiagnostico;
                            worksheet.Cells[row, 6].Value = diagnostico1.Fecha;
                            row++;
                        }
                        break;
                    case "Pagos":
                        var pagos = await pagosServices.GetPagosConsultasPacientesAsync();
                        var pagos1 = pagos.Select(p => new
                        {
                            p.Id,
                            p.Monto,
                            p.MetodoPago,
                            p.FechaPago,
                            p.Consulta.Fecha,
                            p.Consulta.Paciente.Nombre,
                            p.Consulta.Paciente.Apellido
                        });
                        worksheet.Cells[1, 1].Value = "Numero de Facturacion";
                        worksheet.Cells[1, 2].Value = "Nombre";
                        worksheet.Cells[1, 3].Value = "Apellido";
                        worksheet.Cells[1, 4].Value = "Monto";
                        worksheet.Cells[1, 5].Value = "Método de Pago";
                        worksheet.Cells[1, 6].Value = "Fecha de Pago";
                        worksheet.Cells[1, 7].Value = "Fecha de Consulta";
                        foreach (var pago in pagos1)
                        {
                            worksheet.Cells[row, 1].Value = pago.Id;
                            worksheet.Cells[row, 2].Value = pago.Nombre;
                            worksheet.Cells[row, 3].Value = pago.Apellido;
                            worksheet.Cells[row, 4].Value = pago.Monto;
                            worksheet.Cells[row, 5].Value = pago.MetodoPago;
                            worksheet.Cells[row, 6].Value = pago.FechaPago;
                            worksheet.Cells[row, 7].Value = pago.Fecha;
                            row++;
                        }
                        break;

                    default:
                        throw new System.ArgumentException("Tipo de exportación no soportado");
                }

                var fileInfo = new FileInfo(rutaArchivo);
                package.SaveAs(fileInfo);
            }

        }
    }
}
