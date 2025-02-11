using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;

namespace CapaDatos.Models
{
    public class Pagos : IEntity
    {
        public int Id { get; set; }
        public int IdConsulta { get; set; }
        public Consultas Consulta { get; set; }
        public string FechaPago { get; set; }
        public double Monto { get; set; }
        public string MetodoPago { get; set; }
    }
}
