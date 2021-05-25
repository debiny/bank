using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Employees
{
    abstract public class Employees
    {
        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Wage { get; protected set; }
        public static int TotalEmployees { get; set; }

        public Employees(double Wage, string CPF)
        {
            TotalEmployees++;
            this.CPF = CPF;
            this.Wage = Wage;
        }

    }
}
