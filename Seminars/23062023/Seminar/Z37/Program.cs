﻿/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
// Создаем случайный массив на 8 чисел   
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
// Создаем пустой массив для результата
int[] res = null;
// На случай изменения размера входного массива меняем соответственно размер массива для результата
if (array.Length % 2 == 0)
{
    res = new int[array.Length / 2];
}
else
{
    res = new int[array.Length / 2 + 1];
}
// переменные для подсчета и записи в массив результата
int count = 0;
int size = 0;
// цикл на произведение пар элементов
for(int j = 0; j < array.Length / 2; j++)
{
    if(j != 0)
    {
        count = array[j] * array[array.Length - (j + 1)];
        res[size] = count;
        size++;
        Console.Write(" " + (1 + j) + " пара : " + count + " ");
    }
    else
    {
        count = array[j] * array[array.Length - 1];
        res[size] = count;
        size++;
        Console.Write(1 + " пара : " + count);
    }
}
Console.WriteLine(" ");
Console.Write("Итоговый массив : ");
for(int g = 0; g < res.Length; g++)
{
    Console.Write(res[g] + " ");
}