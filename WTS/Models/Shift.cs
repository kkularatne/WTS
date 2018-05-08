using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WTS.Models
{
    public class Shift
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public String Name { get; set; }

        public ICollection<EmployeeWorkShift> Employees { get; set; }

        public double getShiftDurationInHours()
        {
            return (this.End - this.Start).TotalHours;
        }
    }
}
