void GetChange(int[] coins, int amount)
{
    Array.Sort(coins);

    Console.Write("{");

    for (int i = coins.Length - 1; i >= 0; i--)
        while (amount >= coins[i])
        {
            amount -= coins[i];
            Console.Write(coins[i] + ",");
        }

    Console.Write("\b}");

    if (amount > 0)
        Console.WriteLine("Error");
}

int value = 9;
int[] coins = { 1, 3, 4 };
GetChange(coins, value);


