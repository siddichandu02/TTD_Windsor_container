using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculatorB : ISalaryCalculator
    {
        const int HoursInYear = 2080;
        const int bonus = 2000;
        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear + bonus;
        public decimal GetHourlySalary(int annualSalary) => annualSalary / HoursInYear;

    }
}
