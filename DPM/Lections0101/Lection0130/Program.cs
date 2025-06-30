using TestApp;

Factory factory = new() { Name = "Sevmash", Income = 1000000 };
factory.ShowInfo();
factory++;
factory.ShowInfo();

Factory bmw = new() { Name = "BMW", Income = 1000000000 };
Factory autovaz = new() { Name = "AutoVAZ", Income = 200000 };

if (bmw)
    Console.WriteLine("bmw income > 0");
else
    Console.WriteLine("bmw income < 0");

if (autovaz)
    Console.WriteLine("autovaz income > 0");
else
    Console.WriteLine("autovaz income < 0");

Factory bmwvaz = bmw + autovaz;
bmwvaz.ShowInfo();

Factory factory1 = new() { Name = "Sevmash", Income = 1000000 };
Factory factory2 = new() { Name = "Sevmash", Income = 1000000 };

if(factory1 == factory2)
    Console.WriteLine("factory1 == factory2");
else
    Console.WriteLine("factory1 != factory2");

var random = new PowerfullRandom();
Console.WriteLine(random.NextDouble(-7.1, 9));

Console.WriteLine(bmw.ToString());