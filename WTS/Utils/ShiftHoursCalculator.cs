using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTS.DTOs;

namespace WTS.Utils
{
    public class ShiftHoursCalculator : IShiftHoursCalculator
    {
        public List<ShiftDto> calculate(List<ShiftHoursCalculatorDto> shiftHours)
        {
            var group = shiftHours.GroupBy(x => new { x.shiftDate.Month, x.shiftDate.Year });
            var z = group.Select(
                g => new
                {
                    Key = g.Key,
                    Value = g.Sum(s => s.shiftDurationInHours)
                }
                ).ToList();

            List<ShiftDto> shiftDtos = new List<ShiftDto>();
            foreach (var a in z)
            {
                shiftDtos.Add(new ShiftDto { year = a.Key.Year, month = a.Key.Month, NoOfHours = a.Value });
            }

            return shiftDtos;
        }
    }
}
