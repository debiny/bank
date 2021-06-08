using bank.Sistemas;

namespace bank.Employees
{
    public abstract class EmployeesAuthentication : Employees , IAuthentication
    {
        public string password { get; set; }

        public bool Authentication(string pass)
        {
            return this.password == pass;
        }

        public EmployeesAuthentication(double wage, string cpf) : base(wage, cpf)
        {

        }
    }
}
