/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/


// Создаем двумерный массив на 4-6 строк, столбцов и случайными значениями внутри от 0 до 9  
Console.Clear();
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
Console.WriteLine(" ");
double[,] matrix = new double[new Random().Next(4,7),new Random().Next(4,7)];
for(int i = 0; i < matrix.GetLength(0);i++){
    for(int j = 0; j < matrix.GetLength(1);j++){
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(" " + matrix[i,j]);
    }
    Console.WriteLine(" ");
}
// Ищу минимальные значения
int min = 10;
for(int i = 0; i < matrix.GetLength(0);i++){
    for(int j = 0; j < matrix.GetLength(1);j++){
        if(min > matrix[i,j])
            min = matrix[i,j];
        }
}
// Cчитаю количество строк и столбцов с минимальным значением
int strsToCut = 0;
int columsToCut = 0;
string minposition = string.Empty;
for(int i = 0; i < matrix.GetLength(0);i++){
    for(int j = 0; j < matrix.GetLength(1);j++){
        if(min == matrix[i,j]){
            strsToCut++;
            columsToCut++;
            minposition += i + j;
        }
    }
}
double[,] newMatrix = new double[matrix.GetLength(0)-columsToCut,matrix.GetLength(1)-strsToCut];
while(minposition != null){
int minPositionOfStr = Convert.ToInt32(minposition[0]);
int minPositionOfCol = Convert.ToInt32(minposition[1]);
for(int i = 0; i < matrix.GetLength(0);i++){
    for(int j = 0; j < matrix.GetLength(1);j++){
        if(minPositionOfStr == i){
        }
        for(int k = 0; k < newMatrix.GetLength(0);k++){
            if(min != matrix[i,k])
                newMatrix[j,k] = matrix[i,k];
            else

        }                        
        
            
    }
}
}