using System;

class Program
{
static int Fibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void Main()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.Write(Fibonacci(i) + " ");
    }
}
}