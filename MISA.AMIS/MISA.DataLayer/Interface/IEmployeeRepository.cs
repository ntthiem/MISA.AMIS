using MISA.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.Interface
{
    public interface IEmployeeRepository<TEntity> : IDbContext<TEntity>
    {
    }
}
