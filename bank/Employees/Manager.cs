using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Employees
{
    public class Manager : EmployeesAuthentication
    {
        public Manager(string CPF) : base(5000, CPF)
        {

        }

    }


}
