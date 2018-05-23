using System;
using System.IO;

namespace PolyCalc
{
    class FileReturn : DataReturn
    {
        public FileReturn(Polygon poly, string filePath) : base(poly)
        {
            path = filePath;
        }

        public override void ReturnData()
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine("Surface of that " + name + " is equal: {0}", surface);
            file.WriteLine("Vertices:\n");
            file.WriteLine("x\ty");
            for (int i = 0; i < numberOfVertices; i++)
            {
                file.WriteLine(vertices[i, 0] + "\t" + vertices[i, 1]);
            }
            file.Close();
            Console.WriteLine("The results have been written to file\n" + path);
        }
    }
}
