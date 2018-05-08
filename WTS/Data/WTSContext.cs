using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WTS.Models;

namespace WTS.Data
{
    public class WTSContext : DbContext
    {
        public WTSContext(DbContextOptions<WTSContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeWorkShift> EmployeeWorkShifts { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<EmployeeWorkShift>().ToTable("Employee_Works_Shift");
            modelBuilder.Entity<Shift>().ToTable("Shifts");
        }



    }
}
