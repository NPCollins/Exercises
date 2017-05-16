using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string department;
        private double annualSalary;

        public int EmployeeId
        {
            get { return employeeId; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public double AnnualSalary
        {
            get { return annualSalary; }
        }

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            annualSalary = salary;
            this.employeeId = employeeId;
        }

        public void RaiseSalary(double percent)
        {
            annualSalary += (annualSalary * (percent / 100.0));
        }


    }
}
