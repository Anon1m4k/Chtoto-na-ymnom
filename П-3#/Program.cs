using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Сначала перепишу классную работу

namespace П_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> College = new Dictionary<string, int>(); //пустой словарь сложнаааа
            //var College = new Dictionary<string, int>(); пустой словарь просто

            Console.WriteLine(College.Count); //вывод количества групп

            College.Add("П-10", 100);
            College.Add("П-20", 200); //добавление групп
            College.Add("П-30", 300);
            College.Add("П-40", 400);

            Console.WriteLine(College.Count); //вывод количества групп

            if (College.ContainsKey("П-11")) //проверка наличия пары по ключу
            {
                Console.WriteLine("Группа П-11 уже есть");
            }
            else
            {
                College["П-11"] = 110; //если такой пары нет, то добавление её
            }

            foreach (KeyValuePair<string, int> pair in College) //перебор всех пар(pair) в College
            {
                Console.WriteLine(pair.Key + " " + pair.Value); //вывод всех пар
            }

            Console.WriteLine("Есть ли группа П-10 в колледже? "+College.ContainsKey("П-10")); //проверка наличия пары по ключу
            Console.WriteLine("Есть ли группа П-11 в колледже? "+College.ContainsKey("П-11"));

            College.Remove("П-10"); //удаление группы

            foreach (KeyValuePair<string, int> pair in College) //повторный перебор всех пар(pair) в College
            {
                Console.WriteLine(pair.Key + " " + pair.Value); //повторный вывод всех пар
            }

            var keys = College.Keys; //количество строк, содержащих значения ключей
            Console.WriteLine(keys.Count);

            foreach(var key in keys)
            {
                Console.WriteLine(key); //вывод ключей
            }

            var values = College.Values; //количество строк, содержащих значения
            Console.WriteLine(values.Count);

            foreach (int val in values)
            {
                Console.WriteLine(val); //вывод значений
            }

            Console.ReadKey();
        }
    }
}
