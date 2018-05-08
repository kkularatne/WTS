using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WTS.Data;
using WTS.DTOs;
using WTS.Models;
using WTS.Utils;

namespace WTS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly WTSContext context;
        private readonly IShiftHoursCalculator shiftHoursCalculator;

        public EmployeeService(WTSContext context, IShiftHoursCalculator shiftHoursCalculator)
        {
            this.context = context;
            this.shiftHoursCalculator = shiftHoursCalculator;
        }

        public List<EmployeeDto> getShiftDetails()
        {
            List<EmployeeDto> dtos = new List<EmployeeDto>();
            var employees = context.Employees.Include(w => w.Shifts).ToList();
            foreach (Employee employee in context.Employees) {
                var shiftHours = new List<ShiftHoursCalculatorDto>();

                foreach (EmployeeWorkShift workShift in employee.Shifts)
                {
                    Shift shift = context.Shifts.Find(workShift.ShiftId);
                    shiftHours.Add(new ShiftHoursCalculatorDto { shiftDate = shift.Start, shiftDurationInHours = shift.getShiftDurationInHours() });
                }

                List<ShiftDto> shiftDtos = this.shiftHoursCalculator.calculate(shiftHours);

                var dto = new EmployeeDto { EmployeeID = employee.ID, FullName = employee.getFullName(), shifts = shiftDtos };
                dtos.Add(dto);
            }
            return dtos;    
        }

    }
}
