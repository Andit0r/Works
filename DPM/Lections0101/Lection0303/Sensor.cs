using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Sensor : INotifyPropertyChanged
{
    private double _temperature;
    private double _pressure;

    public double Temperature
    {
        get => _temperature;
        set
        {
            _temperature = value;
            OnPropertyChanged();
        }
    }

    public double Pressure
    {
        get => _pressure;
        set
        {
            _pressure = value;
            OnPropertyChanged();
        }
    }

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}