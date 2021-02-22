using MISA.Common.Models;
using MISA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MISA.DataLayer.Interfaces;
using MISA.DataLayer.Interface;

namespace MISA.Service
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        #region DECLARE
        #endregion
        #region CONTRUCTOR
        public EmployeeService(IEmployeeRepository<Employee> employeeRepository) : base(employeeRepository)
        {

        }
        #endregion
        #region METHOD
        #endregion
    }
}
