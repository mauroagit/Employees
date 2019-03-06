
using Employees.Core.Contracts;
using Employees.Core.Dtos;
using Employees.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Employees.Tests.Infrastructure
{
    [TestClass]
    public class EmployeesRepositoryTest
    {
        [TestMethod]
        public void GetHourlySalaryEmployee_CheckAnnualSalary()
        {
            // Arrange
            float hourlySalary = 100;
            float expectedAnnualSalary = 120 * hourlySalary * 12;
            var mock = new Mock<IEmployeesUtility>();
            mock.Setup(u => u.GetEmployeesApi()).Returns(new List<EmployeeApi>
            {
                new EmployeeApi
                {
                    Id = 1,
                    ContractTypeName = "HourlySalaryEmployee",
                    HourlySalary = hourlySalary,
                }
            });
            var employeesRepository = new EmployeesRepository(mock.Object);

            // Act
            var result = employeesRepository.GetEmployee(1);

            // Assert
            Assert.AreEqual<float>(expectedAnnualSalary, result.AnnualSalary);
        }

        [TestMethod]
        public void GetMonthlySalaryEmployee_CheckAnnualSalary()
        {
            // Arrange
            float monthlySalary = 7000;
            float expectedAnnualSalary = monthlySalary * 12;
            var mock = new Mock<IEmployeesUtility>();
            mock.Setup(u => u.GetEmployeesApi()).Returns(new List<EmployeeApi>
            {
                new EmployeeApi
                {
                    Id = 1,
                    ContractTypeName = "MonthlySalaryEmployee",
                    MonthlySalary = monthlySalary,
                }
            });
            var employeesRepository = new EmployeesRepository(mock.Object);

            // Act
            var result = employeesRepository.GetEmployee(1);

            // Assert
            Assert.AreEqual<float>(expectedAnnualSalary, result.AnnualSalary);
        }
    }
}
