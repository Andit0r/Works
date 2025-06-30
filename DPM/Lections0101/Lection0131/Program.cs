Console.WriteLine("inheritance");


Person person = new(20, "Ivanov");
person.ShowInfo();
Console.WriteLine(person.ToString());
Console.WriteLine(person);

Console.WriteLine();
Worker worker = new(20, "Ivanov", "cleaner");
worker.ShowInfo();
Console.WriteLine(worker.ToString());
Console.WriteLine(worker);