// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if(a == 7 || a == 6)
{
    Console.Write("Выходной");
}
else if(a < 6 && a > 0)
{
    Console.Write("Невыходной");
}
else
{
    Console.Write("Пожалуйста введите число от 1 до 7 :");
    a = int.Parse(Console.ReadLine());
    if(a == 7 && a == 6)
    {
        Console.Write("Выходной");
    }
    else if(a < 6 && a > 0)
    {
        Console.Write("Невыходной");
    }
    else
    {
        Console.Write("Обратитесь к комунибудь поумней пожалуйста, или в другой раз.");
    }
}