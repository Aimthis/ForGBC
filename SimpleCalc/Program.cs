// Задача: Создать простой калькулятор на 4 действия - сложения, вычетания, произведения и деления.

// Создаю переменную Ui - User Input с запросом на ввод
// Запрос действия A - action
// Переменная Sui - Second User Input
    Console.Write("Пожалуйста, введите первое число: ");
    double Ui = double.Parse(Console.ReadLine());
    double Sui = 0;
    string a = string.Empty;
while(int.Parse(a[i].ToString()) < 1 || int.Parse(a[i].ToString()) > 4)
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
        break;
}
if(a == 4)
    while(Sui == 0)
    {
        Console.Write("Пожалуйста, введите второе число(не должно быть равно нулю): ");
        Sui = double.Parse(Console.ReadLine());
    }
else
{
    Console.Write("Пожалуйста, введите второе число: ");
    Sui = double.Parse(Console.ReadLine());
    Console.WriteLine(Sui);
}
// Создаем переменную для результата и условия решения в зависимости от выбранного действия А
double res = 0;
switch (a)
{
    case "1":
        res = Ui + Sui;
        break;
    case "2":
        res = Ui - Sui;
        break;
    case "3":
        res = Ui * Sui;
        break;
    case "4":
        res = Ui / Sui;
        break;
    case "+":
        res = Ui + Sui;
        break;
    case "-":
        res = Ui - Sui;
        break;
    case "*":
        res = Ui * Sui;
        break;
    case "/":
        res = Ui / Sui;
        break;
    
    default:
    Console.Write("Возникла не предвиденная ошибка. Возможно введено неизвестное действие.");
        break;
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