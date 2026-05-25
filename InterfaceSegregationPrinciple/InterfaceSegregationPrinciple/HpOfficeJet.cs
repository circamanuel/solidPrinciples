using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    internal class HpOfficeJet : ICopy, IPrint, IScan, IFax
    {
        public void Print(string document)
        {
            Console.WriteLine($"HP OfficeJet print: {document}");
        }
        
        public void Scan(string document)
        {
            Console.WriteLine($"HP OfficeJet scane: {document}");
        }

        public void Fax(string document)
        {

            Console.WriteLine($"HP OfficeJet fax: {document}");
        }

        public void Copy(string document)
        {

            Console.WriteLine($"HP OfficeJet copy: {document}");
        }
    }
}
