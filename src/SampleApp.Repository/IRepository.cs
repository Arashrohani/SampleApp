using SampleApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public interface IRepository
    {
    }
   
    public interface IRepository<T> : IRepository
       where T : BaseEntity, new()
    {
        IQueryable<T> Table { get; }

        Task<T> GetById(long id);

        Task<T> Add(T entity);

        Task Add(IEnumerable<T> entities);

        Task<T> Update(T entity);

        Task Update(IEnumerable<T> entities);

        Task Delete(T entity);

        Task Delete(IEnumerable<T> entities);
    }
}
