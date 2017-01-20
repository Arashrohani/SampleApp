using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public T GetRepository<T>() where T : IRepository
        {
            throw new NotImplementedException();
        }
    }
}
