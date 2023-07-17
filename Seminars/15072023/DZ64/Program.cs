/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/
// Создаю переменную num для N с запросом на ввод
Console.Clear();
int num = StringToInt("Пожалуйста, введите натуральное число больше 1: ");
VyvodOtOdnogoDoN((uint)num);

uint VyvodOtOdnogoDoN(uint n)
{
    if (n == 0)
        return 1;
    Console.Write($"{n} ");
    VyvodOtOdnogoDoN(n - 1);
    return 1;
}

int StringToInt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}