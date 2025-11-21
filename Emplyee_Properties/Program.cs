using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Name[] names = new Name[3];
            names[0] = new Name();
            names[1] = new Name("Jane", "Doe");
            names[2] = new Name("Eric");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"#{i}\t", i + 1);
                names[i].DisplayName();
            }
            Console.Read();
            names[0].setFirstName("Mariah");
            names[0].setLastName("Doe");
            names[2].setLastName("Manning");
            Console.WriteLine($"# 1 and #3 changed");
            names[0].DisplayName();
            names[2].DisplayName();
            Console.Read();

            Console.WriteLine("--------------Using Properties--------------");
            names[0].FirstName = "Andy";
            names[0].LastName = "Garcia";
            names[0].DisplayName();
            Console.Read();
            // destructor ~Name()

            Console.WriteLine("------------Testing Driver Program-------------");
            Employee[] emp2 = new Employee[2];
            emp2[0] = new Employee();
            emp2[1] = new Employee("Michael","Richard",6000);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"#{i + 1}\t{emp2[i].EmployeeName} {emp2[i].TotalSales}");
            }

            Console.WriteLine("Please an employee name and salary");
            emp2[0].EmployeeName = new Name(Console.ReadLine(), Console.ReadLine());
            emp2[0].TotalSales = Convert.ToDouble(Console.ReadLine());
            emp2[0].TotalSales = emp2[0].TotalSales;
            Console.WriteLine($"Name: {emp2[0].EmployeeName}");
            Console.WriteLine($"Salary: ${emp2[0].TotalSales}");
            emp2[0].CalculatePay();

            Console.Read();
        }
    }
}
