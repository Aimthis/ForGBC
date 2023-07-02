/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
// Создаю переменные для строк и колонок - rows и colums соответственно с запросом на ввод
Console.Clear();
Console.Write("Пожалуйста, введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите количество колонок: ");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
double[,] matrix = new double[rows,colums];
for(int i = 0; i < rows; i++){
    Console.WriteLine();
    for(int j = 0; j < colums; j++){
        matrix[i,j] = new Random().NextDouble(-1,2);
        Console.Write(" " + matrix[i,j]);
    }
}