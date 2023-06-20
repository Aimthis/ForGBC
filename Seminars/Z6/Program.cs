Console.Write("Введи число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;
while (a != 0)
{
    b = (b * 10) + (a % 10); 
    a = a / 10;
}
Console.Write(b);