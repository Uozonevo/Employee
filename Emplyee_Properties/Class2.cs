using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Homework_9
{
    internal class Name
    {
        private string firstName;
        private string lastName;

        public Name()
        {
            firstName = "unknown";
            lastName = "unknown";
        }

        public Name(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }
        public Name(string first_Name)
        {
            firstName = first_Name;
        }
        public void DisplayName()
        {
            Console.WriteLine($"The name is: {firstName} {lastName}");
        }
        // mutators
        public void setLastName(string lname)
        {
            lastName = lname;
        }
        public void setFirstName(string fname)
        {
            firstName = fname;
        }
        // accessors
        public string getLastName(string lname)
        {
            lastName = lname;
            return lname;
        }
        public string getFirstName(string fname)
        {
            firstName = fname;
            return fname;
        }
        // properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
