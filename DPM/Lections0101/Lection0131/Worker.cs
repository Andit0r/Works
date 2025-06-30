public class Worker : Person
{
    public Worker(int age, string name, string post) 
        : base(age, name)
    {
        Post = post;
    }

    public string Post { get; set;}

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"должность: {Post}");
    }

    //public override string ToString() 
        //=> $"{Name}, должность: {Post}";
}