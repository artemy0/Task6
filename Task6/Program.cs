using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[] { new Employee("Artem", "merchandiser", 900), new Employee("Gleb", "seller", 500), new Employee("Kirill", "directors", 2000, 295389238),
                                                    new Employee("Bob", "loader", 650), new Employee("Pasha", "security", 550), new Employee("Masha", "main seller", 700)};
            foreach (var item in employees)
                item.GetInformation();

            Console.WriteLine();
            //compare by person information parameter(Name)
            Array.Sort(employees, Employee.CompareByPersonalInformation);

            foreach (var item in employees)
                item.GetInformation();

            Console.WriteLine();
            //compare by salary value parameter(SalaryValue)
            Array.Sort(employees, Employee.CompareBySalaryValue);

            foreach (var item in employees)
                item.GetInformation();

            Console.WriteLine();
            //default compare (by Name)
            Array.Sort(employees);

            foreach (var item in employees)
                item.GetInformation();

            Console.ReadKey();
        }
    }
}
