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
    public class ConsultasServices : IConsultasServices
    {
        private readonly IGenericRepository<Consultas> _genericRepository;

        private readonly IGenericRelations<Consultas> _genericRelations;

        private readonly IConsultasRepository consultasRepository;

        public ConsultasServices(IGenericRelations<Consultas> genericRelations, IGenericRepository<Consultas> genericRepository, IConsultasRepository consultasRepository)
        {
            _genericRelations = genericRelations;
            _genericRepository = genericRepository;
            this.consultasRepository = consultasRepository;
        }

        public async Task<IEnumerable<Consultas>> GetConsultasAsync()
        {
            return await _genericRepository.GetAllasync();
        }

        public async Task<Consultas> GetConsultaAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task AddConsultaAsync(Consultas consulta)
        {
            await _genericRepository.AddAsync(consulta);
        }

        public async Task UpdateConsultaAsync(Consultas consulta)
        {
            await _genericRepository.UpdateAsync(consulta);
        }

        public async Task DeleteConsultaAsync(int id)
        {
            await _genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Consultas>> GetConsultasWithRealtiosnAsync()
        {
            return await _genericRelations.GetAllRelationsAsync();
        }

        public async Task<IEnumerable<Consultas>> SearchByTerm(string term)
        {
            return await consultasRepository.SearchByTermAsync(term);
        }

    }
}
