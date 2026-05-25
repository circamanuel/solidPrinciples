using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{
    internal interface ICustomer
    {
        decimal CalculateDiscount(Order order);
    }
}