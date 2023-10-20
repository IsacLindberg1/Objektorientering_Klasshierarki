using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering_Klasshierarki
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public double HourlyWage { get; set; }
        public double WorkingHours { get; set; }

        public abstract double CalculateSalary();   
    }
}
