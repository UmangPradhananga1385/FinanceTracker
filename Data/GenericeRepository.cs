using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Windowing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMoneyTracker.Data
{
    public class GenericeRepository<TEntity> where TEntity : class
    {
        private readonly PersonalMoneyTracketDbContext _context;
        private DbSet<TEntity> _entity;
        public GenericeRepository( PersonalMoneyTracketDbContext context, DbSet<TEntity> entity)
        {
            _context = context;
            _entity = entity;
        }
        public IQueryable<TEntity> Table => _entity.AsQueryable();
        public IQueryable<TEntity> TableNoTracking => _entity.AsNoTracking().AsQueryable();
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _entity.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

        }
        public async Task UpdateRange(IEnumerable<TEntity> entities)
        {
            _entity.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public async void Delete(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async void DeleteRange(IEnumerable<TEntity> entities)
        {
            _entity.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _entity.FindAsync(id);
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

    }
}
