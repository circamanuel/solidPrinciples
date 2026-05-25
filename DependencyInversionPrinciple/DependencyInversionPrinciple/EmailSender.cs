using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    internal class EmailSender : IMessageSender
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"E-mail to {recipient}: {message}");
        }
    }
}
