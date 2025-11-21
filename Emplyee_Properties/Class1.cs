using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Homework_9
{
    internal class Employee
    {
        // data members
        private string id;
        private Name employeeName;
        private double totalSales;
        // contributions
        private double sales_tax;
        private double federal_tax;
        private double retirement;
        private double social_security;

        public Employee() // default constructor
        {
            id = "000000";
            employeeName = new Name();
            totalSales = 0;
        }
        // overloading constructors
        public Employee(string num, string fn, string ln, double pay)
        {
            id = num;
            employeeName = new Name(fn,ln);
            totalSales = pay;
        }
        public Employee(string fn, string ln, double pay)
        {
            employeeName = new Name(fn,ln);
            totalSales = pay;
        }
        public Employee(double pay)
        {            
            totalSales = pay;
        }
        public void CalculatePay()
        {
            sales_tax = totalSales * 0.09;
            federal_tax = totalSales * 0.18;
            retirement = totalSales * 0.10;
            social_security = totalSales * 0.06;

            Console.WriteLine("----------Contributions----------");
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Sales Tax: {sales_tax}");
            Console.WriteLine($"Federal Tax: {federal_tax}");
            Console.WriteLine($"Retirement: {retirement}");
            Console.WriteLine($"Social Security: {social_security}");
        }
        
        // properties
        public Name EmployeeName
        { 
            get { return employeeName; } 
            set { employeeName = value; }
        }
        public double TotalSales
        {
            get { return totalSales; }
            set { totalSales = value; }
        }
    }
}
