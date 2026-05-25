using System;
using System.Collections.Generic;
using System.Text;

namespace SandBoxSolid
{
    internal class Calculate
    {
        private Employee _employee;

        public Calculate(Employee e)
        {
            _employee = e;
        }
        // Berechnet den Lohn
        public decimal CalculateSalary()
        {
            decimal baseSalary = _employee.HourlyRate * _employee.HoursWorked;

            // Überstunden-Bonus
            if (_employee.HoursWorked > 160)
            {
                decimal overtime = _employee.HoursWorked - 160;
                baseSalary += overtime * _employee.HourlyRate * 0.5m;
            }

            return baseSalary;
        }
    }
}
