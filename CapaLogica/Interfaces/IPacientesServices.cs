using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaLogica.Interfaces
{
    public interface IPacientesServices
    {
        public Task<IEnumerable<Pacientes>> GetPacientesAsync();
        public Task<Pacientes> GetPacienteAsync(int id);
        public Task AddPacienteAsync(Pacientes paciente);
        public Task UpdatePacienteAsync(Pacientes paciente);
        public Task DeletePacienteAsync(int id);
        public Task<IEnumerable<Pacientes>> GetPacientesWithRealtionsAsync();
        public Task<IEnumerable<Pacientes>> SearchPaciente(string term);
    }
}
