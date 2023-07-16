/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
// Создаю переменную num для N с запросом на ввод
Console.Clear();
int num = StringToInt("Пожалуйста, введите натуральное число больше 1: ");
VyvodOtOdnogoDoN((uint)num);

uint VyvodOtOdnogoDoN(uint n)
{
    if (n == 0)
        return 1;
    VyvodOtOdnogoDoN(n - 1);
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
