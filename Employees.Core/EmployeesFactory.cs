using Employees.Core.Dtos;

namespace Employees.Core
{
    public static class EmployeesFactory
    {
        public static Employee Get(string contractTypeName)
        {
            switch (contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return new HourlySalaryEmployee();
                default:
                    return new MonthlySalaryEmployee();
            }
        }
    }
}
