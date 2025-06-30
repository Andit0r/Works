using System.Diagnostics;

double SimplePower(int x, int n) => 
    n == 0 ? 1 :
    n < 0 ? -1 :
    (n % 2 == 0 ? SimplePower(x * x, n / 2) :
    x * SimplePower(x * x, n / 2)); 

Debug.Assert(SimplePower(4, 3) == 64);
Debug.Assert(SimplePower(53, 0) == 1);
Debug.Assert(SimplePower(4, -2) == -1);