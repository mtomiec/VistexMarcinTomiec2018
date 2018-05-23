namespace PolyCalc
{
    abstract class DataReturn
    {
        protected double surface;
        protected double[,] vertices;
        protected int numberOfVertices;
        protected string name;
        protected string path = null;

        public DataReturn(Polygon poly)
        {
            surface = poly.CalculateSurface();
            vertices = poly.CalculateVertices();
            name = poly.name;
            numberOfVertices = poly.numberOfVertices;
        }

        public abstract void ReturnData();
    }
}
