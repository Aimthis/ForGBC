/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
// Создаю переменную firstNum для A с запросом на ввод
Console.Clear();
int firstNum = StringToInt("Пожалуйста, введите первое натуральное число: ");

// Создаю переменную secondNum для B с запросом на ввод
Console.Clear();
int secondNum = StringToInt("Пожалуйста, введите второе натуральное число для возведения в степень: ");

Console.Write(PowerAOfBByRecursion(firstNum, secondNum));

int PowerAOfBByRecursion(int a, int b)
{
    if (b == 1)
        return a;
    b--;
    int result = a*PowerAOfBByRecursion(a, b);
    return result;
}

int StringToInt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
