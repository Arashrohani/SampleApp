using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleApp.Core.Entities;
using SampleApp.Core.Interfaces.Data;

namespace SampleApp.Repository
{
    public class RepositoryBase<T, U> : IRepository<T>
        where T : BaseEntity, new()
        where U : DbContext, new()
    {
        private readonly DbContext _context;
        private DbSet<T> _dbset;

        public RepositoryBase()
        {
            _context = new U();
        }

        protected DbSet<T> DbSet
        {
            get
            {
                if (_dbset == null)
                {
                    _dbset = _context.Set<T>();
                }
                return _dbset as DbSet<T>;
            }
        }

        public IQueryable<T> Table => this.DbSet;

        #region Sample Functions

        public async virtual Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }

        public async virtual Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync(predicate);
        }

        public async virtual Task<T> GetSingleAsync(long id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public async virtual Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        #endregion

        public async virtual Task AddAsync(IEnumerable<T> entities)
        {
            await this.DbSet.AddRangeAsync(entities);

            await _context.SaveChangesAsync();
        }

        public async virtual Task<T> AddAsync(T entity)
        {
            await this.DbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task UpdateAsync(IEnumerable<T> entities)
        {
            this.DbSet.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }

        public async virtual Task<T> UpdateAsync(T entity)
        {
            this.DbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task DeleteAsync(IEnumerable<T> entities)
        {
            this.DbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async virtual Task DeleteAsync(T entity)
        {
            this.DbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async virtual Task<List<T>> ExecuteQueryAsync(string sql, params object[] parameters)
        {
            return await this.DbSet.FromSql<T>(sql, parameters).ToListAsync<T>();
        }

        public async virtual Task<int> ExecuteNonQueryAsync(string sql, params object[] parameters)
        {
            return await _context.Database.ExecuteSqlCommandAsync(sql, parameters: parameters);
        }

    }
}
