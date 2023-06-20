// Запрос первого числа и создание переменной Uia - User input a
Console.Write("Введите первое число: ");
int Uia = int.Parse(Console.ReadLine());
// Запрос второго числа и создание переменной Uib - User input b
Console.Write("Введите второе число: ");
int Uib = int.Parse(Console.ReadLine());
if(Uia>Uib)
{
    Console.WriteLine($"Первое число - {Uia} больше второго - {Uib}");
}
else if(Uia == Uib)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine($"Второе число - {Uib} больше первого - {Uia}");
}