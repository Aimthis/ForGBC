/*Задача 62: Заполните спирально массив 4 на 4.*/

double[,] matrix = Array2dSpiralFill();

// Вывод полученного массива в консоль
for(int i = 0; i < matrix.GetLength(0); i++){
    Console.WriteLine();
    for(int j = 0; j < matrix.GetLength(1); j++){
        Console.Write(" " + matrix[i,j]);
    }
}

double[,] Array2dSpiralFill()
{
    Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
    // Создаем двумерный массив на 4-4 строк, столбцов и значениями внутри по спирали от 1 с шагом в 1
    double[,] matrix = new double[new Random().Next(4, 5), new Random().Next(4, 5)];
    int fillValue = 1;
    int size = matrix.GetLength(0);
    int row = 0;
    int column = 0;
    while (size != 0)
    {
        for (int i = column; i < size; i++)
        {
            matrix[row, i] = fillValue;
            fillValue++;
        }
        row++;
        size--;
        for (int j = row; j < size; j++)
        {
            matrix[j, size] = fillValue;
            fillValue++;
        }
        row = size;
        for (int k = size - 1; k > row - size; k--)
        {
            matrix[row, k] = fillValue;
            fillValue++;
        }
        row--;
        size--;
        for (int l = row; l > column+1; l--)
        {
            matrix[l, column] = fillValue;
            fillValue++;
        }
        column++;
        row=column;
    }
    return matrix;
}