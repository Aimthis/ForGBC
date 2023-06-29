/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

// Создаю строковые переменные Aui - all user input для сбора данных и Ui - user input для ввода
string Aui = string.Empty;
string Ui = string.Empty;

// Создаю запрос на ввод в цикле до ввода 4 значений
Console.Clear();
Console.WriteLine("Введите числа 1 = b1; 2 = k1; 3 = b2; 4 = k2");
Console.WriteLine();
while(Aui.Length < 4){
    Console.Write("Введите " + (Aui.Length + 1) + " число : ");
    Ui = Console.ReadLine();
    Console.WriteLine();
    try{
        double.Parse(Ui);    
        Aui += Ui;
    }
    catch (System.Exception){
        Console.WriteLine(" ");
        Console.WriteLine("Ошибка в переводе строки в число. Пожалуйста введите число");
        continue;
    }
}

Console.WriteLine($"Точка пересечения двух прямых : y = {Aui[1]} * x + {Aui[0]}, y = {Aui[3]} * x + {Aui[2]}");
/*
int x = 0;
int y = 0;
while(Aui[1] * x + Aui[0] != y){
    x++;
    while(Aui[3] * x + Aui[2] = y){
        y++;
    }
}*/
Console.Write($"Имеет координаты : ({0}, {0})");