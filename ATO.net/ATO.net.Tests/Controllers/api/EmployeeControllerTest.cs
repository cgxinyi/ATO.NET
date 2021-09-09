using ATO.net.Controllers.api;
using ATO.net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace ATO.net.Tests.Controllers.api
{
    [TestClass]
    public class EmployeeControllerTest
    {
        EmployeeController employeeController = new EmployeeController();
        [TestMethod]
        public void TestPostMethod()
        {
            employeeController.Request = new HttpRequestMessage();
            employeeController.Configuration = new HttpConfiguration();
            string locationUrl = "http://location/";
            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            employeeController.Url = mockUrlHelper.Object;

            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee("123","123",3654.23,5,1,null);
            employees.Add(employee);
            List<Employee> actionResult = employeeController.Post(employees);
            
            Assert.IsNotNull(actionResult);
        }
    }
}
