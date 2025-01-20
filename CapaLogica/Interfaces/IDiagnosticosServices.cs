using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaLogica.Interfaces
{
    public interface IDiagnosticosServices
    {
        public Task<IEnumerable<Diagnosticos>> GetDiagnosticosAsync();
        public Task<Diagnosticos> GetDiagnosticoAsync(int id);
        public Task AddDiagnosticoAsync(Diagnosticos diagnostico);
        public Task UpdateDiagnosticoAsync(Diagnosticos diagnostico);
        public Task DeleteDiagnosticoAsync(int id);
    }
}
