using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LAB_4_VARIANT_17

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, R, B = 0,M = 0;
            do {
                Console.WriteLine("Введите размер масива: ");
                N = Convert.ToInt32(Console.ReadLine());
            }
            while (N < 3);
            int[] massivus = new int[N];
            //for (int i = 0; i < massivus.Length; i++)
            //{
            //    Console.WriteLine("Введите элемент масива " + (i + 1) + ": ");
            //    massivus[i] = Convert.ToInt32(Console.ReadLine());
            //}

            do
            {
                Console.WriteLine("От какого элемента массива вести отсчет?: ");
                R = Convert.ToInt32(Console.ReadLine());
            }
            while (R < 0 || R > N);

            for (int i = R; i < massivus.Length; i++)
            {
                B++;               
            }

            for (int i = R; i > 0; i--)
            {
                M++;
            }

            //Console.WriteLine(B);
            //Console.WriteLine(M);

            if (B > M)
            {
                Console.WriteLine("Самый дальний элемент - последний в массиве");
            } else
            {
                Console.WriteLine("Самый дальний элемент - первый в массиве");
            }
        }
    }
}
