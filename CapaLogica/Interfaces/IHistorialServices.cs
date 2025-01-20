using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaLogica.Interfaces
{
    public interface IHistorialServices
    {
        public Task<HistorialConsultas> GetHistorialAsync(int id);
        public Task<IEnumerable<HistorialConsultas>> GetHistorialesAsync();
        public Task AddHistorialAsync(HistorialConsultas historial);
        public Task UpdateHistorialAsync(HistorialConsultas historial);
        public Task DeleteHistorialAsync(int id);
        public Task<IEnumerable<HistorialConsultas>> GetHistorialRelationsAsync();
    }
}
