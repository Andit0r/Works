class ShapeFactory
{
    public IShape? GetShape(string shapeType)
    {
        if (shapeType == null)
            return null;

        if (shapeType.Equals("circle", StringComparison.OrdinalIgnoreCase))
            return new Circle();

        if (shapeType.Equals("rectangle", StringComparison.OrdinalIgnoreCase))
            return new Rectangle();

        if (shapeType.Equals("square", StringComparison.OrdinalIgnoreCase))
            return new Square();

        if (shapeType.Equals("triangle", StringComparison.OrdinalIgnoreCase))
            return new Triangle();

        return null;
    }
}
