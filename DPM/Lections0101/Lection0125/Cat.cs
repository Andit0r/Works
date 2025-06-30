using System.Threading.Channels;

public class Cat(string _name, int _age)
{
    private int breed;

    public int Breed
    {
        get { return breed; }
        set { breed = value; }
    }


    public int Master { get; set; }

    public Cat() : this("kot", 1)
    {
    }

    
    public void Print()
        => Console.WriteLine($"{_name} {_age}");
}