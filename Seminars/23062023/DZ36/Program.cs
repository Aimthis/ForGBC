﻿/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

// Создаем массив на 8 чисел и случайными значениями внутри от 0 до 999  
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
// Переменная счетчик суммы чисел
int sum = 0;
// Ищем нечетные элементы и складываем их в сумму
for(int j = 0; j < array.Length; j++)
{
    if(array[j] % 2 == 1)
    {
        sum += array[j];
    }
}

Console.Write("В этом массиве сумма: " + sum + " отрицательных чисел");
