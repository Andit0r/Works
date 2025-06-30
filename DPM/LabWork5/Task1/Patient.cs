public class Patient
{
    private string fullName;
    private int policyNumber;
    private int birthYear;

    public Patient()
        : this("Иванов Иван Иванович", 700001, 2001)
    {
    }

    public Patient(string fullName, int policyNumber, int birthYear)
    {
        FullName = fullName;
        PolicyNumber = policyNumber;
        BirthYear = birthYear;
    }

    public void Print()
    {
        Console.WriteLine($"name: {FullName}");
        Console.WriteLine($"Policy Number: {PolicyNumber}");
        Console.WriteLine($"Birth Date: {BirthYear}");
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