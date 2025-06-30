Car car1 = new() { Brand = "bmw" };

Car[] cars = [
    new() {Brand = "bmw", Speed = 120},
    new() {Brand = "lada", Speed = 60},
    new() {Brand = "toyota", Speed = 200}
    ];

foreach(var car in cars)
    Console.WriteLine(car);

Console.WriteLine();
Array.Sort(cars);
foreach(var car in cars)
    Console.WriteLine(car);

interface IMovable
{
    const int MinSpeed = 0;
    static int MaxSpeed = 60;
    void Move();
    string SpeedInfo { get; }
}

class Car1 : IEquatable<Car>
{
    public required string Brand { get; set; }
    public int Speed { get; set; }

    public bool Equals(Car? other) 
        => Brand == other?.Brand && Speed == other.Speed;
}

class Car : IComparable
{
    public required string Brand { get; set; }
    public int Speed { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is Car car)
            return Speed.CompareTo(car.Speed);
        throw new ArgumentException();

        //var car = obj as Car;
        //return Brand.CompareTo(car?.Brand);

        //if (Speed > car.Speed) 
        //    return 1;
        //if (Speed < car.Speed)
        //    return -1;
        //return 0;
    }

    public override string ToString()
    {
        return $"{Brand}, {Speed} км/ч";
    }
}