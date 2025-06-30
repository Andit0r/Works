class HatShapeDecorator : ShapeDecorator
{
    public HatShapeDecorator(IShape decoratedShape) : base(decoratedShape)
    {
    }

    public override void Draw()
    {
        decoratedShape.Draw();
        AddHat(decoratedShape);
    }

    private void AddHat(IShape decoratedShape)
    {
        Console.WriteLine("With hat"); ;
    }
}
