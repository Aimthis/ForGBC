/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
// Создаю переменную Ui - User Input с запросом на ввод
    Console.Write("Пожалуйста, введите число: ");
    string Ui = Console.ReadLine();
    int count = 0;
// Распределяю ввод на разные решения
    bool math = int.TryParse(Ui, out var num);
    if(math == true)
    {
        while(num != 0)
        {
            num /= 10;
            count ++;
        }
        Console.Write("В этом числе " + count + " цифр.");
    }
    else
    {
        Console.Write("В этом числе " + Ui.Length + " цифр.");
    }