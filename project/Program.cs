// В строке, которую вводит пользователь, определите количество слов,
// добавьте в начало строки слово Start и в конец строки слово с;

using System;

class work_1_5
{
    static void Main()
    {
        Console.Write("Введите строку: "); 
        string user = Console.ReadLine(); 

        int count = 1; 
        foreach (char sym in user) 
        { 
            if (sym == ' ') count++; 
        } 
        
        Console.WriteLine($"Изменённая строка: Start {user} End");
        Console.WriteLine($"Количество слов в строке: {count}"); 
    }
}
