using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW_8
{
    internal class Employee // Class Definition
    {
        /* Create an Employee class. Items to include as data members are 
         * employee number, first name, last name, and monthly salary. 
         * Include default and overloading constructors , also include 
         * a method that calculates the annual pay of the employee, and 
         * a method to display the information of the employee. Create 
         * a second class to test your Employee class by instantiating 
         * two Employee objects and display all the above information 
         * of each individual.
         */

        // Data Members
        private string number;
        private string fname;
        private string lname;
        private double salary;

        public Employee() // Default Constructor
        {
            number = "Unknwown";
            fname = "Jane";
            lname = "Doe";
            salary = 0;
        }

        // Overloading Constructors
        public Employee(string num, string first_nm, string last_nm, double pay)
        {
            number = num;
            fname = first_nm;
            lname = last_nm;
            salary = pay;
        }
        public Employee(string num, string first_nm, string last_nm)
        {
            number = num;
            fname = first_nm;
            lname = last_nm;
        }

        public double CalculatePay(double pay, double perAnnum) // Calculates the annual pay
        {
            salary = pay;
            perAnnum = pay * 12;    //calculate annual pay
            Console.WriteLine($"{fname} {lname}'s annual pay is: ${perAnnum}");

            return perAnnum;        //return annual pay
        }
        public void DisplayInfo() //Display Information of employees
        {
            Console.WriteLine($"EmployeeID:{number}\tName:{fname} {lname}\tSalary: {salary}");
        }
    }
}
