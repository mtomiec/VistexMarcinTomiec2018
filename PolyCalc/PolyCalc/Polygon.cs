using System;

namespace PolyCalc
{
    class Polygon
    {
        public int numberOfVertices { get; }
        public double lenghtOfSide { get; }
        public string name { get; }
        public double[,] verticesArray { get; }
        private double circumRadius;
        private double inscribedCircleRadius;

        public Polygon(int nov, double los, string n)
        {
            numberOfVertices = nov;
            lenghtOfSide = los;
            name = n;
            circumRadius = lenghtOfSide / (2 * Math.Sin(Math.PI / numberOfVertices));
            inscribedCircleRadius = circumRadius * Math.Cos(Math.PI / numberOfVertices);
            verticesArray = new double[numberOfVertices, 2];
        }

        public double CalculateSurface()
        {
            return numberOfVertices * lenghtOfSide * inscribedCircleRadius / 2;
        }

        public double[,] CalculateVertices()
        {
            double angle;
            for (int i=0;i<numberOfVertices;i++)
            {
                angle = i * 2 * Math.PI / numberOfVertices;
                verticesArray[i, 0] = inscribedCircleRadius * Math.Cos(angle);
                verticesArray[i, 1] = inscribedCircleRadius * Math.Sin(angle);
            }
            return verticesArray;
        }
    }
}
