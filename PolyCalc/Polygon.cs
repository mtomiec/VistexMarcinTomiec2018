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

        public Polygon(int numVertices, double len, string figureName)
        {
            numberOfVertices = numVertices;
            lenghtOfSide = len;
            name = figureName;
            circumRadius = lenghtOfSide / (2 * Math.Sin(Math.PI / numberOfVertices));
            inscribedCircleRadius = circumRadius * Math.Cos(Math.PI / numberOfVertices);
            verticesArray = new double[numberOfVertices, 2];
        }

        public double CalculateSurface()
        {
            double surface = numberOfVertices * lenghtOfSide * inscribedCircleRadius / 2;
            return Math.Round(surface, 4);
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
            double deltaX = verticesArray[0, 0];
            double deltaY = verticesArray[0, 1];
            for (int i=0;i<numberOfVertices;i++)
            {
                verticesArray[i, 0] = Math.Round(verticesArray[i, 0] - deltaX,3);
                verticesArray[i, 1] = Math.Round(verticesArray[i, 1] - deltaY,3);
            }
            return verticesArray;
        }
    }
}
