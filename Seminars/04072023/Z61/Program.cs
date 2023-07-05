/*Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника*/
// Создаю переменную для N с запросом на ввод
Console.Clear();
int rowsN = StringToInt("Пожалуйста, введите количество строк треугольника Паскаля: ");
double[,] pascalData = new double[rowsN,rowsN+1];
pascalData[0,rowsN/2] = 1;
Console.WriteLine(pascalData[0,rowsN/2] + " ");
pascalData[1,rowsN/2] = 1;
pascalData[1,rowsN/2+1] = 1;
Console.WriteLine(pascalData[1,rowsN/2] + " " + pascalData[1,rowsN/2+1]);
for(int i=2;i<pascalData.GetLength(0);i++){
    pascalData[i,rowsN/2-i] = 1;
    for(int j=rowsN/2; j<pascalData.GetLength(1); j++){
    pascalData[i,j]+=pascalData[i-1,j]+pascalData[i-1,j-1];
    Console.Write(pascalData[i,j] + " ");
    }
    Console.WriteLine();
}








int StringToInt(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
