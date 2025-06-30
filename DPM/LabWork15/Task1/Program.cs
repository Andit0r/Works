MathDelegate math = Square;
Console.WriteLine($"Квадрат числа: {math(5)}");
math = Factorial;
Console.WriteLine($"Факториал числа: {math(3)}");
math = Absolute;
Console.WriteLine($"Модуль числа: {math(-5)}");
Console.WriteLine($"Модуль числа: {math(5)}");
Console.WriteLine($"Модуль числа: {math(0)}");

Console.WriteLine();
MathDelegate[] maths = [Square, Factorial, Absolute];
foreach (var operation in maths)
    Console.WriteLine($"Значение выражения: {operation(5)}");

Console.WriteLine();
foreach (var operation in maths)
    CallInstanceMethod(operation, 5);

int Square(int value)
    => value * value;

int Factorial(int value)
    => value <= 1 ? 1 : value * Factorial(value - 1);

int Absolute(int value)
    => value < 0 ? -value : value;

void CallInstanceMethod(MathDelegate instance, int value)
{
    Console.WriteLine($"Значение выражения: {instance(value)}");
}