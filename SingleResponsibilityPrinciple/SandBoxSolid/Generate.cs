using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;


namespace SandBoxSolid
{
    internal class Generate
    {
        private Calculate _calculate;

        public Generate(Calculate calculate)
        {
            _calculate = calculate;
        }

        // Generiert einen Bericht
        public string GenerateReport(Employee employee)
        {
            return $"--- Mitarbeiter Report ---\n" +
                   $"ID: {employee.Id}\n" +
                   $"Name: {employee.Name}\n" +
                   $"Stunden: {employee.HoursWorked}\n" +
                   $"Lohn: {_calculate.CalculateSalary()} CHF\n";
        }
    }
}
