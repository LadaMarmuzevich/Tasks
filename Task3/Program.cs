using System;
Console.Clear();
Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);

Console.WriteLine($"Результат функции Аккермана: {result}");

  int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    
    if (m > 0 || n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    
    if (m > 0 || n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else 
    { 
        return -1;
    }
}
