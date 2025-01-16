using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Consultas
    {
        public int Id { get; set; }
        public int idPaciente { get; set; }
        public Pacientes Paciente { get; set; }
        public string Fecha { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
        public ICollection<Pagos> Pagos { get; set; }
        public ICollection<Tratamientos> Tratamientos { get; set; }
        public Diagnosticos Diagnostico { get; set; }

    }
}
