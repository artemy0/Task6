using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    enum SortBy
    {
        PersonalInformation,
        SalaryValue
    }

    
    class Employee : IComparable<Employee>
    {
        //personal information
        public string Name { get; private set; }
        public int? PhoneNumber { get; set; }
        public string PositionHeld { get; set; }
       
        //salary value
        public int SalaryValue { get; set; }

        //ctor
        public Employee(string name, string positionHold, int salaryValue, int? phoneNumber = null)
        {
            Name = name;
            PositionHeld = positionHold;
            SalaryValue = salaryValue;
            PhoneNumber = phoneNumber;
        }

        //get information about employee
        public void GetInformation()
        {
            //The method PadRight(\d*) is used for everything to be prettily write.
            Console.Write($"Name: {Name.PadRight(8)}\tPasition hold: {PositionHeld.PadRight(15)}\tSalary value: {SalaryValue:C2}");
            if (PhoneNumber != null)
                Console.WriteLine($"\tPhone number {PhoneNumber:+375(##)###-##-##}");
            else
                Console.WriteLine();
        }

        //sorting by parameter
        public static int CompareBySalaryValue(Employee x, Employee y)
        {
            return x.SalaryValue.CompareTo(y.SalaryValue);
        }
        public static int CompareByPersonalInformation(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }

        //default sorting
        public int CompareTo(Employee other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
