﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Напишите число");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 0;
if (number < 1000 & number >= 100)
{
     number2 = number % 100;
}

Console.WriteLine($"{number2 / 10}");