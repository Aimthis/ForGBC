// Задача: Создать простой калькулятор на 4 действия - сложения, вычетания, произведения и деления.

// Создаю переменную Ui - User Input с запросом на ввод
// Переменная Sui - Second User Input
// Запрос действия A - action
    Console.Clear();
    Console.Write("Пожалуйста, введите первое число: ");
    double Ui = double.Parse(Console.ReadLine());
    double Sui = 0;
    string a = "0";
while(int.Parse(a[0].ToString()) < 1 || int.Parse(a[0].ToString()) > 4)
{
    Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. + (Сложение)");
        Console.WriteLine("2. - (Вычетание)");
        Console.WriteLine("3. * (Произведение)");
        Console.WriteLine("4. / (Деление)");
    a = Console.ReadLine();
    // Распределяю ввод на значения по цифрам и символам
    bool Check = int.TryParse(a, out var num);
    if(Check == false)
        {
            if(a == "/" || a == "Деление" || a == "деление")
                a = "4";   
            else
            {
                Console.WriteLine("Пожалуйста введите известное действие");
                a = "0";
            }
        }
    else
        {
            if(a.Length != 1)
                {
                Console.WriteLine("Пожалуйста введите известное действие");
                a = "0";
                }       
        }        
}
if(a == "4" || a == "/" || a == "Деление" || a == "деление")
    while(Sui == 0)
    {
        Console.Write("Пожалуйста, введите второе число(не должно быть равно нулю): ");
        Sui = double.Parse(Console.ReadLine());
    }
else
{
    Console.Write("Пожалуйста, введите второе число: ");
    Sui = double.Parse(Console.ReadLine());
}
// Создаем переменную для результата и условия решения в зависимости от выбранного действия А
double res = 0;
if (a == "1" || a == "+" || a == "Сложение" || a == "cложение")
        res = Ui + Sui;
else if (a == "2" || a == "-" || a == "Вычетание" || a == "вычетание")
        res = Ui - Sui;
else if (a == "3" || a == "*" || a == "Произведение" || a == "произведение")
        res = Ui * Sui;
else if (a == "4" || a == "/" || a == "Деление" || a == "деление" && Sui != 0)
        res = Ui / Sui;
else
{
    Console.WriteLine("Возникла не предвиденная ошибка.");
    Environment.Exit(0);
}
Console.Write("Ответ : " + res);






















/*using System;
using System.Text;
public class SimpleCalc
{
    public static void Main()
    {
        ConsoleKeyInfo Ui;
        Console.WriteLine("-=Простой калькулятор=-");
        Console.WriteLine("Введите число:");
        
        do
        {
            ConsoleKey Ui = Console.ReadKey().Key;
            StringBuilder output = new StringBuilder(
                       String.Format("{0}", input.Key.ToString()));
            Console.Write(Ui);
            switch(Ui)
            {
                case
            }
            if((ConsoleKey.Enter) != 0)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. + (Сложение)");
                Console.WriteLine("2. - (Вычетание)");
                Console.WriteLine("3. * (Произведение)");
                Console.WriteLine("4. / (Деления)");

                while(ConsoleModifiers.D1 || ConsoleModifiers.D2 || ConsoleModifiers.D3 || ConsoleModifiers.D4)
                {
                    Console.WriteLine("Введите второе число:");
                }
            } 
            if((ConsoleModifiers.Backspace) != 0) Console.Write("\b");
            Console.WriteLine(Ui.Key.ToString());

        } while (Ui.Key != ConsoleKey.Escape);     
    }
}




/*public class ConsoleKeyExample
{
   public static void Main()
   {
      ConsoleKeyInfo input;
      do {
         Console.WriteLine("Press a key, together with Alt, Ctrl, or Shift.");
         Console.WriteLine("Press Esc to exit.");
         input = Console.ReadKey(true);

         StringBuilder output = new StringBuilder(
                       String.Format("You pressed {0}", input.Key.ToString()));
         bool modifiers = false;

         if ((input.Modifiers & ConsoleModifiers.Alt) == ConsoleModifiers.Alt) {
            output.Append(", together with " + ConsoleModifiers.Alt.ToString());
            modifiers = true;
         }
         if ((input.Modifiers & ConsoleModifiers.Control) == ConsoleModifiers.Control)
         {
            if (modifiers) {
               output.Append(" and ");
            }
            else {
               output.Append(", together with ");
               modifiers = true;
            }
            output.Append(ConsoleModifiers.Control.ToString());
         }
         if ((input.Modifiers & ConsoleModifiers.Shift) == ConsoleModifiers.Shift)
         {
            if (modifiers) {
               output.Append(" and ");
            }
            else {
               output.Append(", together with ");
               modifiers = true;
            }
            output.Append(ConsoleModifiers.Shift.ToString());
         }
         output.Append(".");
         Console.WriteLine(output.ToString());
         Console.WriteLine();
      } while (input.Key != ConsoleKey.Escape);
   }
}*/
// The output from a sample console session might appear as follows:
//       Press a key, along with Alt, Ctrl, or Shift.
//       Press Esc to exit.
//       You pressed D.
//
//       Press a key, along with Alt, Ctrl, or Shift.
//       Press Esc to exit.
//       You pressed X, along with Shift.
//
//       Press a key, along with Alt, Ctrl, or Shift.
//       Press Esc to exit.
//       You pressed L, along with Control and Shift.
//
//       Press a key, along with Alt, Ctrl, or Shift.
//       Press Esc to exit.
//       You pressed P, along with Alt and Control and Shift.
//
//       Press a key, along with Alt, Ctrl, or Shift.
//       Press Esc to exit.
//       You pressed Escape.