﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/
// Создаем массив на 8 чисел и случайными значениями внутри от 100 до 999  
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
// Переменная счетчик положительных чисел
int count = 0;
// Ищем положительные числа
for(int j = 0; j < array.Length; j++)
{
    if(array[j] % 2 == 0)
    {
        count++;
    }
}

Console.Write("В этом массиве: " + count + " положительных чисел");