// Напишите программу, которая будет преобразовывать десятичное число в двоичное

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int res = 0;
string answer = "";
Console.WriteLine(Get2Num(num));

string Get2Num(int num1)
{
    while (num1 > 0)
    {
        res = num1 % 2;
        num1 /= 2;
        answer = res + answer;
    }
    return answer;
}