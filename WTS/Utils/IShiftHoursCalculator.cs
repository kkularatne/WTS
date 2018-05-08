using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTS.DTOs;

namespace WTS.Utils
{
    public interface IShiftHoursCalculator
    {
        List<ShiftDto> calculate(List<ShiftHoursCalculatorDto> shiftHours);
    }
}
