using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    internal class NotificationService
    {
        private readonly IMessageSender _sender;
        public NotificationService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void NotifyOrderConfirmed(Order order)
        {
            string message = $"Ihre Bestellung #{order.OrderId} über {order.Amount} CHF wurde bestätigt.";
            _sender.Send(order.CustomerEmail, message);
        }

        public void NotifyOrderShipped(Order order)
        {
            string message = $"Ihre Bestellung #{order.OrderId} wurde versandt.";
            _sender.Send(order.CustomerEmail, message);
        }
    }
}
