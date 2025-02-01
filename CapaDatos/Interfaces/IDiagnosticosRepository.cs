using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaDatos.Interfaces
{
    public interface IDiagnosticosRepository
    {
        Task<IEnumerable<Diagnosticos>> SearchByTermAsync(string term);
        Task<IEnumerable<Diagnosticos>> GetDiagnosticosPacientes(int id);
    }
}
