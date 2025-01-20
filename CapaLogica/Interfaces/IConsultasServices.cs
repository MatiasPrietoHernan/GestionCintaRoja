using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaLogica.Interfaces
{
    public interface IConsultasServices
    {
        public Task<IEnumerable<Consultas>> GetConsultasAsync();
        public Task<Consultas> GetConsultaAsync(int id);
        public Task AddConsultaAsync(Consultas consulta);
        public Task UpdateConsultaAsync(Consultas consulta);
        public Task DeleteConsultaAsync(int id);
        public Task<IEnumerable<Consultas>> GetConsultasWithRealtiosnAsync();
    }
}
