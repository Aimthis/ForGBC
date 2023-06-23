/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/
// Создаю переменную Ui - User Input с запросом на ввод
    Console.Write("Пожалуйста, введите число, которое мы ищем в массиве: ");
    int Ui = int.Parse(Console.ReadLine());
// Создаем случайный массив    
int[] array = new int[8];
for(short i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,3);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
// ищем в цикле наше число в массиве
for(int j = 0; j < array.Length; j++)
{
    if(array[j] == Ui)
    {
        Console.Write("Есть такая цифра в этом массиве");
        break;
    }
    if(j == array.Length -1)
    {
        Console.Write("Нет такой цифры в этом массиве");
    }
}


