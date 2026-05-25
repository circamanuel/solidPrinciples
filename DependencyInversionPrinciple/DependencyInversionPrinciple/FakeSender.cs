using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    internal class FakeSender : IMessageSender
    {
        public List<string> SentMessages { get; } = new List<string>();

        public void Send(string recipient, string message)
        {
            SentMessages.Add($"{recipient}: {message}");
        }
    }
}
