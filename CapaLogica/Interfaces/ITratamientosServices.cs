using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaLogica.Interfaces
{
    public interface ITratamientosServices
    {
       public Task<IEnumerable<Tratamientos>> GetTratamientosAsync();
        public Task<Tratamientos> GetTratamientoAsync(int id);
        public Task AddTratamientoAsync(Tratamientos tratamiento);
        public Task UpdateTratamientoAsync(Tratamientos tratamiento);
        public Task DeleteTratamientoAsync(int id);
        public Task<IEnumerable<Tratamientos>> GetTratamientosWithRealtiosnAsync();
    }
}
