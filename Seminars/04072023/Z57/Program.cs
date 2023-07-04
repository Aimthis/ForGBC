/*Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается 
элемент входных данных.*/

// Создаем двумерный массив на 8-16 строк, столбцов и случайными значениями внутри от 0 до 9  
Console.Clear();
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
Console.WriteLine(" ");
double[,] matrix = new double[new Random().Next(8,17),new Random().Next(8,17)];
for(int i = 0; i < matrix.GetLength(0);i++){
    for(int j = 0; j < matrix.GetLength(1);j++){
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(" " + matrix[i,j]);
    }
    Console.WriteLine(" ");
}
Console.WriteLine(" ");
