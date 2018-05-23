using System;

namespace PolyCalc
{
    class ConsoleReturn : DataReturn
    {
        public ConsoleReturn(double s, string n) : base(s,n)
        { }
        public override void ReturnData()
        {
            Console.WriteLine("Surface of that " + name + " is equal: {0}", surface);
        }
    }
}
