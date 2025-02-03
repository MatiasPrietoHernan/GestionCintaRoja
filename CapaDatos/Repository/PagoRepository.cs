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
    public class PagoRepository : IGenericRelations<Pagos>, IPagosRepository
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

        public async Task<IEnumerable<Pagos>> GetPagosPacientesAsync(int id)
        {
            return await _context.Pagos.Include(c => c.Consulta).Where(p => p.Consulta.idPaciente == id).ToListAsync();
        }
        public async Task<IEnumerable<Pagos>> GetAllPagosAsync()
        {
            return await _context.Pagos.Include(c => c.Consulta).ThenInclude(p=> p.Paciente).ToListAsync();
        }
        public async Task<Pagos> GetPagoRelationsAsync(int id)
        {
            return await _context.Pagos.Include(c => c.Consulta).ThenInclude(p => p.Paciente).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Pagos>> SearchPagosAsync(string term)
        {
            return await _context.Pagos.Include(c => c.Consulta).ThenInclude(p => p.Paciente).Where(p => p.Consulta.Paciente.Nombre.ToLower().Contains(term) || p.Consulta.Paciente.Apellido.ToLower().Contains(term) || p.Id.ToString().Contains(term)).ToListAsync();
        }
    }
}
