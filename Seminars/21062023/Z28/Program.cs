/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

// Создаю переменную Ui - User Input с запросом на ввод
    Console.Write("Пожалуйста, введите число: ");
    int Ui = int.Parse(Console.ReadLine());
// Задаю метод факториала
    double GetFactorial(int a)
    {
        int result = 1;
        for(int i = 1; i < a; i++)
        {
            result *= i;
        }
    }
// Вывод в консоль
    Console.Write(GetFactorial(Ui));
    
