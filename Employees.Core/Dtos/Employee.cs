namespace Employees.Core.Dtos
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public short RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public float HourlySalary { get; set; }
        public float MonthlySalary { get; set; }

        public abstract float AnnualSalary { get; }

        public string HourlySalaryText
        {
            get
            {
                return string.Format("{0:C}", this.HourlySalary);
            }
        }

        public string MonthlySalaryText
        {
            get
            {
                return string.Format("{0:C}", this.MonthlySalary);
            }
        }

        public string AnnualSalaryText
        {
            get
            {
                return string.Format("{0:C}", this.AnnualSalary);
            }
        }
    }
}
