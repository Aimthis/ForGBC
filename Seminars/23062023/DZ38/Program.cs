/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/
// Создаем массив на 8-16 чисел и случайными значениями внутри от 0 до 999  
double[] array = new double[new Random().Next(8,17)];
Console.Write("Получен массив содрежащий следующие эллементы: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");

// Вводим переменные для максимального и минимального значения
double max = array[0];
double min = array[array.Length - 1];
// Поиск максимального и минимального элемента массива
for(int j = 0; j < array.Length; j++)
{
    if(min > array[j])
    {
        min = array[j];
    }
    if(max < array[array.Length - (j + 1)])
    {
        max = array[array.Length - (j + 1)];
    }
}
Console.Write("Разница между максимальным значением элемента массива: " + max + " и минимальным: " + min + " равно: " + (max + min));