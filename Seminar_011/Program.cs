/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N. */

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <= Math.Abs(N))
{
    Console.Write(Math.Pow(i, 2));
    Console.Write(" ");
    i++;
}