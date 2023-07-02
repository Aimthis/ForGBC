/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

// Создаю переменные для строк и колонок - rows и colums соответственно с запросом на ввод
Console.Clear();
Console.Write("Пожалуйста, введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите количество колонок: ");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
int[,] matrix = new int[rows,colums];
for(int i = 0; i < rows; i++){
    Console.WriteLine();
    for(int j = 0; j < colums; j++){
        matrix[i,j] = new Random().Next(-99,100);
        Console.Write(" " + matrix[i,j]);
    }
}
int sum = 0;
for(int i = 0;i < matrix.GetLength(1) ||i < matrix.GetLength(0);i++){
    sum += matrix[i,i];    
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Сумма элементов на главной диагонали");
Console.Write(sum);