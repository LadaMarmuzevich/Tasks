using System;
Console.Clear();
Console.WriteLine("Введите натуральное число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Натуральные числа в промежутке от M до N:");
for (int i = M; i <= N; i++)
{
    Console.Write($"{i}\t");
}
