using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    internal class RegularCustomer : ICustomer
    {
        public decimal CalculateDiscount(Order order)
        {
            return order.Amount * 0.05m;  // 5% Rabatt
        }
    }
}
