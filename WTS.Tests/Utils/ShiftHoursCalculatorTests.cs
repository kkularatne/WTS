using System;
using System.Collections.Generic;
using WTS.DTOs;
using WTS.Utils;
using Xunit;

namespace WTS.Tests.Utils
{
    public class ShiftHoursCalculatorTests
    {
        [Fact]
        public void Test_calculate()
        {
            // Arrange
            var shiftHours = new List<ShiftHoursCalculatorDto>();
            shiftHours.Add(new ShiftHoursCalculatorDto { shiftDate = new DateTime(2018, 3, 10, 9, 0, 0), shiftDurationInHours = 5.0 });
            shiftHours.Add(new ShiftHoursCalculatorDto {shiftDate = new DateTime(2018,4,10, 9,0,0), shiftDurationInHours = 8.0 });
            shiftHours.Add(new ShiftHoursCalculatorDto { shiftDate = new DateTime(2018, 4, 10, 9, 0, 0), shiftDurationInHours = 8.0 });
            shiftHours.Add(new ShiftHoursCalculatorDto { shiftDate = new DateTime(2018, 5, 10, 9, 0, 0), shiftDurationInHours = 8.0 });
            shiftHours.Add(new ShiftHoursCalculatorDto { shiftDate = new DateTime(2018, 5, 10, 9, 0, 0), shiftDurationInHours = 8.0 });

            ShiftHoursCalculator shiftHoursCalculator = new ShiftHoursCalculator();

            //Act
            List<ShiftDto> result = shiftHoursCalculator.calculate(shiftHours);

            // Assert
           
            Assert.Equal(3, result.Count);

            Assert.Equal(3, result[0].month);
            Assert.Equal(5.0, result[0].NoOfHours);

            Assert.Equal(4, result[1].month);
            Assert.Equal(16.0, result[1].NoOfHours);

            Assert.Equal(5, result[2].month);
            Assert.Equal(16.0, result[2].NoOfHours);



        }
    }
}
