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
    public class HistorialServices : IHistorialServices
    {
        private readonly IGenericRepository<HistorialConsultas> genericRepository;

        private readonly IGenericRelations<HistorialConsultas> genericRelations;

        public HistorialServices(IGenericRepository<HistorialConsultas> genericRepository, IGenericRelations<HistorialConsultas> genericRelations)
        {
            this.genericRepository = genericRepository;
            this.genericRelations = genericRelations;
        }

        public async Task AddHistorialAsync(HistorialConsultas historial)
        {
            await genericRepository.AddAsync(historial);
        }

        public async Task DeleteHistorialAsync(int id)
        {
            await genericRepository.DeleteAsync(id);
        }

        public async Task<HistorialConsultas> GetHistorialAsync(int id)
        {
            return await genericRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<HistorialConsultas>> GetHistorialesAsync()
        {
            return await genericRepository.GetAllasync();
        }

        public async Task<IEnumerable<HistorialConsultas>> GetHistorialRelationsAsync()
        {
            return await genericRelations.GetAllRelationsAsync();
        }

        public async Task UpdateHistorialAsync(HistorialConsultas historial)
        {
            await genericRepository.UpdateAsync(historial);
        }
    }
}
