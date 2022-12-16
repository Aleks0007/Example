/* int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(3));

// f(1) = 1, f(2) = 1, f(n) = f(n - 1) + f(n - 2) */

int factorial(int n)
{
    if (n == 1 || n == 2) return 1;
    else return factorial(n - 1) + factorial(n - 2);
}

for (int i = 1; i < 15; i++)
{
    Console.WriteLine(factorial(i));
}
