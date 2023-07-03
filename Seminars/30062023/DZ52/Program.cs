/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

// Создаем двумерный массив на 8-16 строк, столбцов и случайными значениями внутри от 0 до 999  
Console.Clear();
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
Console.WriteLine(" ");
double[,] matrix = new double[new Random().Next(8,17),new Random().Next(8,17)];
for(int i = 0; i < matrix.GetLength(0);i++){
    for(int j = 0; j < matrix.GetLength(1);j++){
        matrix[i,j] = new Random().Next(0,1000);
        Console.Write(" " + matrix[i,j]);
    }
    Console.WriteLine(" ");
}
Console.WriteLine(" ");
Console.WriteLine($"Массив содержит {matrix.GetLength(1)} столбцов");
// Создаю переменные для подсчета результата.
string itog = "|";
double SredneePoStolbcu = 0;
// Цикл для подсчета среднеарифметического каждого столбца
for(int i = 0;i<matrix.GetLength(1);i++){
    for(int j=0;j<matrix.GetLength(0);j++){
        SredneePoStolbcu += matrix[j,i];
    }
    SredneePoStolbcu /= matrix.GetLength(1);
    SredneePoStolbcu = Math.Round(SredneePoStolbcu , 1);
    itog += $"| {i+1}. {SredneePoStolbcu} |";
    SredneePoStolbcu = 0;
}
itog += "|";
Console.WriteLine("Среднее арифметическое каждого столбца : " + itog);
