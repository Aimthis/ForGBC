/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
// Создаю переменную firstNum для M с запросом на ввод
Console.Clear();
int firstNum = StringToInt("Пожалуйста, введите первое натуральное число M для функции Аккермана: ");

// Создаю переменную secondNum для N с запросом на ввод
Console.Clear();
int secondNum = StringToInt("Пожалуйста, введите второе натуральное число N для функции Аккермана: ");

Console.Write(Akkermana((long)firstNum,(long)secondNum));

long Akkermana(long n, long m)
{
    if (n == 0)
        return m + 1;
    else
    if (n != 0 && m == 0)
        return Akkermana(n - 1, 1);
    else
        return Akkermana(n - 1, Akkermana(n, m - 1));
}


int StringToInt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
