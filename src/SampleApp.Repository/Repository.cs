﻿using SampleApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public class Repository<T> : RepositoryBase<T, SampleContext>
        where T : BaseEntity, new()
    {
    }
}
