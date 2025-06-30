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
        _fullName = fullName;
        _policyNumber = policyNumber;
        _birthYear = birthYear;
    }

    public object this[string index]
    {
        get
        {
            return index switch
            {
                "fullName" => _fullName,
                "policyNumber" => _policyNumber,
                "birthYear" => _birthYear,
                _ => -1
            };
        }
    }

    public char this[int index]
    {
        get
        {
            if (index >= 0 && index <= _fullName.Length - 1)
                return _fullName[index];
            return '\0';
        }
    }
}