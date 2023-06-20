/* Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/
// Создаю переменную Ui - User Input на каждую координату
int UiXa = 0;
int UiYa = 0;
int UiZa = 0;
int UiXb = 0;
int UiYb = 0;
int UiZb = 0;
// Запросы ввода
Console.Write("Пожалуйста, введите координату X первого числа: ");
UiXa = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Y первого числа: ");
UiYa = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Z первого числа: ");
UiZa = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите координату X второго числа: ");
UiXb = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Y второго числа: ");
UiYb = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Z второго числа: ");
UiZb = int.Parse(Console.ReadLine());
// Создание метода
double Rastoynie3D (int x1,int y1,int z1,int x2,int y2,int z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return result;
}
double itog = Math.Round(Rastoynie3D (UiXa, UiYa, UiZa, UiXb, UiYb, UiZb),2);
Console.Write($"Растояние между этим точками {itog}");
