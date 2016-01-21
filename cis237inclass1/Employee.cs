using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        // >Fields.
        private string firstName;
        private string lastName;
        private decimal weeklySalary;


        // >Properties.
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

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }


        // >Methods.
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.weeklySalary.ToString("C");
        }

        // >Constructors.
        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.WeeklySalary = weeklySalary;
        }
        // >Default Constructor.
        public Employee()
        {

        }

    }
}
