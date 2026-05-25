using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SandBoxSolid
{
    internal class Save
    {
        private Employee _employee;

        public  Save(Employee employee)
        {
            _employee = employee;
        }

        // Speichert den Mitarbeiter in einer Datei
        public void SaveToFile()
        {
            string data = $"{_employee.Id};{_employee.Name};{_employee.Email};{_employee.HourlyRate};{_employee.HoursWorked}";
            File.WriteAllText($"employee_{_employee.Id}.txt", data);
            Console.WriteLine($"Mitarbeiter {_employee.Name} gespeichert.");
        }
    }
}
