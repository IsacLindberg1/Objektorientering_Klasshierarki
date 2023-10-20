using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering_Klasshierarki
{
    internal class SalesPerson : Employee
    {

        public override double CalculateSalary()
        {
            return HourlyWage * WorkingHours;
        }
    }
}
