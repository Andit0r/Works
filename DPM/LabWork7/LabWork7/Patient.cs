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

    public void GetInfo()
    {
        Console.WriteLine($"Имя: {FullName}, номер полиса: {PolicyNumber}, год рождения: {BirthYear}");
    }

    public string FullName { get => _fullName; set => _fullName = value; }
    public int PolicyNumber { get => _policyNumber; set => _policyNumber = value; }
    public int BirthYear { get => _birthYear; set => _birthYear = value; }

    public static Patient operator ++(Patient patient)
        => new()
        {
            FullName = patient.FullName,
            PolicyNumber = patient.PolicyNumber,
            BirthYear = patient.BirthYear + 1
        };

    public static Patient operator +(Patient patientParent, Patient patientChild)
        => new()
        {
            FullName = patientParent.FullName,
            PolicyNumber = patientParent.PolicyNumber,
            BirthYear = patientParent.BirthYear + patientChild.BirthYear,
        };

    public static bool operator ==(Patient patient1, Patient patient2)
    {
        if (ReferenceEquals(patient1, patient2))
            return true;
        return patient1.FullName == patient2.FullName &&
            patient1.PolicyNumber == patient2.PolicyNumber &&
            patient1.BirthYear == patient2.BirthYear;
    }

    public static bool operator !=(Patient patient1, Patient patient2)
        => !(patient1 == patient2);

    public static bool operator true(Patient patient)
        => patient.BirthYear >= 0;

    public static bool operator false(Patient patient)
        => patient.BirthYear < 0;
}