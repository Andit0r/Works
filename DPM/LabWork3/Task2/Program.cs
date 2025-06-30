using System.Diagnostics;

double PowerFunction(int x, int n) => n == 0 ? 1 :
    n < 0 ? 1 / PowerFunction(x, -n) : 
    x * PowerFunction(x, n - 1); 

Debug.Assert(PowerFunction(4, 3) == 64);
Debug.Assert(PowerFunction(53, 0) == 1);
Debug.Assert(PowerFunction(4, -2) == 0.0625);