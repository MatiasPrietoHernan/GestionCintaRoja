using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CapaDatos.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly AppDbContext _context;

        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllasync()
        {
            // Utilizamos AsNoTracking para operaciones de solo lectura
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            // Buscamos la entidad sin seguimiento para evitar conflictos al modificar
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            var existingEntity = await _dbSet.FindAsync(entity.Id);
            if (existingEntity != null)
            {
                // Copiamos los valores actualizados a la entidad rastreada
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"No se encontró la entidad con Id {entity.Id} para actualizar, culiao.");
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"No se encontró la entidad con Id {id} para eliminar, petiso.");
            }

            //public async Task DeleteAsync(int id)
            //{
            //    var entity = await GetByIdAsync(id);
            //    _dbSet.Remove(entity);
            //    await _context.SaveChangesAsync();
            //}
        }
    }
}
