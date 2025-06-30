using System.Diagnostics;

int Factorial(int value) => 
    value < 0 ? 0 :
    value <= 1 ? 1 :
    value * Factorial(value - 1); 

Debug.Assert(Factorial(6) == 720);
Debug.Assert(Factorial(-1) == 0);