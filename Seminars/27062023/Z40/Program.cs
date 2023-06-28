// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Создаю переменную Uia - User Input1 с запросом на ввод
    Console.Write("Пожалуйста, введите первое число: ");
    int Uia = int.Parse(Console.ReadLine());
    Console.Write("Пожалуйста, введите второе число: ");
    int Uib = int.Parse(Console.ReadLine());
    Console.Write("Пожалуйста, введите третье число: ");
    int Uic = int.Parse(Console.ReadLine());
if(Uia + Uib > Uic && Uia + Uic > Uib && Uib + Uic > Uia)
    Console.Write("С этими сторонами существует треугольник");
else
    Console.Write("С этими сторонами нет треугольника");