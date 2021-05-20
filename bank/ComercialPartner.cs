using bank.Sistemas;

namespace bank
{
    public class ComercialPartner : IAuthentication
    {
        public string password { get; set; }

        public bool Authentication(string pass)
        {
            return this.password == pass;
        }

        public bool Authentication(string pass, string name)
        {
            return this.password == pass;
        }

    }
}
