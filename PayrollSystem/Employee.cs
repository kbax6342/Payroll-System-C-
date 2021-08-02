using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem
{
    abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SSN { get; }

        //there parameter instructor
        public Employee(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }//end of constructor

        public override string ToString()

        {

            return $"{FirstName} {LastName} \n" +
                $"SSN is: {SSN}";
        }

        public abstract decimal Earnings();

    } //end employee class

}//end of payroll namespace
