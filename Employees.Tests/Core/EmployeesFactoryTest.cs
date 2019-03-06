using Employees.Core;
using Employees.Core.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employees.Tests.Core
{
    [TestClass]
    public class EmployeesFactoryTest
    {
        [TestMethod]
        public void CreateHourlySalaryEmployee_Success()
        {
            // Arrange
            string contractType = "HourlySalaryEmployee";

            // Act
            var result = EmployeesFactory.Get(contractType);

            // Assert
            Assert.IsInstanceOfType(result, typeof(HourlySalaryEmployee));
        }

        [TestMethod]
        public void CreateMonthlySalaryEmployee_Success()
        {
            // Arrange
            string contractType = "MonthlySalaryEmployee";

            // Act
            var result = EmployeesFactory.Get(contractType);

            // Assert
            Assert.IsInstanceOfType(result, typeof(MonthlySalaryEmployee));
        }
    }
}
