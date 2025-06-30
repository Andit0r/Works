using System.Net.Mail;
using System.Text;

Console.WriteLine("Введите название файла для дозаписи");
string? fileName = Console.ReadLine();
if (File.Exists(fileName))
    Console.WriteLine("Файл открыт на дозапись");
else
    Console.WriteLine("Файл не найден, создан новый");

string? text = "";
StringBuilder stringBuilder = new(text);
while (text != "end")
{
    text = Console.ReadLine();
    if (text == "end")
        break;
    stringBuilder.AppendLine(text);
}
File.AppendAllText(fileName, stringBuilder.ToString());


