struct Patient
{
    private string fullName;
    private int policyNumber;
    private int birthYear;
    public Category Category;

    public Patient(string fullName, int policyNumber, int birthYear)
    {
        FullName = fullName;
        PolicyNumber = policyNumber;
        BirthYear = birthYear;
        Category = Category.Adult;
    }

    public void Print()
    {
        Console.WriteLine($"FullName: {FullName}");
        Console.WriteLine($"Policy Number: {PolicyNumber}");
        Console.WriteLine($"Birth Date: {BirthYear}");
        Console.WriteLine($"Category: {Category}");
    }

    public string FullName
    {
        get => fullName;
        set
        {
            if (value.Trim() != "")
                fullName = value;
        }
    }

    public int PolicyNumber
    {
        get => policyNumber;
        set
        {
            if (value > 0)
                policyNumber = value;
        }
    }

    public int BirthYear
    {
        get => birthYear;
        set
        {
            if (value > 0)
                birthYear = value;
        }
    }
}