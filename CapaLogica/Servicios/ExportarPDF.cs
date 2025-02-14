using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaLogica.Interfaces;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CapaLogica.Servicios
{
    public class ExportarPDF : IExportarPDF
    {
        private readonly IPacientesServices pacientesServices;
        private readonly IConsultasServices consultasServices;
        private readonly IDiagnosticosServices diagnosticosServices;
        private readonly ITratamientosServices tratamientosServices;
        private readonly IPagosServices pagosServices;

        public ExportarPDF(
            IPacientesServices pacientesServices,
            IConsultasServices consultasServices,
            IDiagnosticosServices diagnosticosServices,
            ITratamientosServices tratamientosServices,
            IPagosServices pagosServices)
        {
            this.pacientesServices = pacientesServices;
            this.consultasServices = consultasServices;
            this.diagnosticosServices = diagnosticosServices;
            this.tratamientosServices = tratamientosServices;
            this.pagosServices = pagosServices;
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
        }

        public async Task ExportarAPdf(string tabla, string rutaArchivo)
        {
            try
            {
                // Obtenemos encabezados y datos dinámicamente
                (List<string> headers, List<List<string>> data) = await ObtenerDatos(tabla);

                // Creamos un documento dinámico usando QuestPDF
                var documento = new DynamicPdfDocument($"Datos de {tabla}", headers, data);

                // Generamos el PDF en la ruta indicada
                documento.GeneratePdf(rutaArchivo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al exportar PDF: {ex.Message}", ex);
            }
        }

        private async Task<(List<string> headers, List<List<string>> data)> ObtenerDatos(string tabla)
        {
            switch (tabla)
            {
                case "Pacientes":
                    var pacientes = await pacientesServices.GetPacientesAsync();
                    var headersPacientes = new List<string> {
                        "ID", "Nombre", "Apellido", "DNI", "Edad",
                        "Email", "Tipo de Sangre", "Dirección", "Teléfono", "Fecha de Nacimiento"
                    };

                    var dataPacientes = pacientes.Select(p => new List<string>
                    {
                        p.Id.ToString(),
                        p.Nombre ?? "",
                        p.Apellido ?? "",
                        p.DNI.ToString(),
                        p.Edad.ToString(),
                        p.Email ?? "",
                        p.TipoSangre ?? "",
                        p.Direccion ?? "",
                        p.Telefono ?? "",
                        p.FechaNacimiento != null ? p.FechaNacimiento.ToString("dd/MM/yyyy") : ""
                    }).ToList();

                    return (headersPacientes, dataPacientes);

                case "Consultas":
                    var consultas = await consultasServices.GetConsultasWithRealtiosnAsync();
                    var headersConsultas = new List<string> {
                        "ID", "Paciente", "Fecha", "Motivo", "Observaciones"
                    };

                    var dataConsultas = consultas.Select(c =>
                    {
                        string nombrePaciente = c.Paciente != null
                            ? $"{c.Paciente.Nombre ?? ""} {c.Paciente.Apellido ?? ""}"
                            : "";
                        string fecha = c.Fecha != null
                            ? c.Fecha.ToString()
                            : "";
                        return new List<string>
                        {
                            c.Id.ToString(),
                            nombrePaciente,
                            fecha,
                            c.Motivo ?? "",
                            c.Observaciones ?? ""
                        };
                    }).ToList();

                    return (headersConsultas, dataConsultas);

                case "Diagnosticos":
                    var diagnosticos = await diagnosticosServices.GetAllRelationsAsync();
                    var headersDiagnosticos = new List<string> {
                        "ID", "Paciente", "Fecha de Consulta", "Descripción de Diagnóstico", "Fecha de Diagnóstico"
                    };

                    var dataDiagnosticos = diagnosticos.Select(d =>
                    {
                        string nombrePaciente = d.Consulta != null && d.Consulta.Paciente != null
                            ? $"{d.Consulta.Paciente.Nombre ?? ""} {d.Consulta.Paciente.Apellido ?? ""}"
                            : "";
                        string fechaConsulta = d.Consulta != null && d.Consulta.Fecha != null
                            ? d.Consulta.Fecha.ToString()
                            : "";
                        string fechaDiagnostico = d.FechaDiagnostico != null
                            ? d.FechaDiagnostico.ToString("dd/MM/yyyy")
                            : "";
                        return new List<string>
                        {
                            d.Id.ToString(),
                            nombrePaciente,
                            fechaConsulta,
                            d.Descripcion ?? "",
                            fechaDiagnostico
                        };
                    }).ToList();

                    return (headersDiagnosticos, dataDiagnosticos);

                case "Tratamientos":
                    var tratamientos = await tratamientosServices.GetTratamientosWithRealtiosnAsync();
                    var headersTratamientos = new List<string> {
                        "ID", "Paciente", "Nombre del Tratamiento", "Detalles del tratamiento", "Fecha de inicio", "Fecha de finalización"
                    };

                    var dataTratamientos = tratamientos.Select(t =>
                    {
                        string nombrePaciente = t.Paciente != null
                            ? $"{t.Paciente.Nombre ?? ""} {t.Paciente.Apellido ?? ""}"
                            : "";
                        string fechaInicio = t.FechaInicio != null
                            ? t.FechaInicio.ToString("dd/MM/yyyy")
                            : "";
                        string fechaFin = t.FechaFin != null
                            ? t.FechaFin.ToString("dd/MM/yyyy")
                            : "";
                        return new List<string>
                        {
                            t.Id.ToString(),
                            nombrePaciente,
                            t.NombreTratamiento ?? "",
                            t.Detalles ?? "",
                            fechaInicio,
                            fechaFin
                        };
                    }).ToList();

                    return (headersTratamientos, dataTratamientos);

                case "Pagos":
                    var pagos = await pagosServices.GetPagosConsultasPacientesAsync();
                    var headersPagos = new List<string> {
                        "ID", "Paciente", "Fecha de Pago", "Fecha de Consulta", "Metodo de Pago", "Monto"
                    };

                    var dataPagos = pagos.Select(p =>
                    {
                        string nombrePaciente = p.Consulta != null && p.Consulta.Paciente != null
                            ? $"{p.Consulta.Paciente.Nombre ?? ""} {p.Consulta.Paciente.Apellido ?? ""}"
                            : "";
                        string fechaPago = p.FechaPago != null
                            ? p.FechaPago.ToString()
                            : "";
                        string fechaConsulta = p.Consulta != null && p.Consulta.Fecha != null
                            ? p.Consulta.Fecha.ToString()
                            : "";
                        return new List<string>
                        {
                            p.Id.ToString(),
                            nombrePaciente,
                            fechaPago,
                            fechaConsulta,
                            p.MetodoPago ?? "",
                            p.Monto.ToString()
                        };
                    }).ToList();

                    return (headersPagos, dataPagos);

                default:
                    throw new ArgumentException("Tabla no soportada para exportar.");
            }
        }
    }

    // Documento dinámico usando QuestPDF
    public class DynamicPdfDocument : IDocument
    {
        public string Title { get; }
        public List<string> Headers { get; }
        public List<List<string>> Data { get; }

        public DynamicPdfDocument(string title, List<string> headers, List<List<string>> data)
        {
            Title = title;
            Headers = headers;
            Data = data;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(20);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Content().Column(col =>
                {
                    // Título del documento
                    col.Item().Text(Title).FontSize(16).Bold().AlignCenter();

                    // Construcción de la tabla
                    col.Item().Table(table =>
                    {
                        // Definición de columnas (se ajustan de forma relativa)
                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < Headers.Count; i++)
                            {
                                columns.RelativeColumn();
                            }
                        });

                        // Fila de encabezados
                        table.Header(header =>
                        {
                            foreach (var headerText in Headers)
                            {
                                header.Cell()
                                    .Background(Colors.Grey.Lighten2)
                                    .Padding(5)
                                    .Text(headerText)
                                    .Bold()
                                    .AlignCenter();
                            }
                        });

                        // Filas de datos
                        foreach (var row in Data)
                        {
                            foreach (var cell in row)
                            {
                                table.Cell()
                                    .Padding(5)
                                    .Text(cell)
                                    .AlignLeft();
                            }
                        }
                    });
                });
            });
        }
    }
}
