﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//
//456 -> 5
//782 -> 8


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 100;
int num2 = num % 10;
Console.WriteLine($"Полученное число - {num1}{num2}");