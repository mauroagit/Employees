using Employees.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employees.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeesRepository repository;

        public EmployeesController(IEmployeesRepository repository)
        {
            this.repository = repository;
        }

        public IHttpActionResult Get()
        {
            var employees = this.repository.GetEmployees();
            return Ok(employees);
        }

        public IHttpActionResult Get(int id)
        {
            var employee = this.repository.GetEmployee(id);
            return Ok(employee);
        }
    }
}
