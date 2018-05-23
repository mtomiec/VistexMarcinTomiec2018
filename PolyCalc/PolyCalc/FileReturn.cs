using System;
using System.IO;

namespace PolyCalc
{
    class FileReturn : DataReturn
    {
        public FileReturn(double s, string n, string p) : base(s, n)
        {
            path = p;
        }

        public override void ReturnData()
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine("Surface of that " + name + " is equal: {0}", surface);
            file.Close();
            Console.WriteLine("The results have been written to file " + path);
        }
    }
}
