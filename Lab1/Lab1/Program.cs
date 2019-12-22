using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LAB1 Var6
//6.Знайти об'єм циліндру за його висотою та радіусом основи 

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, h, R;
            double PI = 3.14 ;
            Console.WriteLine("Введите высоту цилиндра: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус основы: ");
            R = Convert.ToInt32(Console.ReadLine());
            R = R * R;
            V = h * R * PI;
            Console.WriteLine("V цилиндра = " + V);
        }
    }
}
