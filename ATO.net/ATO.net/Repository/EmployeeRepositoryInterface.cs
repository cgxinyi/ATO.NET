using ATO.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO.net.Repository
{
    interface EmployeeRepositoryInterface
    {
        List<Employee> InsertEmployee(List<Employee> employee);
    }
}
