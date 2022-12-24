/* Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. */

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 9);
Console.WriteLine("===============================");
PrintArray(array);
Console.WriteLine("===============================");
int min = GetMinValue(array);
int max = GetMaxValue(array);
GetElementCount(array, min, max);
 
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
int GetMinValue(int[,] array)
{
    int minValue = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minValue > array[i, j]) minValue = array[i, j];
        }
    }
    return minValue;
}
int GetMaxValue(int[,] array)
{
    int maxValue = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (maxValue < array[i, j]) maxValue = array[i, j];
        }
    }
    return maxValue;
}
void GetElementCount(int[,] array, int minValue, int maxValue)
{
    for (int m = minValue; m <= maxValue; m++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == m) count++;
            }
        }
        if (count > 0) Console.WriteLine($"{m} встречается {count} раз"); Console.WriteLine("===============================");
    }
    
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}