﻿using System.Threading.Channels;

public interface IDocument
{
    void Open();
}

public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("pdf opened");
}

public class DocxDocument : IDocument
{
    public void Open() => Console.WriteLine("docx opened");
}

public class Application
{
    public IDocument Create(string type)
        => type switch
        {
            "pdf" => new PdfDocument(),
            "docx" => new DocxDocument(),
            _ => throw new ArgumentException()
        };
}

//public abstract class Application
//{
//    public abstract IDocument Create();

//    public void NewDocument() => Create().Open();
//}

//public class PdfApplication : Application
//{
//    public override IDocument Create() => new PdfDocument();
//}
