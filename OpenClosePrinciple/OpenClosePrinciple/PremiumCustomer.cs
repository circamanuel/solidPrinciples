using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    internal class PremiumCustomer : ICustomer
    {
        public decimal CalculateDiscount(Order order)
        {
            return order.Amount * 0.10m;  // 10% Rabatt
        }
    }
}
