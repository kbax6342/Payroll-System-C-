using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem
{
    class SalariedEmployee: Employee
    {
        private decimal weeklySalary;
        //four parameter constructor

        public SalariedEmployee(string firstName, string lastName, string SSN, 
            decimal weeklySalary): base(firstName, lastName, SSN)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(weeklySalary < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"" +
                        $"{nameof(WeeklySalary)}: must be >= 0");
                }

                
                weeklySalary = value;
            }
        }
        public  decimal Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return $"Salaried Employee: {base.ToString()}\n" +
                $"Salary: {WeeklySalary:c}";
        }
    }

}//end of Payrollname space
