using System.Drawing;

namespace LiskovSubstitutionPronciple
{
    internal class Program
    {
        static void PrintAreaAfterResize(IShape shape)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }

        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new Rectangle(5,4),
                new Square(4),
            };

            foreach (IShape shape in shapes)
            {
                PrintAreaAfterResize(shape);
            }
        }
    }
}
