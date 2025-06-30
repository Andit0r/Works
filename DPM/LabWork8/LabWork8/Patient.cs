public class Patient
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

    public void GetInfo()
    {
        Console.WriteLine($"Имя: {FullName}, номер полиса: {PolicyNumber}, год рождения: {BirthYear}");
    }

    public override string ToString()
        => $"Имя: {FullName}, номер полиса: {PolicyNumber}, год рождения: {BirthYear}";

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
            return true;

        return (obj is Patient patient1 &&
            FullName == patient1.FullName &&
            PolicyNumber == patient1.PolicyNumber &&
            BirthYear == patient1.BirthYear);
    }
}