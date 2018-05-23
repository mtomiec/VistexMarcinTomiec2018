namespace PolyCalc
{
    abstract class DataReturn
    {
        protected double surface;
        protected string name;
        protected string path = null;

        public DataReturn(double s, string n)
        {
            surface = s;
            name = n;
        }

        public abstract void ReturnData();
    }
}
