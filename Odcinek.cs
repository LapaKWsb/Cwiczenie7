using System;

namespace Zadanie
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Współrzędne początkowe:");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Współrzędne końcowe:");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double length = CalculateLength(x1, y1, x2, y2);

            Console.WriteLine($"Długość odcinka wynosi: {length}");
        }

        public static double CalculateLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
