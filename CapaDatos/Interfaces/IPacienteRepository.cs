using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaDatos.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Pacientes>> SearchTermAsync(string term);
    }
}
