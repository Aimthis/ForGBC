// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Создаю и наполняю массив случайными числами от 0 до 2 147 483 647
int[] array = new int[8];
Console.Write("Создан массив { | ");
for(short i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2147483647);
        Console.Write(array[i] + " | ");
    }   Console.Write("}");