namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order(42, "manuel@example.com", 99.90m);

            // === Produktion ====
            Console.WriteLine("--- Produktion ---");
            IMessageSender realsender = new EmailSender();
            var prodService = new NotificationService(realsender);
            prodService.NotifyOrderShipped(order);

            // === Test ===
            Console.WriteLine("\n--- Test mit FakeSender ---");
            var fakeSender = new FakeSender();
            var testService = new NotificationService(fakeSender);
            testService.NotifyOrderConfirmed(order);
            testService.NotifyOrderShipped(order);

            Console.WriteLine($"Gesendete Nachrichten : {fakeSender.SentMessages.Count}");

            foreach (var msg in fakeSender.SentMessages)
            {
                Console.WriteLine($" - {msg}");
            }

            //var senders = new CompositeMessageSender( new List<IMessageSender>
            //{
            //    new EmailSender(),
            //    new SmsSender()
            //});

            //var notificationService = new NotificationService(senders);
            //notificationService.NotifyOrderShipped(order);
        }
    }
}
