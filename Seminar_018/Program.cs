/* Задайте одномерный массив из 23 случайных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10, 99]. */

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void PrintArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write($"{arr[index]} ");
    }
}
int[] array = FillArray(30, 0, 190);
PrintArray(array);
Console.WriteLine();

int count = 0;
    foreach (int element in array)
    {
        if (element >= 10 && element <= 99)
        {
            count++;
        }
    }
Console.WriteLine($"Количество элементов массива, лежащих в отрезке [10, 99] = {count}");