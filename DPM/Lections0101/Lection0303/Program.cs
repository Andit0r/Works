Console.WriteLine("events");

Sensor sensor1 = new() { Temperature = -2, Pressure = 750 };

sensor1.PropertyChanged += Sensor_PropertyChanged;
sensor1.Temperature = 52;
sensor1.Temperature = 42;
sensor1.Pressure = 50;

Sensor sensor2 = new() { Temperature = 10, Pressure = 750 };
sensor2.PropertyChanged += Sensor_PropertyChanged;
sensor2.Temperature = 20;

void Sensor_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
{
    Sensor? sensor = sender as Sensor;
    Console.WriteLine($"Изменилось показание {e.PropertyName}");
    Console.WriteLine($"t={sensor?.Temperature}, p={sensor?.Pressure}");
    Console.WriteLine();
}