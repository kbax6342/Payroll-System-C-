using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem
{
    class HourlyEmployee : Employee
    {
        private decimal wage;
        private decimal hours;

        //five parameter constructor
        public HourlyEmployee(string firstName, string lastName, string ssn,
            decimal wage, decimal hours):base(firstName, lastName, ssn)
        {
            Hours = hours;
            Wage = Wage;
        }

        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"" +
                        $"{nameof(value)}: must be >= 0");
                }
                Wage = value;
            }
        }

        public decimal Hours { 
            get
            {
                return hours;
            }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"" +
                        $"{nameof(value)}: must be >= 0");
                }
                Hours = value;
            }
        }



        public override decimal Earnings()
        {
            decimal earnings = 0.0m;

            if(Hours <= 40)
            {
                earnings = Wage * Hours;
            }
            else
            {
                earnings = (40 * Wage) + ((Hours - 40) * Wage * 1.5m);
            }
            return earnings;
        }

        public override string ToString()
        {
            return $"base.ToString();
        }
    }
}
