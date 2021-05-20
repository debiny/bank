using System;
using System.Collections.Generic;
using System.Text;

namespace bank.Sistemas
{
    public interface IAuthentication
    {
        bool Authentication(string pass);
    }
}
