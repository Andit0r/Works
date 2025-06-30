Console.WriteLine("Lection 01/25");

Random random = new();
DateTime birthday = new(2005, 1, 25);

var person = new Person();
person.FullName = "Timoha";
Person.Country = "Russia";

person.Print();

Person person1 = new();
Person person2 = new("ivanov");
Person person3 = new("ivanov", 20);