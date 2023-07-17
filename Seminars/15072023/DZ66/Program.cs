/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// Создаю переменную firstNum для M с запросом на ввод
Console.Clear();
int firstNum = StringToInt("Пожалуйста, введите первое натуральное число больше 1: ");

// Создаю переменную secondNum для N с запросом на ввод
Console.Clear();
int secondNum = StringToInt("Пожалуйста, введите второе натуральное число больше первого: ");

Console.Write($"{VyvodSumOtMDoN((uint)firstNum, (uint)secondNum)} ");

uint VyvodSumOtMDoN(uint m, uint n)
{
    uint sum = 0;
    if (n == m)
        return n;
    sum = n + VyvodSumOtMDoN(m, n - 1);
    return sum;
}

int StringToInt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
