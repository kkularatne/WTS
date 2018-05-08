using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WTS.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public ICollection<EmployeeWorkShift> Shifts { get; set; }

        public String getFullName()
        {
            return String.Format("{0} {1}", this.FirstName, this.Surname);
        }
    }
}
