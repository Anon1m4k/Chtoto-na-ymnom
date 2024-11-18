using System;
using System.Collections.Generic;


namespace Какая_то_домашняя_работа
{
    internal class Program
    {
        static void Main()
        {
            List<string> groups = new List<string>() { "П-10", "П-21", "П-40", "П-32", "Ю-11", "Ю-20", "Ю-30", "Б-10", "Б-20", "Ю-40" }; 
           
            Console.WriteLine("Введите номер курса: "); 
            string input = Console.ReadLine();
            
            foreach (string group in groups)
            {
                if (group.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(String.Join(",", group));
                }
                else
                {
                    Console.WriteLine("Нет такого курса!");
                    Console.ReadKey();
                }                
            }           
            
        }
    }
}
