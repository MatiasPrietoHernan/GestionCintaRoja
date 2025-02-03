using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentación.DTO
{
    public class ConsultasDTO
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha { get; set; }
        public string Motivo { get; set; }
    }
}
