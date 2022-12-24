/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
и последнюю строку массива. */

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine("==============");
GetArrayResult(array);
PrintArray(array);
 
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
void GetArrayResult(int[,] arrayResult)
{
    
    int m = arrayResult.GetLength(0) - 1;
    for (int i = 0, j = 0; i < arrayResult.GetLength(1); i++)
    {
        int c = arrayResult[j, i];
        arrayResult[j, i] =  arrayResult[m, i];
        arrayResult[m, i] = c;
    }
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
