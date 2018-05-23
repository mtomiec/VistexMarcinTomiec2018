using System;

namespace PolyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0 || args.Length==1)
            {
                Console.WriteLine("Too few parameters.\nPlease insert at least number of vertices and lenght of side.\nFile path is optional.");
                Console.WriteLine("Usage: PolyCalc num_of_vertices len_of_side [file_path]");
            }
            else
            {
                int numberOfVertices;
                double lenghtOfSide;
                PolygonFactory polyFactory = new PolygonFactory();
                DataReturnFactory dataReturnFactory = new DataReturnFactory();
                DataReturn dataReturn;
                numberOfVertices = Convert.ToInt32(args[0]);
                lenghtOfSide = Convert.ToDouble(args[1]);
                Console.WriteLine(numberOfVertices);
                Console.WriteLine(lenghtOfSide);
                Polygon poly = polyFactory.CreatePolygon(numberOfVertices, lenghtOfSide);
                if (args.Length==2)
                {
                    dataReturn = dataReturnFactory.CreateDataReturn(poly, null);
                }
                else
                {
                    dataReturn = dataReturnFactory.CreateDataReturn(poly, args[2]);
                }
                dataReturn.ReturnData();
            }
            Console.ReadLine();
        }
    }
}
