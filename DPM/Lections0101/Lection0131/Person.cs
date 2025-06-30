public class Person
{
    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public int Age { get; set; }
    public string Name { get; set; }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Имя:{Name}, возраст: {Age}");
    }

    public sealed override string ToString()
        => $"{Name}, Возраст: {Age}";

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj)) 
            return true;

        return (obj is Person person1 &&
            Name == person1.Name &&
            Age == person1.Age);
    }
}