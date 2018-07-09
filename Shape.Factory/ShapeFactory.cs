using Shape.Contracts;

namespace Shape.Factory
{
    public class ShapeFactory : IShapeFactory
    {
        public IShape Make<T>() where T : IShape, new()
        {
            return new T();
        }
    }
}
