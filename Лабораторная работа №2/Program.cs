using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Товар> Товары = new List<Товар>()
            {
                new Товар("Колбаса",15.5,ГруппыПродукции.МясныеИзделия),
                new Товар("Молоко",20.7,ГруппыПродукции.Молочка),
                new Товар("Батон",10.1,ГруппыПродукции.ХлебобулочныеИзделия),
            };

            

        }
    }
}
