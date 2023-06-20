class Program
{
    static void Main(string[] args)
{  
// Создаю переменную Ui - User Input
string Ui = string.Empty;

    Console.Write("Пожалуйста, введите римское число: ");
    Ui = (Console.ReadLine());

        
    Dictionary<char, int> romanDigits = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    int RomanToInt(string s)
    {
        int i, result = 0;

        for(i = 0; i < s.Length - 1; i++)
        {
            if(s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
            {
                result += romanDigits[s[i + 1]] - romanDigits[s[i]];
                i++;
            }
            else if(s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
            {
                result += romanDigits[s[i + 1]] - romanDigits[s[i]];
                i++;
            }
            else if(s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
            {
                result += romanDigits[s[i + 1]] - romanDigits[s[i]];
                i++;
            }
            else
                result += romanDigits[s[i]];
        }

        return i < s.Length ? result + romanDigits[s[s.Length - 1]] : result;
    }


    int last = RomanToInt(Ui);
    Console.WriteLine("Соответствующее число : " + last);
    }
}