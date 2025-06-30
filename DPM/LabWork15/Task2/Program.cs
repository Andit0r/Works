OperationDelegate operation = 
    (value1, value2) => Console.WriteLine($"x + y = {value1 + value2}");
operation +=
    (value1, value2) => Console.WriteLine($"Разность: {value1 - value2}"); 
operation += 
    (value1, value2) => Console.WriteLine($"x * y = {value1 * value2}");
operation += 
    (value1, value2) => Console.WriteLine($"x / y = {value1 / value2}");

operation(6, 3);
