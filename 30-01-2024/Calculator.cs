using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _30_01_2024
{
    internal class Calculator
    {
        public double CalculateTotalSalary(object[] objects)
        {
            double totalSalary = 0;
            foreach (var obj in objects)
            {
                var salaryProperty = obj.GetType().GetProperty("_salary");
                if (salaryProperty != null)
                {
                    totalSalary += (double)salaryProperty.GetValue(obj);
                }
            }
            return totalSalary;
        }
    }
}
