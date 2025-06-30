class Patient : IComparable<Patient>, IEquatable<Patient>, IComparable, ICloneable
{
    public Patient(string fullName, int policyNumber, int birthYear)
    {
        FullName = fullName;
        PolicyNumber = policyNumber;
        BirthYear = birthYear;
    }

    public string FullName { get; set; }
    public int PolicyNumber { get; set; }
    public int BirthYear { get; set; }

    public int CompareTo(Patient? patient)
    {
        if (patient is null)
            throw new ArgumentNullException();
        return BirthYear.CompareTo(patient.BirthYear);
    }

    public int CompareTo(object? obj)
    {
        if (obj is Patient patient)
            return BirthYear.CompareTo(patient.BirthYear);
        throw new ArgumentException();
    }

    public bool Equals(Patient? patient)
    {
        return FullName == patient?.FullName
            && PolicyNumber == patient.PolicyNumber
            && BirthYear == patient.BirthYear;
    }

    public object Clone()
    {
        return new Patient(FullName, PolicyNumber, BirthYear);
    }

    public override string ToString()
    {
        return $"{FullName}, номер полиса: {PolicyNumber}, год рождения: {BirthYear}";
    }
}