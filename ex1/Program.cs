void printNaturalNumbers(int n)
{
    if (n == 0) return;
    Console.Write(n + ",");
    printNaturalNumbers(n-1);
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
printNaturalNumbers(n);
Console.WriteLine();