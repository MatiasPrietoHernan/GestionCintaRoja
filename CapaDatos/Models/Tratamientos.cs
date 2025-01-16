using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Tratamientos
    {
        public int Id { get; set; }
        public string NombreTratamiento { get; set; }
        //Los coso con el signo de pregunta significa que son opcionales, es decir, pueden ser nulos
        public int? IdConsulta { get; set; }
        public Consultas Consulta { get; set; }

        public int? IdPaciente { get; set; }
        public Pacientes Paciente { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Detalles { get; set; }
    }
}
