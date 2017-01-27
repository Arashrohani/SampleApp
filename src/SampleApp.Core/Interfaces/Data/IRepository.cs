using SampleApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SampleApp.Core.Interfaces.Data
{
    public interface IRepository
    {
    }
   
    public interface IRepository<T> : IRepository
       where T : BaseEntity, new()
    {
        IQueryable<T> Table { get; }

        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetSingleAsync(long id);

        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        Task<T> AddAsync(T entity);

        Task AddAsync(IEnumerable<T> entities);

        Task<T> UpdateAsync(T entity);

        Task UpdateAsync(IEnumerable<T> entities);

        Task DeleteAsync(T entity);

        Task DeleteAsync(IEnumerable<T> entities);

        Task<List<T>> ExecuteQueryAsync(string sql, params object[] parameters);

        Task<int> ExecuteNonQueryAsync(string sql, params object[] parameters);
    }
}
