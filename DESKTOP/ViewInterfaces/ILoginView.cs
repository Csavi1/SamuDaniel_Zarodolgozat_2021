using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewInterfaces
{
    interface ILoginView
    {
        string EmailAddress { get; }
        string Password { get; }
        string EmailError { get; set; }
        string PasswordError { get; set; }
        string LoginError { get; set; }
    }
}
