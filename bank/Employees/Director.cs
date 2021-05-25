using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Employees
{
    public class Director : EmployeesAuthentication
    {

        public Director(string CPF) : base(5000, CPF)
        {

        }
    }
}
