/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

// Создаю строковую переменную Aui - all users input для сбора данных и Ui - user input для ввода
string Aui = string.Empty;
string Ui = string.Empty;

// Создаю запрос на ввод в цикле до ввода 'q'
while(Ui != "q"){
    Console.Clear();
    Console.WriteLine("Введите несколько чисел.");
    Console.WriteLine("Для завершения ввeдите 'q'");
    Console.Write("Введите число:");
    Ui = Console.ReadLine();
    Aui += Ui + " ";
}
// Создаю цикл для определения количества положительных чисел
int Check = 0;
string Positive = string.Empty;
int count = 0;
Console.WriteLine("Среди ввода есть следующие положительные числа :");
for(int i = 0; i < Aui.Length;i++){
    Ui = string.Empty;
    Ui += Aui[i];
    if(Ui == "-"){
        for(int j = i + 1;j < Aui.Length;j++){
            try{
                Check = int.Parse(Ui);    
            }
            catch (System.Exception){
                i = j;
                Check = 0;
                break;
            }
        }
    }
    else if(Ui == "0" || Ui == "1" || Ui == "2" || Ui == "3" || Ui == "4" || Ui == "5" || Ui == "6" || Ui == "7" || Ui == "8" || Ui == "9"){
        Check = int.Parse(Ui);
        Positive += Check;
        Ui = string.Empty;
        Ui += Aui[i + 1];
        if(Ui == " ")
            Positive += " ";
        Check = 0;
    }
}
for(int k = 0;k < Positive.Length; k++){
    Ui = string.Empty;
    Ui += Positive[k];
    if(Ui == " "){
        count++;
        Console.Write(" ");
    }
    else
        Console.Write(Positive[k]);        
}
Console.Write("Введено " + count + " положительных чисел");