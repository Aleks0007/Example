int num = 1;
while (num <= 100)
{
    if (num % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
         Console.WriteLine(num);
    }
    num++;
}
