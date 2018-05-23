namespace PolyCalc
{
    class DataReturnFactory
    {
        public DataReturn CreateDataReturn(double s, string n, string p)
        {
            if (p == null)
                return new ConsoleReturn(s, n);
            else
                return new FileReturn(s, n, p);

        }

    }
}
