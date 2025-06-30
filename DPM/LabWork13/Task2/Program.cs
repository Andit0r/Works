using System;
using System.Text;

Console.WriteLine("Введите строку");
string enteredString = Console.ReadLine();

for (int i = 0; i < enteredString.Length; i++)
    enteredString = enteredString.Replace("  ", " ");
Console.WriteLine(enteredString.Trim());

Console.WriteLine("Введите регистр: верхний (ТЕКСТ), нижний (текст), инвертированный (теКСТ -> ТЕкст)");

string index = Console.ReadLine();

if (index == "верхний")
    Console.WriteLine(enteredString.ToUpper());
else if (index == "нижний")
    Console.WriteLine(enteredString.ToLower());
else if (index == "инвертированный")
{
    StringBuilder builder = new StringBuilder(enteredString);
    for(int i  = 0; i < builder.Length; i++)
    {
        if (char.IsLower(builder[i]))
            builder[i] = char.ToUpper(builder[i]);
        else if (char.IsUpper(builder[i]))
            builder[i] = char.ToLower(builder[i]);
    }
    Console.WriteLine(builder);
}



