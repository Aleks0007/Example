// Задайте два двумерных массива и третий для подсчёта суммы первых двух

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
int[,] GetArraySum(int[,] Array1, int[,] Array2)
{
    int[,] result = new int[Array1.GetLength(0), Array1.GetLength(1)];
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            result[i, j] = Array1[i, j] + Array2[i, j];
        }
    }
    return result;
    
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

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows, columns, 1, 9);
int[,] array2 = GetArray(rows, columns, 1, 9);
int[,] array3 = GetArraySum(array1, array2);
PrintArray(array1);
Console.WriteLine("==============");
PrintArray(array2);
Console.WriteLine("==============");
PrintArray(array3);