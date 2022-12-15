string[,] table = new string [2, 5];
table[1, 2] = "Word";
// table[0, 0] table[0, 1] ... table[0, 4]
// table[1, 0] table[1, 1] ... table[1, 4]
/*for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}*/

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
{
    for (int columns = 0; columns < matr.GetLength(1); columns++)
    {
        Console.Write($"{matr[rows, columns]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);