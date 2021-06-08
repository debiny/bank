namespace bank.Employees
{
    public class Director : EmployeesAuthentication
    {

        public Director(string CPF) : base(5000, CPF)
        {

        }
    }
}
