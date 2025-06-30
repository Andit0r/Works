public class Person
{
    // данные класса
    // field
    private  string _fullName;
    public static string Country;
    public const int MajorityAge = 18;
    private int _age;

    //public Person() 
    //    : this("unknown", 18)
    //{
    //}

    public Person(string fullName = "unknows", int age = 18)
    {
        _fullName = fullName;
        _age = age;
    }
    public string FullName
    {
        get => _fullName;
        set
        {
            if(value.Trim() != "")
                _fullName = value;
        }
    }
    public int Age
    {
        get => _age;
        set
        {
            if (value >= 0)
                _age = value;
        }
    }


    ~Person()
    {
        // очистка ресурсов
    }
    //public Person(string fullName, int age)
    //{
    //    FullName = fullName;
    //    Age = age;
    //}


    public int BirthYear() 
        => DateTime.Now.Year - Age;

    // фуункции класса
    public void Print()
    {
        Console.WriteLine($"name: {FullName}");
        Console.WriteLine($"country: {Country}");
        Console.WriteLine($"Majority age: {MajorityAge}");
    }
}