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
    public class TratamientosServices : ITratamientosServices
    {

        private readonly IGenericRelations<Tratamientos> genericRelations;
        private readonly IGenericRepository<Tratamientos> genericRepository;
        private readonly ITratamientosRepository tratamientosRepository;

        public TratamientosServices(IGenericRelations<Tratamientos> genericRelations, IGenericRepository<Tratamientos> genericRepository, ITratamientosRepository tratamientosRepository)
        {
            this.genericRelations = genericRelations;
            this.genericRepository = genericRepository;
            this.tratamientosRepository = tratamientosRepository;
        }

        public async Task<IEnumerable<Tratamientos>> GetTratamientosAsync()
        {
            return await genericRepository.GetAllasync();
        }

        public async Task<Tratamientos> GetTratamientoAsync(int id)
        {
            return await genericRepository.GetByIdAsync(id);
        }

        public async Task AddTratamientoAsync(Tratamientos tratamiento)
        {
            await genericRepository.AddAsync(tratamiento);
        }

        public async Task UpdateTratamientoAsync(Tratamientos tratamiento)
        {
            await genericRepository.UpdateAsync(tratamiento);
        }

        public async Task DeleteTratamientoAsync(int id)
        {
            await genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Tratamientos>> GetTratamientosWithRealtiosnAsync()
        {
            return await genericRelations.GetAllRelationsAsync();
        }

        public async Task<IEnumerable<Tratamientos>> SearchByTermAsync(string term)
        {
            return await tratamientosRepository.SearchByTermAsync(term);
        }
        public async Task<IEnumerable<Tratamientos>> GetTratamientosPacientesAsync(int id)
        {
            return await tratamientosRepository.GetTratamientosPacientes(id);
        }
    }
}
