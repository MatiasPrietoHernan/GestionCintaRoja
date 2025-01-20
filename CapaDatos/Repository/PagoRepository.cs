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
    public class PagoRepository : IGenericRelations<Pagos>
    {
        private readonly AppDbContext _context;

        public PagoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pagos>> GetAllRelationsAsync()
        {
            return await _context.Pagos.Include(c=> c.Consulta).ToListAsync();
        }
    }
}
