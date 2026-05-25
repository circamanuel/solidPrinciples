using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    internal class CompositeMessageSender : IMessageSender
    {
        private readonly List<IMessageSender> _senders;

        public CompositeMessageSender(List<IMessageSender> senders)
        {
            _senders = senders;
        }

        public void Send(string recipient, string message)
        {
            foreach(IMessageSender sender in _senders)
            {
                sender.Send(recipient, message);
            }
        }
    }
}
