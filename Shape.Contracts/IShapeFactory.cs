namespace Shape.Contracts
{
    public interface IShapeFactory
    {
        IShape Make<T>() where T : IShape, new();
    }
}