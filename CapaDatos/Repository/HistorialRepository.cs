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
    public class HistorialRepository : IGenericRelations<HistorialConsultas>
    {
        private readonly AppDbContext _context;

        public HistorialRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HistorialConsultas>> GetAllRelationsAsync()
        {
            return await _context.HistorialConsultas.Include(p => p.Paciente)
                                           .Include(c => c.Consulta)
                                           .ToListAsync();
        }
    }
}
