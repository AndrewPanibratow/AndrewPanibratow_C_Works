using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LAB6 Var6
//6.Створити ліст інтових змінних, який може вміщати тільки 1 і 0,
//заповнити його з клавіатури.Порахувати кількість 1 і 0. Скопіювати
//отриманий ліст в масив.

namespace Lab6
{
        class Program
        {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { };
            int L, N , C0 = 0, C1 = 0;
            do
            {
                Console.WriteLine("Введите количество чисел: ");
                N = Convert.ToInt32(Console.ReadLine());
            }
            while (N < 0);

            for (int i = 0; i < N; i++)
            {
                do
                {
                    Console.WriteLine("Введите число: ");
                    L = Convert.ToInt32(Console.ReadLine());
                    if (L == 0) { C0++; }
                    else
                    {
                        if (L == 1) { C1++; }
                    }
                }
                while (L != 0 && L != 1);
                numbers.Add(L);
            }
            Console.WriteLine("");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Число 0 встречается "+C0+ " раз");
            Console.WriteLine("Число 1 встречается " + C1+ " раз");
        }
    }
}
