namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {


                var order1 = new Order(100m);
                var order2 = new Order(100m);
                var order3 = new Order(100m);

                var regular = new RegularCustomer();
                var vip = new VipCustomer();
                var premium = new PremiumCustomer();


                Console.WriteLine($"Regular: {regular.CalculateDiscount(order1)} CHF");
                Console.WriteLine($"Premium: {premium.CalculateDiscount(order2)} CHF");
                Console.WriteLine($"VIP: {vip.CalculateDiscount(order3)} CHF");
        }
    }
}
