using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculatorA:ISalaryCalculator
    {
        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)=>hourlyWage * HoursInYear;
        public decimal GetHourlySalary(int annualSalary)=>annualSalary/HoursInYear;
        
    }
}
