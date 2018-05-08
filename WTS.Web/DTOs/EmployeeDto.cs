using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WTS.Web.DTOs
{
    public class EmployeeDto
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public ICollection<ShiftDto> shifts { get; set; }
    }
}
