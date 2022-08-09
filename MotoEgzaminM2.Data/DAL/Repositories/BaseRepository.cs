using Microsoft.EntityFrameworkCore;
using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.DAL.Interfaces;

namespace MotoEgzaminM2.Data.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly MotoEgzaminM2Context _context;

        public BaseRepository(MotoEgzaminM2Context context)
        {
            _context = context;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            var addedElement = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return addedElement.Entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
