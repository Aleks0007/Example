/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве. */

Console.Write("Введите х1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите х2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double distance = Math.Round((Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))), 1);
Console.WriteLine($"Расстояние между точками = {distance}");