/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/
// Создаю переменную firstNum для M с запросом на ввод
Console.Clear();
int firstNum = StringToInt("Пожалуйста, введите первое натуральное число больше 1: ");

// Создаю переменную secondNum для N с запросом на ввод
Console.Clear();
int secondNum = StringToInt("Пожалуйста, введите первое натуральное число больше 1: ");

VyvodOtMDoN((uint)firstNum, (uint)secondNum);

uint VyvodOtMDoN(uint m, uint n)
{
    if (n == m - 1)
        return n;
    VyvodOtMDoN(m,n - 1);
    Console.Write($"{n} ");
    return 1;
}

int StringToInt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
