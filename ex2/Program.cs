int searchSum(int m, int n)
{
    if (n == m) return m;
    return n + searchSum(m, n - 1);
}
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
searchSum(m, n);
Console.WriteLine("Сумма натуральных чисел в заданом промежутке = " + searchSum(m, n));