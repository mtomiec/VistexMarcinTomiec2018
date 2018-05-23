namespace PolyCalc
{
    abstract class DataReturn
    {
        protected double surface;
        protected double[,] vertices;
        protected int numOfVertices;
        protected string name;
        protected string path = null;

        public DataReturn(Polygon poly)
        {
            surface = poly.CalculateSurface();
            vertices = poly.CalculateVertices();
            name = poly.name;
            numOfVertices = poly.numberOfVertices;
        }

        public abstract void ReturnData();
    }
}
