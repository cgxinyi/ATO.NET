using ATO.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO.net.Service
{
    
    interface EmployeeServiceInterface
    {
        List<Taxthreshold> LoadTaxthreshold();
        Double CalculateIncomeTax(Double grossIncome);
        List<Employee> InsertEmployee(List<Employee> employee);

    }
}
