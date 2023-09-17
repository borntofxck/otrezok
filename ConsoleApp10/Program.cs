using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A:");
            Console.Write("X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B:");
            Console.Write("X: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = double.Parse(Console.ReadLine());

            double length = CalculateDistance(x1, y1, x2, y2);

            Console.WriteLine($"Длина отрезка AB: {length}");
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }
    }
}
