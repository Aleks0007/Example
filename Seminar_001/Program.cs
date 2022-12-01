Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if ((99 < a < 1000) || (-99 > a > -1000))
{
Console.Write(a % 10);
}
else
{
Console.Write("Число не является трёхзначным");
}