/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

// Создаем двумерный массив на 8-16 строк, столбцов и случайными значениями внутри от 0 до 999  
double[,] array = new double[new Random().Next(8,17),new Random().Next(8,17)];
for(int i = 0; i < array.GetLength(0);i++){
    for(int j = 0; j < array.GetLength(1);j++){
        array[i,j] = new Random().Next(0,1000);
    }
}
// Создаю переменные для поиска строки и столбца в массиве с запросом на ввод
Console.Clear();
Console.Write("Пожалуйста, введите строку: ");
int searchString = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Пожалуйста, введите столбец: ");
int searchColumn = int.Parse(Console.ReadLine());

try
{
    Console.WriteLine($"Элемент в строке {searchString} и столбце {searchColumn} имеет значение : " + array[searchString,searchColumn]);
}
catch (System.Exception)
{
    Console.WriteLine("В массиве нет такого элемента");
    Environment.Exit(1);
}

/*
for(int i = 0;i < array.GetLength(0);i++){
    for(int j = 0;j < array.GetLength(1);j++){
        if(Ui == array[i,j])
            Console.WriteLine("В массиве есть такое число");
        else
            Console.Write("В массиве нет такого числа");
    }
}*/