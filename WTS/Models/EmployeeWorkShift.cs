using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTS.Models
{
    public class EmployeeWorkShift
    {
        public int ID { get; set; }
        public int EmployeeId { get; set; }
        public int ShiftId { get; set; }
    }
}
