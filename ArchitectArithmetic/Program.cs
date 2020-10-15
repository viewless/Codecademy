using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();
        }

         static void CalculateTotalCost()
        {
            double rectangleArea = Rect(1500, 2500);
            double triangleArea = Triangle(750, 500);
            double circleArea = Circle(375) / 2;

            double sum = rectangleArea + triangleArea + circleArea;
            double cost = sum * 180;

            Console.WriteLine($"My plan costs: {cost:f2} pesos");
        }

        static double Rect(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}
