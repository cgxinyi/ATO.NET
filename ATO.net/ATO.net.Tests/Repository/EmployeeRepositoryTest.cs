using ATO.net.Models;
using ATO.net.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace ATO.net.Tests.Repository
{
    [TestClass]
    public class EmployeeRepositoryTest
    {

        EmployeeRepository employeeRepository = new EmployeeRepository();
        [TestMethod]
        public void TestInsertEmployee()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("test", "test1", 123, 1, 1, null));
            List<Employee> result = employeeRepository.InsertEmployee(employees);
            Assert.AreEqual(employees.ToString(),result.ToString());
        }

        
    }
}
