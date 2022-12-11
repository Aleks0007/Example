 // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

 Console.Write("Введите число: ");
 int N = int.Parse(Console.ReadLine()!);
 Console.WriteLine($"Сумма чисел равна {GetSumNums(N)}");

 int GetSumNums(int number)
 {
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
 }