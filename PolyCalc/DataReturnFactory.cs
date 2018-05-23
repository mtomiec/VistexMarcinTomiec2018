namespace PolyCalc
{
    class DataReturnFactory
    {
        public DataReturn CreateDataReturn(Polygon poly, string path)
        {
            if (path == null)
                return new ConsoleReturn(poly);
            else
                return new FileReturn(poly,path);

        }

    }
}
