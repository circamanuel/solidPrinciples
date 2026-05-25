using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    internal class VipCustomer : ICustomer
    {
        public decimal CalculateDiscount(Order order)
        {
            return order.Amount * 0.20m;  // 20% Rabatt
        }
    }
}
