
namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected string _descripicion;
        public object Descripcion
        {
            get { return _descripicion; }
        }
    }
}
