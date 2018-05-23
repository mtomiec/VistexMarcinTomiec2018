using System;

namespace PolyCalc
{
    class ConsoleReturn : DataReturn
    {
        public ConsoleReturn(Polygon poly) : base(poly)
        { }
        public override void ReturnData()
        {
            Console.WriteLine("Surface of that " + name + " is equal: {0}", surface);
            Console.WriteLine("Vertices:\n");
            Console.WriteLine("x\ty");
            for(int i=0;i< numberOfVertices; i++)
            {
                Console.WriteLine(vertices[i, 0] + "\t" + vertices[i, 1]);
            }
        }
    }
}
