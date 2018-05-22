using System;

namespace VistexExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVertices;
            double lenghtOfSide;
            PolygonFactory polyFactory = new PolygonFactory();
            Console.WriteLine("===Calculating surface of any polygon===");
            Console.Write("Insert number of vertices: ");
            numberOfVertices = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert lenght of side: ");
            lenghtOfSide = Convert.ToDouble(Console.ReadLine());
            Polygon poly = polyFactory.CreatePolygon(numberOfVertices, lenghtOfSide);
            Console.WriteLine("Surface of that " + poly.name + " is equal: {0}", poly.CalculateSurface());
            Console.ReadLine();
        }
    }
}
