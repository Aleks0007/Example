/* Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */
int[] array = GetArray(6, 0, 10);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();
int[] reversArray = ReversArray2(array);
//ReversArray1(array);
Console.WriteLine(string.Join(" ", reversArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
void ReversArray1(int[] inArray)
{
    for (int position = 0; position < inArray.Length / 2; position++)
    {
        int k = inArray[position];
        inArray[position] = inArray[inArray.Length - 1 - position];
        inArray[inArray.Length - 1 - position] = k;
    }
}
int[] ReversArray2(int[] inArray)
{
    int[] res = new int[inArray.Length];
    for (int index = 0; index < inArray.Length; index++)
    {
        res[index] = inArray[inArray.Length - 1 - index];
    }
    return res;
}