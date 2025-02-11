using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;

namespace CapaDatos.Models
{
    public class HistorialConsultas : IEntity
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public Pacientes Paciente { get; set; }
        public int IdConsultas { get; set; }
        public Consultas Consulta { get; set; }
        public string FechaHistorial { get; set; }
        public string Detalles { get; set; }
    }
}
