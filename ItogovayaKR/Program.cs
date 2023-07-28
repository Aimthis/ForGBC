/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/ 
Console.Clear();
Console.WriteLine("Хотите начать ввод данных? Нажмите - Y (да) чтобы начать. Нажмите - N (нет) чтобы завершить");
string inputString = string.Empty;
string value = Console.ReadLine();
while (true)
{
    if(value == "n" || value == "N")
        break;
    if(value == "y" || value == "Y"){
    Console.WriteLine();
        Console.Write("Введите данные : ");
        value = Console.ReadLine();
        inputString += value + "<-*->";
        Console.Clear();
        Console.WriteLine("Желаете ли добавить другие данные? Нажмите - Y (да) чтобы начать. Нажмите - N (нет) чтобы завершить");
    }
    else{
        Console.WriteLine("Пожалуйста нажмите Y или N");
        value = Console.ReadLine();
    }
}
Console.WriteLine(inputString);