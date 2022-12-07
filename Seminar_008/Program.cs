Console.Write("Введите х: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите у: ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0) Console.WriteLine("Первая четверть");

if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");

if (x < 0 && y < 0) Console.WriteLine("Третья четверть");

else Console.WriteLine("Четвёртая четверть");