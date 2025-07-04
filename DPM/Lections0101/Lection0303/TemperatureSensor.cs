﻿class TemperatureSensor
{
    private double _value;
    double Value
    {
        get => _value;
        set
        {
            ValueChanged?.Invoke(this, new TemperatureEventArgs(_value, value));
            _value = value;
        }
    }

    public event EventHandler<TemperatureEventArgs> ValueChanged;
}