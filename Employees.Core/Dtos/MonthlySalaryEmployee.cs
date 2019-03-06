namespace Employees.Core.Dtos
{
    public class MonthlySalaryEmployee : Employee
    {
        public override float AnnualSalary
        {
            get
            {
                return this.MonthlySalary * 12;
            }
        }
    }
}
