/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/
// Создаю переменную Ui - User Input с запросом на ввод
    Console.Write("Пожалуйста, введите десятичное число: ");
    int Ui = int.Parse(Console.ReadLine());
    string result = string.Empty;
    int step = 0;
while(Ui != 0){
    step = Ui % 2;
    Ui /= 2;
    result = step + result;   
}
Console.Write(result);