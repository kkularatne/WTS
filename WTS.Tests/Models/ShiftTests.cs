using System;
using WTS.Models;
using Xunit;

namespace WTS.Tests.Models
{
    public class ShiftTests
    {
        [Fact]
        public void Test_getShiftDurationInHours()
        {
            // Arrange
            Shift shift = new Shift { ID = 1, Name = "Shift", Start = new DateTime(2018, 5, 7, 9, 0, 0), End = new DateTime(2018, 5, 7, 17, 0, 0) };

            //Act
            double result = shift.getShiftDurationInHours();

            // Assert
            Assert.Equal(8.0, result);

        }
    }
}
