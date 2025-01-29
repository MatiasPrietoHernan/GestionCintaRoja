using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;
using CapaLogica.Interfaces;
using CapaDatos.Models;

namespace CapaLogica.Servicios
{
    public class PacientesServices : IPacientesServices
    {
        private readonly IGenericRepository<Pacientes> _repository;

        private readonly IGenericRelations<Pacientes> genericRelations;

        public PacientesServices(IGenericRepository<Pacientes> repository, IGenericRelations<Pacientes> genericRelations)
        {
            _repository = repository;
            this.genericRelations = genericRelations;
        }

        public async Task<IEnumerable<Pacientes>> GetPacientesAsync()
        {
            return await _repository.GetAllasync();
        }

        public async Task<Pacientes> GetPacienteAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddPacienteAsync(Pacientes paciente)
        {
            await _repository.AddAsync(paciente);
        }

        public async Task UpdatePacienteAsync(Pacientes paciente)
        {
            await _repository.UpdateAsync(paciente);
        }

        public async Task DeletePacienteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Pacientes>> GetPacientesWithRealtionsAsync()
        {
            return await genericRelations.GetAllRelationsAsync();
        }

        public async Task<IEnumerable<Pacientes>> SearchPaciente(string term)
        {
            return await genericRelations.SearchTermAsync(term);
        }

    }
}
