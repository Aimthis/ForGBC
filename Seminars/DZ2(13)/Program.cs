﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a > 99)
{
    while (a > 999)
    {
        a = a / 10;
    }
    a = a % 10;
    Console.Write($"Третье число {a}");
}
else
{
    Console.Write("Нет третьего числа");
}