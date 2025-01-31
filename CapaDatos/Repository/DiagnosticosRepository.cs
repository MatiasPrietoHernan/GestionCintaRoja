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
    public class DiagnosticosRepository : IGenericRelations<Diagnosticos>, IDiagnosticosRepository
    {
        private readonly AppDbContext _context;

        public DiagnosticosRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Diagnosticos>> GetAllRelationsAsync()
        {
            return await _context.Diagnosticos.Include(d => d.Consulta)
                                           .ToListAsync();
        }

        public async Task<IEnumerable<Diagnosticos>> SearchByTermAsync(string term)
        {
            return await _context.Diagnosticos.Include(d => d.Consulta)
                                           .Where(d => d.FechaDiagnostico.ToString().Contains(term))
                                           .ToListAsync();
        }
    }
}
