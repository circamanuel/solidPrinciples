using System;
using System.Collections.Generic;
using System.Text;

namespace SandBoxSolid
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Employee(int id, string name, string email, decimal hourlyRate, int hoursWorked)
        {
            Id = id;
            Name = name;
            Email = email;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
    }
}
