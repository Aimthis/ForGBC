/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
// Создаю переменную num для N с запросом на ввод
Console.Clear();
int num = StringToInt("Пожалуйста, введите натуральное число больше 1: ");
Console.Write(SumOfDigitsInNumber(num));

int SumOfDigitsInNumber(int x)
{
    if (x == 0)
        return 0;
    int result = x % 10 + SumOfDigitsInNumber(x / 10);
    return result;
}

int StringToInt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}