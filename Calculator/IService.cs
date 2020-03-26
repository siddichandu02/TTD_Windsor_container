using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IService
    {

        decimal GetAnnualSalary(decimal hourlyWage);
        decimal GetHourlySalary(int hourlyWage);
    }
}
