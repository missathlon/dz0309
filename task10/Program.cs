﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Vvedite 3-zn chislo ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 100 || a > 1000)
{
    Console.WriteLine("are u stupid? ");
    a = Convert.ToInt32(Console.ReadLine());
}

int b = a / 10;
int c = b % 10;
Console.WriteLine(c);
