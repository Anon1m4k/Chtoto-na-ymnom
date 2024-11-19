using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace calc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("distance-1, acceleration-2, motion_coordinates-3, save-4");

            Console.WriteLine("Введите номер типа");

            int x = Convert.ToInt32(Console.ReadLine());
            type t=type_operation.Operation(x);
            action(t);

            Console.ReadKey();
        }
        static public void  action(type t)
            {
                if (t==type.distance)

            {
                Console.WriteLine("v * t=s");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());             
                Console.WriteLine(a * b);
                }

                else if (t == type.acceleration)
                {
                Console.WriteLine("(s1 - s2)/t=a");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());               
                Console.WriteLine((a - b) / c);
                }

                else if (t == type.motion_coordinates)
                {
                Console.WriteLine("x0+v0*t+(a*t^2)/2");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());               
                Console.WriteLine(a + b * c + (d * c * c) / 2);              
                }

                else if (t == type.save)
                {   

                }
        }

    }
}
