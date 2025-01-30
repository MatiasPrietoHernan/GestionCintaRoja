using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CapaDatos.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
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
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            //Al usar esto EF no sigue al objeto cuando lo trae.
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            var existingEntity = await _dbSet.FindAsync(GetId(entity));

            if (existingEntity != null)
            {
                // Copiar valores a la entidad rastreada
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            }
            else
            {
                // Adjuntar y marcar como modificado
                _dbSet.Update(entity);
            }

            await _context.SaveChangesAsync();
        }

        private int GetId(T entity)
        {
            return (int)entity.GetType().GetProperty("Id").GetValue(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
