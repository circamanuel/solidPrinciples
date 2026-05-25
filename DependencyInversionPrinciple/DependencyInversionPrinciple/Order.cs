using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string CustomerEmail { get; set; }
        public decimal Amount { get; set; }

        public Order(int orderId, string customerEmail, decimal amount)
        {
            OrderId = orderId;
            CustomerEmail = customerEmail;
            Amount = amount;
        }
    }
}
