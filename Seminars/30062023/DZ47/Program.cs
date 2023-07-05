/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
// Создаю переменные для строк и колонок - rows и colums соответственно с запросом на ввод
Console.Clear();
int rows = StringToInt("Пожалуйста, введите количество строк: ");
int colums = StringToInt("Пожалуйста, введите количество столбцов: ");
Array2d(rows,colums);

int StringToInt(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[,] Array2d(int columnsLenght, int rowLenght){
    Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
    double[,] matrix = new double[rows,colums];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < colums; j++){
            matrix[i,j] = new Random().NextDouble();
            Console.Write(" " + matrix[i,j]);
        }
        Console.WriteLine();
    }
    return matrix;
}