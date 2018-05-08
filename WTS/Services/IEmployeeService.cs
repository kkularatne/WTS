using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTS.DTOs;
using WTS.Models;

namespace WTS.Services
{
    public interface IEmployeeService
    {
       List<EmployeeDto> getShiftDetails();
    }
}
