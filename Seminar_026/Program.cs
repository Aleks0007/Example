/* Задайте двумерный массив. Найдите элементы, у которых оба индекса 
чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2    
3 6 8 1
9 7 6 2 */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void GetElementsPower(int[,] ArrayPower)
{
    for (int index = 0; index < ArrayPower.GetLength(0); index += 2)
    {
        for (int position = 0; position < ArrayPower.GetLength(1); position += 2)
        {
            ArrayPower[index, position] = ArrayPower[index, position] * ArrayPower[index, position];
        }
    }
}
void PrintArray(int[,] inArray)
{
    for (int index = 0; index < inArray.GetLength(0); index++)
    {
        for (int position = 0; position < inArray.GetLength(1); position++)
        {
            Console.Write($"{inArray[index, position]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);
Console.WriteLine("===========");
GetElementsPower(array);
PrintArray(array);