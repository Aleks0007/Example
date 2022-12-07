Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1) Console.WriteLine("х > 0, y > 0");
else if (num == 2) Console.WriteLine("х < 0, y > 0");
else if (num == 3) Console.WriteLine("х < 0, y < 0");
else if (num == 4) Console.WriteLine("х > 0, y < 0");
else Console.WriteLine("Заданного номера четверти не существует");