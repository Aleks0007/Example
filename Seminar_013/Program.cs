// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе: {GetAmountNum(num)}");

int GetAmountNum(int number)
{
    int count = 0;
    while (Math.Abs(number) > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}