using Employees.Core.Dtos;
using System.Collections.Generic;

namespace Employees.Core.Contracts
{
    public interface IEmployeesRepository
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployee(int id);
    }
}
