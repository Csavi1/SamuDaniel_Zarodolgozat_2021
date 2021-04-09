using Dinobazis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewInterfaces
{
    interface IUserView
    {
        felhasznalok user { get; set; }

        string emailError { set; }
        string nevError { set; }
    }
}
