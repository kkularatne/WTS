using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTS.Models;

namespace WTS.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WTSContext context)
        {
            context.Database.EnsureCreated();
            if (context.Employees.Any())
            {
                return;
            }

            var shifts = new Shift[]
            {
                new Shift{ ID = 1, Start = new DateTime(2016,11,11,9,0,0), End = new DateTime(2016,11,11,17,0,0), Name = "Morning 9-17", },
                new Shift{ ID = 2, Start = new DateTime(2016,11,12,10,0,0), End = new DateTime(2016,11,12,14,0,0), Name = "Morning 10-14" },
                new Shift{ ID = 4, Start = new DateTime(2016,11,13,9,0,0), End = new DateTime(2016,11,13,17,0,0), Name = "Morning 9-17" },
                new Shift{ ID = 5, Start = new DateTime(2016,11,14,10,0,0), End = new DateTime(2016,11,14,14,0,0), Name = "Morning 10-14" },
                new Shift{ ID = 6, Start = new DateTime(2016,11,15,9,0,0), End = new DateTime(2016,11,15,17,0,0), Name = "Morning 9-17" },
                new Shift{ ID = 7, Start = new DateTime(2016,12,13,9,0,0), End = new DateTime(2016,12,13,17,0,0), Name = "Morning 9-17" },
                new Shift{ ID = 8, Start = new DateTime(2016,12,14,9,0,0), End = new DateTime(2016,12,14,17,0,0), Name = "Morning 9-17" },

            };

            foreach (Shift shift in shifts)
            {
                context.Shifts.Add(shift);
            }

            context.SaveChanges();

            var employees = new Employee[]{
                new Employee { ID = 1, FirstName = "John", Surname = "Brown"},
                new Employee { ID = 2, FirstName = "Harry", Surname = "Potter"},
                new Employee { ID = 3, FirstName = "Alice", Surname = "White"},
                new Employee { ID = 4, FirstName = "Joe", Surname = "Mellor"},
                new Employee { ID = 5, FirstName = "Neil", Surname = "Fearn"},
                new Employee { ID = 6, FirstName = "Rob", Surname = "Lang"}
            };
            foreach (Employee employee in employees)
            {
                context.Employees.Add(employee);
            }

            context.SaveChanges();

            var workShifts = new EmployeeWorkShift[] {
                new EmployeeWorkShift {EmployeeId = 1, ShiftId = 1},
                new EmployeeWorkShift {EmployeeId = 2, ShiftId = 1},
                new EmployeeWorkShift {EmployeeId = 3, ShiftId = 1},
                new EmployeeWorkShift {EmployeeId = 4, ShiftId = 1},

                new EmployeeWorkShift {EmployeeId = 1, ShiftId = 2},
                new EmployeeWorkShift {EmployeeId = 5, ShiftId = 2},
                new EmployeeWorkShift {EmployeeId = 6, ShiftId = 2},

                new EmployeeWorkShift {EmployeeId = 1, ShiftId = 4},
                new EmployeeWorkShift {EmployeeId = 4, ShiftId = 4},
                new EmployeeWorkShift {EmployeeId = 6, ShiftId = 4},
                new EmployeeWorkShift {EmployeeId = 2, ShiftId = 4},

                new EmployeeWorkShift {EmployeeId = 6, ShiftId = 5},
                new EmployeeWorkShift {EmployeeId = 2, ShiftId = 5},
                new EmployeeWorkShift {EmployeeId = 4, ShiftId = 5},
                new EmployeeWorkShift {EmployeeId = 5, ShiftId = 5},

                new EmployeeWorkShift {EmployeeId = 1, ShiftId = 6},
                new EmployeeWorkShift {EmployeeId = 2, ShiftId = 6},
                new EmployeeWorkShift {EmployeeId = 3, ShiftId = 6},
                new EmployeeWorkShift {EmployeeId = 6, ShiftId = 6},

                new EmployeeWorkShift {EmployeeId = 3, ShiftId = 7},
                new EmployeeWorkShift {EmployeeId = 5, ShiftId = 7},
                new EmployeeWorkShift {EmployeeId = 2, ShiftId = 7},

                new EmployeeWorkShift {EmployeeId = 1, ShiftId = 8},
            };

            foreach (EmployeeWorkShift workShift in workShifts)
            {
                context.EmployeeWorkShifts.Add(workShift);
            }

            context.SaveChanges();
        }
    }
}

