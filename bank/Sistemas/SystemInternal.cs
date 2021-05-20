using System;

namespace bank.Sistemas
{

    class SystemInternal
    {
        public bool Login(IAuthentication employee, string password)
        {
            bool userAuthenticated = employee.Authentication(password);

            if (userAuthenticated)
            {
                Console.WriteLine("Realizado com sucesso!");
                return true;

            }   
            else
            {
                Console.WriteLine("Realizado com erro!");
                return false;
            }

        }
    }
}
