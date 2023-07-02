/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/

// Создаю переменные для строк и колонок - rows и colums соответственно с запросом на ввод
Console.Clear();
Console.Write("Пожалуйста, введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите количество колонок: ");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
// Создаю двумерный массив по полученным значениям строк и колонок
int[,] matrix = new int[rows,colums];
for(int i = 0; i < rows; i++){
    Console.WriteLine();
    for(int j = 0; j < colums; j++){
        matrix[i,j] = new Random().Next(-99,100);
        Console.Write(" " + matrix[i,j]);
    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Квадраты элементов массива с четными индексами");
// Ищу элементы с четными строками и столбцами соответственно с четными индексами и меняю их значения на их квадраты
for(int i = 1; i < rows; i += 2){
    for(int j = 1; j < colums; j+= 2){
        matrix[i,j] *= matrix[i,j];
        Console.Write(" " + matrix[i,j]);
    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Массив после замены");
// Вывод полученного массива в консоль
for(int i = 0; i < rows; i++){
    Console.WriteLine();
    for(int j = 0; j < colums; j++){
        Console.Write(" " + matrix[i,j]);
    }
}