using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    internal class CanonSimplePrinter : IPrint
    {
        public void Print(string document)
        {
            Console.WriteLine($"Canon prints document: {document}");
        }
    }
}
