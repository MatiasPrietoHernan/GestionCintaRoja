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
    public class PacienteRepository : IGenericRelations<Pacientes>
    {
        private readonly AppDbContext _context;

        public PacienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pacientes>> GetAllRelationsAsync()
        {
            return await _context.Pacientes.Include(p => p.Consulta)
                                           .Include(p => p.HistorialConsultas)
                                           .ToListAsync();
        }
    }
}
