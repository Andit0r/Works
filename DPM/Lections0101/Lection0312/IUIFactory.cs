public interface IUIFactory
{
    void CreateButton();
}

class Document : ICloneable
{
    public string Text { get; set; }

    public object Clone() => new Document() { Text = Text };
}
