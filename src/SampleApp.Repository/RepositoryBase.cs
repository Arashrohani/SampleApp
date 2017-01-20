using System;
using System.Collections.Generic;
using System.Linq;
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
    
        public async virtual Task Add(IEnumerable<T> entities)
        {
            await this.DbSet.AddRangeAsync(entities);

            await _context.SaveChangesAsync();
        }

        public async virtual Task<T> Add(T entity)
        {
            await this.DbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task Delete(IEnumerable<T> entities)
        {
            this.DbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async virtual Task Delete(T entity)
        {
            this.DbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async virtual Task<T> GetById(long id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public async virtual Task Update(IEnumerable<T> entities)
        {
            this.DbSet.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }

        public async virtual Task<T> Update(T entity)
        {
            this.DbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
