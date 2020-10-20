using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem
{
    class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private decimal commissionRate;

        public CommissionEmployee(string firstName, string lastName, string ssn,
        decimal grossSales, decimal commissionRate) : base(firstName, lastName, ssn)
        {
            //TODO
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"" +
                            $"{nameof(GrossSales)}: must be >= 0");
                }
                

                grossSales = value;
            }

            
        }

        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"" +
                           $"{nameof(CommissionRate)}: must be >= 0");
                }
                commissionRate = value;

            }

            
        }

        public override decimal Earnings()
        {
            return CommissionRate * GrossSales;
        }

        public override string ToString()
        {
            return $"Commission employee: {base.ToString()} \n" +
                $"Gross Sales: {GrossSales:C}\n" +
                $"Commission Rate: {CommissionRate: F2}" +
                $"Earnings: {Earnings()}";
        }
    }

    //five-parameter constructor

    
}
