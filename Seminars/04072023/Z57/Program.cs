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
int Ui;
do{
Console.WriteLine(" ");
// Создаю переменную Ui - User Input с запросом на ввод и счетчик
    Console.Write("Пожалуйста, введите число(10 для выхода): ");
    Ui = Convert.ToInt32(Console.ReadLine());
    int count = 0;
for(int i = 0; i < matrix.GetLength(0);i++){
    for(int j = 0; j < matrix.GetLength(1);j++){
        if(Ui == matrix[i,j])
            count++;
    }
}
Console.WriteLine("Данное число встречается " + count + " раз");
}
while(Ui != 10);