﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/
// Создаем массив на 8 чисел и случайными значениями внутри от 0 до 9  
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");