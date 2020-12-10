﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public double HoursWorked { get; set; }

        public PartTimeEmployee(string a, string b, decimal c, double d) : base(a, b)
        {
            HourlyRate = c;
            HoursWorked = d;
        }

        public override decimal CalculateMonthlyPay()
        {
            return HourlyRate * (Convert.ToDecimal(HoursWorked));
        }
    }
}
