//Обчислити суму числового ряду при 0 <= nn <= nk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk, k, i;
            float S = 0;
            Console.WriteLine("Важно nn >= 0 , nn <= nk");
            do
            {
                Console.WriteLine("Введите nn");
                nn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите nk");
                nk = Convert.ToInt32(Console.ReadLine());
            } while (nk < nn || nn < 0);
            k = nn;
            for (i = 0; i < nk - nn; i++)
            {
                k = k + 1;
                S = S + (((k * k) * (k * k * k)) / (k * k + k + 1));
                Console.WriteLine("-");
            }
            Console.WriteLine("S = ");
            Console.WriteLine(S);
        }
    }
}
