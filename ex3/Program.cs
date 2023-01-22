int akk(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return akk(m - 1, 1);
    else
        return akk(m - 1, akk(m, n - 1));
}
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(akk(m, n));
Console.WriteLine($"({m}, {n}) = {akk(m, n)}");