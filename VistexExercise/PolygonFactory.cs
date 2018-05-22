using System;

namespace VistexExercise
{
    class PolygonFactory
    {
        public Polygon CreatePolygon(int nov, double los)
        {
            if (nov < 3)
            {
                Console.WriteLine("It's impossible to make polygon with {0} vertices", nov);
                return null;
            }
            else
            {
                switch (nov)
                {
                    case 3:
                        return new Polygon(nov, los, "Triangle");
                    case 4:
                        return new Polygon(nov, los, "Square");
                    case 5:
                        return new Polygon(nov, los, "Pentagon");
                    case 6:
                        return new Polygon(nov, los, "Hexagon");
                    case 7:
                        return new Polygon(nov, los, "Heptagon");
                    case 8:
                        return new Polygon(nov, los, "Octagon");
                    case 9:
                        return new Polygon(nov, los, "Nonagon");
                    case 10:
                        return new Polygon(nov, los, "Decagon");
                    default:
                        return new Polygon(nov, los, nov.ToString()+"-gon");

                }
            }

        }
    }
}
