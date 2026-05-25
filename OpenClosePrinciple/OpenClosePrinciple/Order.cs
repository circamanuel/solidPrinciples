using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{

    public class Order
    {
        public decimal Amount { get; set; }

        public Order(decimal amount)
        {
            Amount = amount;
        }
    }
}
