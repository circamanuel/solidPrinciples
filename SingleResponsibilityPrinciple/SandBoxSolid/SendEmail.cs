using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SandBoxSolid
{
    internal class SendEmail
    {
        private Calculate _calculate;

        public SendEmail(Calculate calculate)
        {
            _calculate = calculate;
        }

        // Sendet eine E-Mail an den Mitarbeiter
        public void SendPayslipEmail(Employee employee)
        {
            decimal salary = _calculate.CalculateSalary();
            string emailBody = $"Hallo {employee.Name}, dein Lohn diesen Monat: {salary} CHF";

            // Simuliere E-Mail-Versand
            Console.WriteLine($"E-Mail an {employee.Email} gesendet:");
            Console.WriteLine(emailBody);
        }
    }
}
