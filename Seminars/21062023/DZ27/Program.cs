// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Создаю переменную Ui - User Input с запросом на ввод
    Console.Write("Пожалуйста, введите число: ");
    string Ui = Console.ReadLine();
    int result = 0;
    // Распределяю ввод на разные решения
    // Первый вариант решения для значений в пределах Int
    bool math = int.TryParse(Ui, out var num);
    if(math == true)
    {
        while(num != 0)
        {
            result += num%10;
            num /= 10;
        }
        Console.Write("В этом числе сумма цифр: " + result);
    }
    // Второй вариант решения для значений выше
    else
    {   
        for(int i = 0; i < Ui.Length; i++)
        {
            result += int.Parse(Ui[i].ToString());
        }
        Console.Write("В этом числе сумма цифр: " + result);
    }