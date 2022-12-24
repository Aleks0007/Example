/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine("=========");

if (rows == columns)
{
    int[,] changeArray = ChangeRowsColumns(array, rows, columns);
    PrintArray(changeArray);
}
else
{
    Console.WriteLine("Диапазон строк/столбцов выходит за пределы массива");
}

int[,] FillArray(int m, int n)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}
    int[,] ChangeRowsColumns(int[,] inArray, int r, int c)
{
    int[,] newArray = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            newArray[i, j] = inArray[j, i];
        }
    }
    return newArray;
}

void PrintArray(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j]} ");
        }
        Console.WriteLine();
    }
}