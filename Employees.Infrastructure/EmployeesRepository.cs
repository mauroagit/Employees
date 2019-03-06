using Employees.Core;
using Employees.Core.Contracts;
using Employees.Core.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Infrastructure
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private IEmployeesUtility employeesUtility;

        public EmployeesRepository(IEmployeesUtility employeesUtility)
        {
            this.employeesUtility = employeesUtility;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var result = new List<Employee>();

            var employeesApi = employeesUtility.GetEmployeesApi();
            foreach (var e in employeesApi)
            {
                var employee = EmployeesFactory.Get(e.ContractTypeName);
                employee.Id = e.Id;
                employee.HourlySalary = e.HourlySalary;
                employee.MonthlySalary = e.MonthlySalary;
                employee.Name = e.Name;
                employee.ContractTypeName = e.ContractTypeName;
                employee.RoleDescription = e.RoleDescription ?? string.Empty;
                employee.RoleId = e.RoleId;
                employee.RoleName = e.RoleName;

                result.Add(employee);
            }
            
            return result;
        }

        public Employee GetEmployee(int id)
        {
            var employeesApi = employeesUtility.GetEmployeesApi();
            var employeeQuery = employeesApi.Where(e => e.Id == id);
            if (employeeQuery.Any())
            {
                var first = employeeQuery.First();
                var employee = EmployeesFactory.Get(first.ContractTypeName);
                employee.Id = first.Id;
                employee.HourlySalary = first.HourlySalary;
                employee.MonthlySalary = first.MonthlySalary;
                employee.Name = first.Name;
                employee.ContractTypeName = first.ContractTypeName;
                employee.RoleDescription = first.RoleDescription ?? string.Empty;
                employee.RoleId = first.RoleId;
                employee.RoleName = first.RoleName;

                return employee;
            }

            return null;
        }
    }
}
