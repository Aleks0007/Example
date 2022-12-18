/*  Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int[] res = Fibinacci(num);
Console.WriteLine(string.Join(" ", res));
int[] Fibinacci(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    int i = 2;
    while (i < n)
    {
        array[i] = array[i - 1] + array[i - 2];
        i++;
    }
    return array;
}

