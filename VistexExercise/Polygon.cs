using System;

namespace VistexExercise
{
    class Polygon
    {
        public int numberOfVertices { get; }
        public double lenghtOfSide { get; }
        public string name { get; }

        public Polygon(int nov, double los, string n)
        {
            numberOfVertices = nov;
            lenghtOfSide = los;
            name = n;
        }

        public double CalculateSurface()
        {
            double circumRadius = lenghtOfSide / (2 * Math.Sin(Math.PI / numberOfVertices));
            double inscribedCircleRadius = circumRadius * Math.Cos(Math.PI/numberOfVertices);
            return numberOfVertices * lenghtOfSide * inscribedCircleRadius / 2;
        }
    }
}
