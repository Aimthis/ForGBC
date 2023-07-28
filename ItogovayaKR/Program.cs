/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/ 
Console.Clear();
Console.WriteLine("Хотите начать ввод данных? Нажмите - Y (да) чтобы начать. Нажмите - N (нет) чтобы завершить");
Console.WriteLine("Для случайной генерации данных нажмите - R");
string inputString = string.Empty;
string value = Console.ReadLine();
Random random = new Random();
while (true)
{
    if(value == "r" || value == "R")
        inputString += RandomString(random.Next(1,10)) + "|";
        Console.Clear();
        Console.WriteLine("Добавлены случайные данные : " + inputString);
    if(value == "y" || value == "Y"){
    Console.WriteLine();
        Console.Write("Введите данные : ");
        value = Console.ReadLine();
        inputString += value + "|";
        Console.WriteLine("Добавлены следующие данные : " + inputString);
        Console.Clear();
        Console.WriteLine("Желаете ли добавить другие данные? Нажмите - Y (да) чтобы добавить в ручную. Нажмите - N (нет) чтобы завершить");
        Console.WriteLine("Нажмите - R для генерации случайных данных");
        value = Console.ReadLine();
        continue;
    }
    if(value == "n" || value == "N")
        break;
    else{
        Console.WriteLine("Желаете ли добавить другие данные? Нажмите - Y (да) чтобы добавить в ручную. Нажмите - N (нет) чтобы завершить");
        Console.WriteLine("Нажмите - R для генерации случайных данных");
        Console.WriteLine("Пожалуйста нажмите Y, N или R");
        value = Console.ReadLine();
    }
}

string[] arrayOfStrings = inputString.Split(new char[] { '|' });
string outputString = string.Empty;
int count = 1;
Console.Clear();
Console.WriteLine("Получен следующий массив из данных : ");
for (int i = 0; i < arrayOfStrings.Length-1; i++)
{
    Console.Write(" | " + arrayOfStrings[i]);
    if(arrayOfStrings[i].Length < 4){
    outputString += count + ". " + arrayOfStrings[i] + "; ";
    count ++;
    }
}
Console.Write(" |");
Console.WriteLine();
Console.WriteLine("Среди полученных данных следующие состоят из 3 и меньше символов : " + outputString);
string RandomString(int length)
{
    const string chars = "abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
}