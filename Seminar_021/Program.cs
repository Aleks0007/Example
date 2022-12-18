/* Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */

Console.Write("Введите первую сторону треугольника: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую сторону треугольника: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью сторону треугольника: ");
int num3 = int.Parse(Console.ReadLine()!);
GetSide(num1, num2, num3);

void GetSide(int side1, int side2, int side3)
{
    if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
    {
        Console.WriteLine("Треугольник может существовать");
    }
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
}