abstract class ShapeDecorator : IShape
{
    protected IShape decoratedShape;

    protected ShapeDecorator(IShape decoratedShape)
    {
        this.decoratedShape = decoratedShape;
    }

    public virtual void Draw()
    {
        decoratedShape.Draw();
    }
}
