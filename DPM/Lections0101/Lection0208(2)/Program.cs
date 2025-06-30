using System.Text.RegularExpressions;

var point1 = (x: 2, y: 5);
point1.Item1 = 4;
Console.WriteLine(point1);

(double, double, double) point3d = (0, 3, 6);

(int, string) user = (Id: 123, Login: "admin");

SumerMonth month = SumerMonth.July;
Color purple = Color.Red | Color.Blue;

Season season = (Season)3; // Season.Winter
int monthNumber = (int)month; // 7
int purpleValue = (int)purple; //1+4=5

RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.RightToLeft;

for (int i = 0; i < 16; i++)
{
    ConsoleColor color = (ConsoleColor)i;
    Console.BackgroundColor = color;
    Console.WriteLine(color);
}

Console.BackgroundColor = ConsoleColor.Black;
Person person1 = new(23) { Id = 23, FullName = "zxc Ken Kaneki" }; 
Console.WriteLine(person1);
Person person2 = new(23) { Id = 123, FullName = "zxc Ken Kaneki" };
Console.WriteLine(person2);

if(person1.Equals(person2))
    Console.WriteLine("равны");
else
    Console.WriteLine("не равны");

Point2d point = new();
Console.WriteLine(point1); 