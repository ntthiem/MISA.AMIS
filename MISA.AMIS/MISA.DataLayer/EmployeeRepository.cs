﻿using MISA.DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer
{
    public class EmployeeRepository<Employee> : DbContext<Employee>, IEmployeeRepository<Employee>
    {
    }
}
