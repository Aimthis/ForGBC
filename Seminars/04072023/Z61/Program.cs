/*Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника*/
// Создаю переменную для N с запросом на ввод
Console.Clear();
int rowsN = StringToInt("Пожалуйста, введите количество строк треугольника Паскаля: ");
double[,] pascalData = new double[rowsN,rowsN+1];
pascalData[0,0] = 1;
Console.WriteLine(pascalData[0,0] + " ");
pascalData[1,0] = 1;
pascalData[1,1] = 1;
Console.WriteLine(pascalData[1,0] + " " + pascalData[1,1]);
for(int i=2;i<pascalData.GetLength(0);i++){
    for(int j=1; j<pascalData.GetLength(1); j++){
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
