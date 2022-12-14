/* Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray( int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write($"{arr[index]} ");
    }
}

void ChangeArray( int[] array2)
{
    for (int position = 0; position < array2.Length; position++)
    {
        array2[position] = -array2[position];
        Console.Write($"{array2[position]} ");
    }
}
int[] array = GetArray(10, -10, 11);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("==========================");
ChangeArray(array);