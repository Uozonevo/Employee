using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects of Emplyee class
            Employee empl01 = new Employee();
            Employee empl02 = new Employee("257643","Jerry","Pellegrini",3200);
            Employee empl03 = new Employee("436146","Rosemary","Jenkins");

            // Use objects to call member functions
            Console.WriteLine("----------Employee 1----------");
            empl01.DisplayInfo();
            Console.WriteLine("----------Employee 2----------");
            empl02.DisplayInfo();
            empl02.CalculatePay(3200, 0);
            Console.WriteLine("----------Employee 3----------");
            empl03.DisplayInfo();
            empl03.CalculatePay(1500, 0);

            Console.Read();
        }
    }
}
