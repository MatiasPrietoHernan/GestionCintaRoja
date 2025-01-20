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
    public class TratamientosRepository : IGenericRelations<Tratamientos>
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
    }
}
