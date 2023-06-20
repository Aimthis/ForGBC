// Запрос числа и создание переменной Ui - User input 
Console.Write("Введите целое число для проверки на чётность: ");
int Ui = int.Parse(Console.ReadLine());
int res = (Ui % 2);
if(res == 1)
{
    Console.Write("Нечётное");
}
else
{
    Console.Write("Чётное");
}