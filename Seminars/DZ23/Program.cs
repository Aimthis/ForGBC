/* 
Задача 23: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
*/
// Создаю переменную Ui - User Input
int Ui = 0;
// Запрос на ввод "N"
while(Ui <= 0)
{
Console.Write("Пожалуйста, введите целое число больше нуля: ");
Ui = int.Parse(Console.ReadLine());
}
// Добавляю метод на подсчет куба числа
double Cube (int some)
{
    double result = some * some * some;
    return result;
}
// Цикл на вывод кубов до введенного числа
for(int i = 1; i < Ui; i++)
{
    Console.Write($"{Cube(i)}, ");
}
Console.Write(Cube(Ui));