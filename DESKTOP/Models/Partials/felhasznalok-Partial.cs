using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Models
{
    public partial class felhasznalok
    {
        public felhasznalok() { }
        public felhasznalok(string email, string nev, string jelszo, bool fejleszto_logikai)
        {
            this.email = email;
            this.nev = nev;
            this.jelszo = jelszo;
            this.fejleszto_logikai = fejleszto_logikai;
        }
    }
}
