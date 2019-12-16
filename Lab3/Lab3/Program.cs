using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, S;
            Console.WriteLine("Введите А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C");
            C = Convert.ToInt32(Console.ReadLine());
            S = B * B - 4 * A * C;
            if (S > 0)
            {
                Console.WriteLine("Уравнение имеет 2 кореня");
            }
            else { Console.WriteLine("Уравнение не имеет 2 кореня"); }
        }
    }
}
