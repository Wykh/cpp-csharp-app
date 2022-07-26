// See https://aka.ms/new-console-template for more information
using FigureClient.Models;
using System.Runtime.InteropServices;

namespace FigureClient {
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine("Rectangle area: " + rectangle.getArea());
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 0);
            Triangle triangle = new Triangle(p1, p2, p3);
            Console.WriteLine("Triangle area: " + triangle.getArea());
        }
    }
}

