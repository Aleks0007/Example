/* Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве. */

Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

void PrintArray(int[] arra)
{
    for (int index = 0; index < arra.Length; index++)
    {
        Console.Write($"{arra[index]} ");
    }
}
int[] array = FillArray(num, 0, 15);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число для проверки: ");
int n = int.Parse(Console.ReadLine()!);
int count = 0;

void CheckArray(int[] arr)
{
    for (int position = 0; position < arr.Length; position++)
    {
        if (n == arr[position]) count++;
    }
    if (count > 0) 
        {
            Console.WriteLine("Данное число есть в массиве"); 
        }
        else 
        {
            Console.WriteLine("Данного числа нет в массиве");
        }
}

CheckArray(array);