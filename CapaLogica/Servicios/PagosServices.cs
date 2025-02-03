using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;
using CapaDatos.Models;
using CapaLogica.Interfaces;

namespace CapaLogica.Servicios
{
    public class PagosServices : IPagosServices
    {
        private readonly IGenericRelations<Pagos> genericRelations;
        private readonly IGenericRepository<Pagos> genericRepository;
        private readonly IPagosRepository pagosRepository;

        public PagosServices(IGenericRelations<Pagos> genericRelations, IGenericRepository<Pagos> genericRepository, IPagosRepository pagosRepository)
        {
            this.genericRelations = genericRelations;
            this.genericRepository = genericRepository;
            this.pagosRepository = pagosRepository;
        }

        public async Task<IEnumerable<Pagos>> GetPagosAsync()
        {
            return await genericRepository.GetAllasync();
        }

        public async Task<Pagos> GetPagoAsync(int id)
        {
            return await genericRepository.GetByIdAsync(id);
        }

        public async Task AddPagoAsync(Pagos pago)
        {
            await genericRepository.AddAsync(pago);
        }

        public async Task UpdatePagoAsync(Pagos pago)
        {
            await genericRepository.UpdateAsync(pago);
        }

        public async Task DeletePagoAsync(int id)
        {
            await genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Pagos>> GetPagosWithRealtionsAsync()
        {
            return await genericRelations.GetAllRelationsAsync();
        }

        public async Task<IEnumerable<Pagos>> GetPagosPacientesAsync(int id)
        {
            return await pagosRepository.GetPagosPacientesAsync(id);
        }
        
        public async Task<IEnumerable<Pagos>> GetPagosConsultasPacientesAsync()
        {
            return await pagosRepository.GetAllPagosAsync();
        }
        public async Task<Pagos> GetPagoWithRelationsAsync(int id)
        {
            return await pagosRepository.GetPagoRelationsAsync(id);
        }

        public async Task<IEnumerable<Pagos>> SearchPagosAsync(string term)
        {
            return await pagosRepository.SearchPagosAsync(term);
        }

    }
}
