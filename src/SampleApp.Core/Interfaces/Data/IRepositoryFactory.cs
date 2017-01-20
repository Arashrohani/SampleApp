using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Core.Interfaces.Data
{
    public interface IRepositoryFactory
    {
        T GetRepository<T>() where T : IRepository;
    }
}
