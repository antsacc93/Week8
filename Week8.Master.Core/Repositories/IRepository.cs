﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Master.Core.Repositories
{
    public interface IRepository<T>
    {
        public ICollection<T> GetAll();
    }
}
