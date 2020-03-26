using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Service:IService
    {
        readonly ISalaryCalculator _salarycalculator;

       public Service(ISalaryCalculator salarycalculator)
        {
            _salarycalculator = salarycalculator;
        }

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
           
            decimal annaulSalary = _salarycalculator.GetAnnualSalary(hourlyWage);
            return annaulSalary;
        }
        public decimal GetHourlySalary(int annualSalary)
        {
            
            decimal hourlyWage = _salarycalculator.GetHourlySalary(annualSalary);
            return hourlyWage;
            
        }
    }
}
