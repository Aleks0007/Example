string NubmersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NubmersRec(a + 1, b);
    else return string.Empty;
}
Console.WriteLine(NubmersRec(1, 10));
