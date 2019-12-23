using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernetka
{
    class Program
    {
        //Пример использования
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Иван", "Иванов"));
            employees.Add(new Employee("Петр", "Петров"));

            foreach (var item in employees)
                Console.WriteLine("Имя: {0} Фамилия: {1}", item.FirstName, item.SurName);
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public Employee(string _firstName, string _surName)
        {
            FirstName = _firstName;
            SurName = _surName;
        }
        public Employee() : this("none", "none") { }
    }
}
