int[] array = {134, 254, 123, 354, 15, 123, 74, 283};
int n = array.Length;
int find = 123;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }    
    index++; 
}