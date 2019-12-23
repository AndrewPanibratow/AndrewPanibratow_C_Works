using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab8
{
    class Garazg_Sheiha
    {
        public string name;
        public string color;
        public int speed;
        public int year;

        public Garazg_Sheiha (string _name, string _color , int _speed , int _year)
        {
            name = _name;
            color = _color;
            speed = _speed;
            year = _year;
            GetInfo();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Название: {name}  Цвет: {color} Скорость: {speed} Год: {year}");
        }
    }

    class Program
    {
        static void Main(string[] args) 
            
        {
            string N,C;
            int S, Y;
            Garazg_Sheiha Basket96 = new Garazg_Sheiha("Basket96","Black",80,1996);

            Garazg_Sheiha BobsCar = new Garazg_Sheiha("BobsCar","Gold",100,2001);

            Garazg_Sheiha Brunswagen = new Garazg_Sheiha("Brunswagen","Red",200,2011);

            Console.WriteLine("Добро пожаловать в гараж шейха!");
            
            int Povtor;
            do
            {
                Console.WriteLine("Для добавления новой машины нажмите 1");
                Console.WriteLine("Для удаления машины нажмите 2");
                Console.WriteLine("Для выбора машины нажмите 3");
                Console.WriteLine("Для просмотра машин в гараже нажмите 4");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.Write("Введите название машины: ");
                        N = Convert.ToString(Console.ReadLine());
                        Console.Write("Введите цвет машины: ");
                        C = Convert.ToString(Console.ReadLine());
                        Console.Write("Введите скорость машины: ");
                        S = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите год машины: ");
                        Y = Convert.ToInt32(Console.ReadLine());
                        Garazg_Sheiha NewCar = new Garazg_Sheiha(N, C, S, Y);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
                
                Console.WriteLine("Нажмите 1 если вы хотите выполнить другое действие");
                Povtor = Convert.ToInt32(Console.ReadLine());
            } while (Povtor == 1);
        }
    }
}
