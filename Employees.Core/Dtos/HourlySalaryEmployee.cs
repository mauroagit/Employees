namespace Employees.Core.Dtos
{
    public class HourlySalaryEmployee : Employee
    {
        public override float AnnualSalary
        {
            get
            {
                return 120 * this.HourlySalary * 12;
            }
        }
    }
}
