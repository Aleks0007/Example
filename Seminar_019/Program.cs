/* Найдите произведение пары чисел в одномерном массиве. Парой считаем первый и последний элемент,
второй и предпоследний...
Результат запишите в новом массиве
[1,2,3,4,5] --> [5,8,3] */

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split();
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size = array.Length / 2 + 1;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i == array.Length - 1 - i) result[i] = array[i];
        else result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}