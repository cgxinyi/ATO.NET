using ATO.net.Models;
using ATO.net.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ATO.net.Controllers.api
{
    public class EmployeeController : ApiController
    {
        private EmployeeService empService = new EmployeeService();

        [Route("api/postpayslip")]
        [System.Web.Http.HttpPost]
        //Post api/employee
        public List<Employee> Post([FromBody] List<Employee> employee)
        {
            return this.empService.InsertEmployee(employee);
        }

    }
}