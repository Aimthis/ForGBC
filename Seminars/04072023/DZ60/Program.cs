/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

double[,,] make3dMatrix = Array3d();


double[,,] Array3d()
{
    Console.WriteLine("Создан трехмерный массив содержащий следующие значения:");
    // Создаем трехмерный массив на 3-3-3 строк, столбцов, высот и случайными значениями внутри от 0 до 9  
    double[,,] matrix = new double[new Random().Next(3, 4), new Random().Next(3, 4), new Random().Next(3, 4)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(0, 10);
                Console.Write($" {matrix[i, j, k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
    return matrix;
}