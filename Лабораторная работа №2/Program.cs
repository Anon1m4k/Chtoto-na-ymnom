using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    public class Program
    {             
        static void Main(string[] args)
        {
            История_продаж ИСТОРИЯ = new История_продаж();
            ИСТОРИЯ.НоваяЗапись(new ЗаписьТовара(new Товар("Колбаса", 15.5, ГруппыПродукции.МясныеИзделия), 4, 15));
            Console.WriteLine(ИСТОРИЯ.ConwertString());
            Console.ReadKey();
        }
    }
}
