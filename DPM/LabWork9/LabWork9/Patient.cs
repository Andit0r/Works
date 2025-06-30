class Patient : IPrinter
{
    private string _fullName;
    private int _policyNumber;
    private int _birthYear;

    public Patient()
        : this("Иванов Иван Иванович", 200001, 2001)
    {
    }

    public Patient(string fullName, int policyNumber, int birthYear)
    {
        FullName = fullName;
        PolicyNumber = policyNumber;
        BirthYear = birthYear;
    }

    public string FullName { get => _fullName; set => _fullName = value; }
    public int PolicyNumber { get => _policyNumber; set => _policyNumber = value; }
    public int BirthYear { get => _birthYear; set => _birthYear = value; }

    public void Print()
        => Console.WriteLine($"ФИО: {FullName}, номер полиса:{PolicyNumber}, год рождения:{BirthYear}");
}