// Запрос числа и создание переменной Ui - User input 
Console.Write("Введите целое число: ");
int Ui = int.Parse(Console.ReadLine());
Console.Write("Ряд чётных чисел к этому числу: ");
for(int i = 2; i < Ui; i = (i + 2))
{
    Console.Write($"{i}, ");
}
int res = (Ui % 2);
if(res == 0)
{
    Console.Write($"{Ui}, досвидания.");
}
else
{
    Console.Write("досвидания.");
}
