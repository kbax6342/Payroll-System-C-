using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;


        public BasePlusCommissionEmployee(string firstName, string lastName, string ssn,
            decimal baseSalary, decimal grossSales, decimal commissionRate) : base(firstName, lastName, ssn,grossSales,commissionRate) {
            
            BaseSalary = baseSalary;
        }

        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"" +
                            $"{nameof(BaseSalary)}: must be >= 0");
                }

                BaseSalary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() ;
        }




    }
}
