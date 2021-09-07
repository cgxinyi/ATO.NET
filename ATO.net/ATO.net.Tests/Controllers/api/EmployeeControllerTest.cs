using ATO.net.Controllers.api;
using ATO.net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ATO.net.Tests.Controllers.api
{
    [TestClass]
    public class EmployeeControllerTest
    {
        EmployeeController employeeController = new EmployeeController();
        [TestMethod]
        public void TestPostMethod()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee("123","123",3654.23,5,1,null);
            
            List<Employee> actionResult = employeeController.Post(employees);
            
            Assert.IsNotNull(actionResult);
        }
    }
}
