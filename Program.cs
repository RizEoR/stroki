using System;

public class StringComparisonExample
{
    public static void Main(string[] args)
    {
        // Ввод строк с клавиатуры
        Console.WriteLine("Введите первую строку:");
        string a = Console.ReadLine(); 

        Console.WriteLine("Введите вторую строку:");
        string a1 = Console.ReadLine(); 

        Console.WriteLine("Введите строку для поиска подстроки:");
        string a2 = Console.ReadLine(); 

        Console.WriteLine("Введите подстроку для поиска:");
        string b = Console.ReadLine(); 


        // Compare() - сравнение с учетом регистра
        int c = string.Compare(a, a1); // Сравниваем строки a и a1 с учетом регистра
        Console.WriteLine($"\n Сравниваем строки  используя Compare ({a}, {a1}): {c}"); // Выводим результат сравнения
        if (c == 0)
        {
            Console.WriteLine("Строки идентичны."); // Строки одинаковые
        }
        else
        {
            Console.WriteLine("Строки не идентичны."); // Строки разные
        }

        // CompareOrdinal() - сравнение основан на чис знач юникода для каждого сим
        int c1 = string.CompareOrdinal(a, a1); 
        Console.WriteLine($"\n сравнение используя CompareOrdinal ({a}, {a1}): {c1}"); // Выводим результат сравнения
        if (c1 == 0)
        {
            Console.WriteLine("Строки идентичны."); 
        }
        else
        {
            Console.WriteLine("Строки не идентичны."); 
        }

        // Equals() - сравнение без учета регистра
        bool b2Equals = a.Equals(a1, StringComparison.OrdinalIgnoreCase); // StringComparison.OrdinalIgnoreCaseуказывает на то, как следует проводить сравнение (без учета регистра) 
        Console.WriteLine($"\nСравниваем строки используя Equals без учета регистра: {b2Equals}"); // Выводим результат сравнения (true/false)
        if (b2Equals)
        {
            Console.WriteLine("Строки идентичны (без учета регистра)."); 
        }
        else
        {
            Console.WriteLine("Строки не идентичны (без учета регистра)."); 
        }
        // Операторы == и != - сравнение с учетом регистра
        bool c3 = a == a1; // Сравниваем строки a и a1 с учетом регистра
        Console.WriteLine($"\n  Сравниваем строки {a} методом == {a1}: {c3}"); // Выводим результат сравнения (true/false)
        if (c3)
        {
            Console.WriteLine("Строки идентичны."); 
        }
        else
        {
            Console.WriteLine("Строки не идентичны."); 
        }
        bool c4 = a != a1; // Сравниваем строки a и a1 с учетом регистра
        Console.WriteLine($"\n  Сравниваем строки {a} методом != {a1}: {c4}"); // Выводим результат сравнения (true/false)
        if (c4)
        {
            Console.WriteLine("Строки не идентичны."); 
        }
        else
        {
            Console.WriteLine("Строки идентичны."); 
        }

        // IndexOf() - поиск подстроки
        int d = a2.IndexOf(b); // Ищем подстроку b в строке a2
        Console.WriteLine($"\n поиск подстроки ({b}): {d}"); // Выводим позицию найденной подстроки (-1, если не найдена)
        if (d != -1)
        {
            Console.WriteLine($"Подстрока {b} найдена в позиции {d}."); 
        }
        else
        {
            Console.WriteLine($"Подстрока {b} не найдена."); 
        }

        // Contains() - проверка на наличие подстроки
        bool d1 = a2.Contains(b); // Проверяем, содержит ли строка a2 подстроку b
        Console.WriteLine($"\n проверка на наличие подстроки ({b}): {d1}"); // Выводим результат проверки (true/false)
        if (d1)
        {
            Console.WriteLine($"Строка содержит подстроку {b}."); 
        }
        else
        {
            Console.WriteLine($"Строка не содержит подстроку {b}."); 
        }
    }
}
