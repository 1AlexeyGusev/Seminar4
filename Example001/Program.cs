﻿Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36

Console.Write($"Введите чило А: ");
int a = int.Parse(Console.ReadLine());

int Sum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");