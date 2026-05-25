namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hp = new HpOfficeJet();
            hp.Print("Rechnung.pdf");
            hp.Scan("Vertrag.pdf");
            hp.Fax("Bestellung.pdf");
            hp.Copy("Brief.pdf");

            Console.WriteLine();

            var canon = new CanonSimplePrinter();
            canon.Print("Foto.jpg");
            // canon.Scan("...");  // ❌ Würde Exception werfen!
        }
    }
}
