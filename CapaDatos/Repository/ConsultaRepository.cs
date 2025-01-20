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
    public class ConsultaRepository : IGenericRelations<Consultas>
    {
        private readonly AppDbContext _context;

        public ConsultaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Consultas>> GetAllRelationsAsync()
        {
            return await _context.Consultas.Include(d=> d.Diagnostico)
                .Include(t=> t.Tratamientos).Include(p=> p.Pagos).Include(pa=> pa.Paciente).ToListAsync();
        }
    }
}
