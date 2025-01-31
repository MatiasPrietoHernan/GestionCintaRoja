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
    public class DiagnosticosServices : IDiagnosticosServices
    {
        private readonly IGenericRepository<Diagnosticos> genericRepository;

        private readonly IGenericRelations<Diagnosticos> genericRelations;
        private readonly IDiagnosticosRepository diagnosticosRepository;

        public DiagnosticosServices(IGenericRepository<Diagnosticos> genericRepository, IGenericRelations<Diagnosticos> genericRelations, IDiagnosticosRepository diagnosticosRepository)
        {
            this.genericRepository = genericRepository;
            this.genericRelations = genericRelations;
            this.diagnosticosRepository = diagnosticosRepository;
        }

        public async Task<IEnumerable<Diagnosticos>> GetDiagnosticosAsync()
        {
            return await genericRepository.GetAllasync();
        }

        public async Task<Diagnosticos> GetDiagnosticoAsync(int id)
        {
            return await genericRepository.GetByIdAsync(id);
        }

        public async Task AddDiagnosticoAsync(Diagnosticos diagnostico)
        {
            await genericRepository.AddAsync(diagnostico);
        }

        public async Task UpdateDiagnosticoAsync(Diagnosticos diagnostico)
        {
            await genericRepository.UpdateAsync(diagnostico);
        }

        public async Task DeleteDiagnosticoAsync(int id)
        {
            await genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Diagnosticos>> GetAllRelationsAsync()
        {
            return await genericRelations.GetAllRelationsAsync();
        }
        public async Task<IEnumerable<Diagnosticos>> SearchByTermAsync(string term)
        {
            return await diagnosticosRepository.SearchByTermAsync(term);
        }
    }
}
