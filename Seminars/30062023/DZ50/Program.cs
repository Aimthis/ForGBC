/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

// Создаем двумерный массив на 8-16 строк, столбцов и случайными значениями внутри от 0 до 999 по методу Array2d  
double[,] matrix = Array2d();
// Создаю переменные для поиска строки и столбца в массиве с запросом на ввод
Console.Clear();
int searchString = StringToInt("Пожалуйста, введите строку: ");;
Console.WriteLine(" ");
int searchColumn = StringToInt("Пожалуйста, введите столбец: ");;
ShowCellValueOfArray2d(searchString,searchColumn,matrix);

void ShowCellValueOfArray2d(int row,int column,double[,] array){
    try
    {
        Console.WriteLine($"Элемент в строке {row} и столбце {column} имеет значение : " + array[row, column]);
    }
    catch (System.Exception)
    {
        Console.WriteLine("В массиве нет такого элемента");
        Environment.Exit(1);
    }

}

int StringToInt(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[,] Array2d()
{
    Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
    // Создаем двумерный массив на 8-16 строк, столбцов и случайными значениями внутри от 0 до 999  
    double[,] matrix = new double[new Random().Next(8, 17), new Random().Next(8, 17)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 1000);
        }
    }
    return matrix;
}