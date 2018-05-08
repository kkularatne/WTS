using System;
using WTS.Models;
using Xunit;

namespace WTS.Tests.Models
{
    public class EmployeeTests
    {
        [Fact]
        public void Test_getFullName()
        {
            // Arrange
            Employee employee = new Employee { FirstName = "Kasun", Surname = "Kularatne" };

            //Act
            string result = employee.getFullName();

            // Assert
            Assert.Equal("Kasun Kularatne", result);

        }
    }
}
