using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написати програму, що виконує наступні функції:
//1. Виводить на екран введене число з клавіатури в зворотному порядку(1234-4321)
//2. Виводить будь-яку строку в зворотному порядку(АБВ-ВБА)
//3. Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456-321.654)
//4. Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного
//знаку” теж в зворотному(АБВ, ГДЕ-ВБА, ЕДГ)
//5. Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних
//типів
//6. Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів
//перевантажити
//7. Реалізувати метод, що буде масив повертати задом навпаки(Використання
//Array.Reverse() заборонено!)
//8. Виконати пункт 7 з використанням ключових слів ref i out*/

namespace Lab7
{
        class Program
        {

        static void Vibor()
        {
            int NN;
            do
            {
                Console.WriteLine("1. Перевернуть число");
            Console.WriteLine("2. Перевернуть ряд");
            Console.WriteLine("3. Перевернуть дробовое число");
            Console.WriteLine("4. Перевернуть ряд с магическим знаком");
            Console.WriteLine("5. Перевернуть число с перегрузкой");
            Console.WriteLine("6. Перевернуть ряд с перегрузкой");
            Console.WriteLine("7. Перевернуть дробовое число с перегрузкой");
            Console.WriteLine("8. Перевернуть ряд с магическим числом с перегрузкой");
            Console.WriteLine("9. Перевернуть массив");
            Console.WriteLine("10. Перевернуть массив используя ref");
            Console.WriteLine("11. Перевернуть массив используя out");
            Console.WriteLine("Выберите желаемый пункт: ");
            int punkt = Convert.ToInt32(Console.ReadLine());

            switch (punkt)
            {
                case 1:
                    Punkt1();
                    break;
                case 2:
                        Punkt2();
                    break;
                case 3:
                        Punkt3();
                    break;
                case 4:
                        Punkt4();
                    break;
                case 5:
                    Console.WriteLine("Введите число: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Total_overload.Transform(number1);
                    break;
                case 6:
                    Console.WriteLine("Введите ваш ряд: ");
                    string str1 = Console.ReadLine();
                    Total_overload.Transform(str1);
                    break;
                case 7:
                    Console.WriteLine("Введите дробовое число: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());
                    Total_overload.Transform(number2);
                    break;
                case 8:
                    Console.WriteLine("Введите ваш ряд");
                    string str2 = Console.ReadLine();
                    Console.WriteLine("Введите магическое число");
                    char magicsymbol = Convert.ToChar(Console.ReadLine());
                    Total_overload.Transform(str2);
                    break;
                case 9:
                    int[] a1;
                    int n1;
                    do
                    {
                        Console.WriteLine("Введите количество элементов в массиве:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                    } while (n1 <= 0);
                    a1 = new int[n1];
                    for (int i = 0; i < n1; i++)
                    {
                        Console.Write("a[{0}] = ", i + 1);
                        a1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                        Punkt9(a1);
                    Console.WriteLine("\n Новая последовательность:");
                    for (int i = 0; i < n1; i++)
                        Console.WriteLine("a[{0}] = {1}", i + 1, a1[i]);
                    break;
                case 10:
                    int[] a;
                    int n;
                    do
                    {
                        Console.WriteLine("Введите количество элементов в массиве: ");
                        n = Convert.ToInt32(Console.ReadLine());
                    } while (n <= 0);
                    a = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("a[{0}] = ", i + 1);
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }
                        Punkt10(ref a);
                    Console.WriteLine("\nNew Array:");
                    for (int i = 0; i < n; i++)
                        Console.WriteLine("a[{0}] = {1}", i + 1, a[i]);
                    break;
                case 11:
                    int[] a3;
                        Punkt11(out a3);
                    Console.WriteLine("\nNew Array:");
                    for (int i = 0; i < a3.Length; i++)
                        Console.WriteLine("a[{0}] = {1}", i + 1, a3[i]);
                    break;
            }
                Console.WriteLine("");
                Console.WriteLine("Что бы выбрать другой пункт нажмите 0 ");
                 NN = Convert.ToInt32(Console.ReadLine());
            } while ( NN == 0);
        }

        static void Punkt1()
            {
                Console.WriteLine("Введите ваше число: ");
                string number = Console.ReadLine();
                char[] line = number.ToCharArray();
                Array.Reverse(line);
                Console.Write("Новое число: ");
                Console.Write(line);
            }

            static void Punkt2()
            {
                Console.WriteLine("Ваш ряд: ");
                string str = Console.ReadLine();
                char[] line = str.ToCharArray();
                Array.Reverse(line);
                Console.Write("Новый ряд: ");
                Console.Write(line);
            }

            static void Punkt3()
            {
                string number;
                do
                {
                    Console.WriteLine("Введите ваше число: ");
                    number = Console.ReadLine();
                } while (Convert.ToDouble(number) % 1 == 0);
                char[] line = number.ToCharArray();

                Console.Write("Новое число: ");
                for (int i = 0; i < line.Length; i++)
                    if (line[i] == ',')
                    {
                        int k = i;
                        for (i = k - 1; i >= 0; i--)
                            Console.Write(line[i]);
                        Console.Write(",");
                        for (i = line.Length - 1; i > k; i--)
                            Console.Write(line[i]);
                    }
            }

            static void Punkt4()
            {
                string str;
                Console.WriteLine("Ваш ряд: ");
                str = Console.ReadLine();
                char[] line = str.ToCharArray();

                char magicsymbol;
                Console.WriteLine("Магический знак: ");
                magicsymbol = Convert.ToChar(Console.ReadLine());

                bool check = false;
                for (int i = 0; i < line.Length; i++)
                    if (line[i] == magicsymbol)
                        check = true;

                if (check == true)
                {
                    Console.Write("Новый ряд: ");
                    for (int i = 0; i < line.Length; i++)
                        if (line[i] == magicsymbol)
                        {
                            int k = i;
                            for (i = k - 1; i >= 0; i--)
                                Console.Write(line[i]);
                            Console.Write(magicsymbol);
                            for (i = line.Length - 1; i > k; i--)
                                Console.Write(line[i]);
                        }
                }
                else
                    Console.Write("Магический символ не найден");
            }

            abstract class Total_overload
            {
                public static void Transform(int number)
                {
                    string str = Convert.ToString(number);
                    char[] line = str.ToCharArray();
                    Array.Reverse(line);
                    Console.Write("Измененное число: ");
                    Console.Write(line);
                }
                public static void Transform(string str)
                {
                    char[] line = str.ToCharArray();
                    Array.Reverse(line);
                    Console.Write("Измененный ряд: ");
                    Console.Write(line);
                }

                public static void Transform(double number)
                {
                    string str = Convert.ToString(number);
                    char[] line = str.ToCharArray();

                    Console.Write("Измененное число: ");
                    for (int i = 0; i < line.Length; i++)
                        if (line[i] == ',')
                        {
                            int k = i;
                            for (i = k - 1; i >= 0; i--)
                                Console.Write(line[i]);
                            Console.Write(",");
                            for (i = line.Length - 1; i > k; i--)
                                Console.Write(line[i]);
                        }
                }

                static void Transform(string str, char magicsymbol)
                {
                    char[] line = str.ToCharArray();

                    bool check = false;
                    for (int i = 0; i < line.Length; i++)
                        if (line[i] == magicsymbol)
                            check = true;

                    if (check == true)
                    {
                        Console.Write("Измененный ряд: ");
                        for (int i = 0; i < line.Length; i++)
                            if (line[i] == magicsymbol)
                            {
                                int k = i;
                                for (i = k - 1; i >= 0; i--)
                                    Console.Write(line[i]);
                                Console.Write(magicsymbol);
                                for (i = line.Length - 1; i > k; i--)
                                    Console.Write(line[i]);
                            }
                    }
                    else
                        Console.Write("Магический символ не найден");
                }
            }

            static int[] Punkt9(int[] a)
            {
                int i, j, t;
                for (i = 0, j = a.Length - 1; i < j; i++, j--)
                {
                    t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                }
                return a;
            }

            static void Punkt10(ref int[] a)
            {
                int i, j, t;
                for (i = 0, j = a.Length - 1; i < j; i++, j--)
                {
                    t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                }
            }

            static void Punkt11(out int[] a)
            {
                int n;
                do
                {
                    Console.WriteLine("Введите количество элементов в вашей последовательности: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n <= 0);

                a = new int[n];

                int i = 0;
                for (i = 0; i < a.Length; i++)
                {
                    Console.Write("a[{0}] = ", i + 1);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                int j, t;
                for (i = 0, j = a.Length - 1; i < j; i++, j--)
                {
                    t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Добро пожаловать! ");
                Vibor();
                Console.ReadKey();
            }
        }
}
