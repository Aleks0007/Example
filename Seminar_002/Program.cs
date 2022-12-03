int number = new Random().Next(10, 100); 
int number1 = number / 10;
int number2 = number % 10;
int max = number1;

if (number2 > max)
{
    max = number2;
}
Console.WriteLine($"Максимальная цифра в числе {number} --> {max}");