using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    internal class SmsSender : IMessageSender
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sms to {recipient}: {message}");
        }
    }
}
