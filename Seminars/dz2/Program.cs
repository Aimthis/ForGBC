int [] Ui = new int[3];
Console.Write("Введите первое число: ");
Ui[0] = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
Ui[1] = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
Ui[2] = int.Parse(Console.ReadLine());
int max = Ui[2];
Console.WriteLine("Сейчас выясню какое же больше");
for(int i = 0; i<Ui.Length; i++)
{
    if(max>Ui[i])
{
}
else
{
    max = Ui[i];
    Console.WriteLine("Сравниваю подождите");
    }
}
Console.WriteLine($"Всё проверил - {max} самое большое. Простите за ожидание.");
