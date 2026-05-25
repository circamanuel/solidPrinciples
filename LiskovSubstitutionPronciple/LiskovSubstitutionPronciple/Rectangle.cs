using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPronciple
{
    internal class Rectangle : IShape
    {
        private int Width { get; }
        private int Height { get; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }

}
