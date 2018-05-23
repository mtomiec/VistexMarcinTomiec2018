using System;

namespace PolyCalc
{
    class PolygonFactory
    {
        public Polygon CreatePolygon(int numberOfVertices, double len)
        {
            if (numberOfVertices < 3)
            {
                Console.WriteLine("It's impossible to make polygon with {0} vertices", numberOfVertices);
                return null;
            }
            else
            {
                switch (numberOfVertices)
                {
                    case 3:
                        return new Polygon(numberOfVertices, len, "triangle");
                    case 4:
                        return new Polygon(numberOfVertices, len, "square");
                    case 5:
                        return new Polygon(numberOfVertices, len, "pentagon");
                    case 6:
                        return new Polygon(numberOfVertices, len, "hexagon");
                    case 7:
                        return new Polygon(numberOfVertices, len, "heptagon");
                    case 8:
                        return new Polygon(numberOfVertices, len, "octagon");
                    case 9:
                        return new Polygon(numberOfVertices, len, "nonagon");
                    case 10:
                        return new Polygon(numberOfVertices, len, "decagon");
                    default:
                        return new Polygon(numberOfVertices, len, numberOfVertices.ToString()+"-gon");

                }
            }

        }
    }
}
