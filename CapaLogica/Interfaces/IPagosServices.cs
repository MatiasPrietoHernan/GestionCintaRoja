using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaLogica.Interfaces
{
    public interface IPagosServices
    {
        public Task<IEnumerable<Pagos>> GetPagosAsync();
        public Task<Pagos> GetPagoAsync(int id);
        public Task AddPagoAsync(Pagos pago);
        public Task UpdatePagoAsync(Pagos pago);
        public Task DeletePagoAsync(int id);
        public Task<IEnumerable<Pagos>> GetPagosWithRealtionsAsync();
        public Task<IEnumerable<Pagos>> GetPagosPacientesAsync(int id);
        public Task<IEnumerable<Pagos>> GetPagosConsultasPacientesAsync();
        public Task<Pagos> GetPagoWithRelationsAsync(int id);
        public Task<IEnumerable<Pagos>> SearchPagosAsync(string term);
    }
}
