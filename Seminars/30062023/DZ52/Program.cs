/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

// Создаем двумерный массив на 8-16 строк, столбцов и случайными значениями внутри от 0 до 999  
Console.Clear();
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
Console.WriteLine(" ");
double[,] matrix = new double[new Random().Next(8,17),new Random().Next(8,17)];
// Создаю переменные для подсчета результата.
string itog = string.Empty;
double SredneePoStolbcu = 0;
for(int i = 0; i < matrix.GetLength(1);i++){
    for(int j = 0; j < matrix.GetLength(0);j++){
        matrix[i,j] = new Random().Next(0,1000);
        SredneePoStolbcu+= matrix[i,j];
        Console.Write(" " + matrix[i,j]);
    }
    SredneePoStolbcu/=matrix.GetLength(0);
    itog += SredneePoStolbcu;
}
Console.WriteLine(" ");
Console.WriteLine($"Массив содержит {matrix.GetLength(1)} столбцов");
Console.WriteLine("Среднее арифметическое каждого столбца :" + itog);