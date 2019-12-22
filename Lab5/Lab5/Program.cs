using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LAB5 Variant16

// Дана квадратна матриця порядку M. Замінити нулями елементи
//матриці, що лежать 1) нижче головної 2) вище головної 3) нижче побічної; 4) вище побічної
//діагоналі.

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Random random = new Random();
            do
            {
                Console.WriteLine("Введите размер масива: ");
                N = Convert.ToInt32(Console.ReadLine());
            }
            while (N < 3);
            int[,] massivus = new int[N,N];
            //int rows = massivus.GetUpperBound(0) + 1;
            //int columns = massivus.Length / rows;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    massivus[i, j] = random.Next(10);
                }
            }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write($"{massivus[i, j]} \t");
                    }
                    Console.WriteLine();
                }

                
                Console.WriteLine("Выберите вариант действия");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.WriteLine("нижче головної");
                        int Z1 = 0;
                        for (int i = 0; i < N; i++)
                        {
                            int j = 0;
                            while (j < Z1)
                            {
                                massivus[i, j] = 0;
                                j++;
                            };
                            Z1++;
                        }
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                Console.Write($"{massivus[i, j]} \t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        Console.WriteLine("вище головної");
                        int Z2 = 1;
                        for (int i = 0; i < N; i++)
                        {
                            int j = Z2;
                            while (j < N)
                            {
                                massivus[i, j] = 0;
                                j++;
                            };
                            Z2++;
                        }
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                Console.Write($"{massivus[i, j]} \t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        Console.WriteLine("нижче побічної");
                        int Z3 = N;
                        for (int i = 0; i < N; i++)
                        {
                            int j = Z3;
                            while (j < N)
                            {
                                massivus[i, j] = 0;
                                j++;
                            };
                            Z3--;
                        }
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                Console.Write($"{massivus[i, j]} \t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                        Console.WriteLine("вище побічної");
                        int Z4 = N - 1;
                        for (int i = 0; i < N; i++)
                        {
                            int j = 0;
                            while (j < Z4)
                            {
                                massivus[i, j] = 0;
                                j++;
                            };
                            Z4--;
                        }
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                Console.Write($"{massivus[i, j]} \t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Выберите вариант 1-4");
                        break;
                }
        }
    }
}
