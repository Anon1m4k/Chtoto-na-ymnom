using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = -5; i < 10; i++)
            {
               list.Remove(i);               
            }

            for (int i = 0; i <list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();

        }
    }
}
