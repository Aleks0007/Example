Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
int num3 = num2 % num1;

if (num2 % num1 == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine($"Второе число не кратно первому, остаток --> {num3}");
}