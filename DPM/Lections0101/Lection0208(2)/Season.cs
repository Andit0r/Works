enum Season { Spring, Summer, Autumn, Winter }

enum SumerMonth : byte
{
    June = 6,
    July = 7,
    August = 8,
}

[Flags]
enum Color
{
    Black = 0,
    Red = 1,
    Yellow = 2,
    Blue = 4,
    Orange = Red | Yellow, // 3
    Green = Yellow | Blue, // 6
    White = Red | Yellow | Blue, // 7
}