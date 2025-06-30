class Patient
{
    public Patient(string fullName, string policy, DateTime birthDate)
    {
        FullName = fullName;
        Policy = policy;
        BirthDate = birthDate;
    }

    public string FullName { get; set; }
    public string Policy { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        string policyFormat = Policy.PadLeft(9, '0');
        string bithDateFormat = String.Format("{0:yyyy'/'MM'/'dd}", BirthDate);
        return $"{FullName.ToUpper()};{policyFormat};{bithDateFormat}";
    }
}
