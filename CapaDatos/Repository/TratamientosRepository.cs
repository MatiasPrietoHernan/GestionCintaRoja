using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;
using CapaDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace CapaDatos.Repository
{
    public class TratamientosRepository : IGenericRelations<Tratamientos>, ITratamientosRepository
    {
        private readonly AppDbContext _context;

        public TratamientosRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Tratamientos>> GetAllRelationsAsync()
        {
            return await _context.Tratamientos.Include(x => x.Consulta).Include(x => x.Paciente).ToListAsync();
        }

        public async Task<IEnumerable<Tratamientos>> SearchByTermAsync(string term)
        {
            return await _context.Tratamientos
             .Include(x => x.Paciente)
             .Where(x => EF.Functions.Like(x.NombreTratamiento, $"%{term}%") ||
                         (x.Paciente != null && (EF.Functions.Like(x.Paciente.Nombre, $"%{term}%") ||
                                                 EF.Functions.Like(x.Paciente.Apellido, $"%{term}%"))))
             .ToListAsync();

        }
        public async Task<IEnumerable<Tratamientos>> GetTratamientosPacientes(int id)
        {
            return await _context.Tratamientos
                .Include(x => x.Paciente)
                .Where(x => x.IdPaciente == id)
                .ToListAsync();
        }
    }
}
