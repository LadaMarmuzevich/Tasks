using System;
Console.Clear();
Console.WriteLine("Введите натуральное число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N:");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = M; i <= N; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма натуральных чисел: {sum}");
