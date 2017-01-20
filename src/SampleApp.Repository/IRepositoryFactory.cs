using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public interface IRepositoryFactory
    {
        T GetRepository<T>() where T : IRepository;
    }
}
