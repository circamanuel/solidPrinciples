namespace SandBoxSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(1, "Manuel Meier", "manuel@example.com", 35m, 175);
            var calcSalary = new Calculate(employee);
            var report = new Generate(calcSalary);
            var send = new SendEmail(calcSalary);


            Console.WriteLine(report.GenerateReport(employee));
            send.SendPayslipEmail(employee);
            // employee.SaveToFile();  // in .NET Fiddle auskommentiert lassen, da kein File-System
        }
    }
}
