using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPronciple
{
    public class Square : IShape
    {
        private int Side { get; } 

        public Square(int side)
        {
            Side = side;
        }

        public int CalculateArea()
        {
            return Side * Side;
        }
    }
}
