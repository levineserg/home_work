﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("Максимум " + a);
}
else if (b > c)
{
    Console.WriteLine("Максимум " + b);
}
else Console.WriteLine("Максимум " + c);


