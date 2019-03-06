using Employees.Core.Dtos;
using System.Collections.Generic;

namespace Employees.Core.Contracts
{
    public interface IEmployeesUtility
    {
        IEnumerable<EmployeeApi> GetEmployeesApi();
    }
}
