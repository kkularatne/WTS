using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTS.DTOs
{
    public class ShiftHoursCalculatorDto
    {
        public DateTime shiftDate { get; set; }
        public double shiftDurationInHours { get; set; }
    }
}
