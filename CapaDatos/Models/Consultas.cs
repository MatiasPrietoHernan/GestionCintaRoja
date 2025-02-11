using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;

namespace CapaDatos.Models
{
    public class Consultas : IEntity
    {
        public int Id { get; set; }
        public int idPaciente { get; set; }
        public Pacientes Paciente { get; set; }
        public string Fecha { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
        public ICollection<Pagos> Pagos { get; set; }
        public ICollection<Tratamientos> Tratamientos { get; set; }
        public ICollection<Diagnosticos> Diagnosticos { get; set; }  // Aquí cambia la relación de uno a uno a uno a muchos


    }
}
