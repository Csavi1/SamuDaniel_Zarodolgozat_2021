using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Models
{
    public partial class dinok
    {
        public dinok(string nev, int felfedezo_id, int felfedezes_datuma, string mikorelt, string lelohelyek, string elohelyek, string taplalek, int taplalkozasi_forma_id, string testmeret, string testtomeg, string leiras, byte[] kep)
        {
            this.nev = nev;
            this.felfedezo_id = felfedezo_id;
            this.felfedezes_datuma = felfedezes_datuma;
            this.mikorelt = mikorelt;
            this.lelohelyek = lelohelyek;
            this.elohelyek = elohelyek;
            this.taplalek = taplalek;
            this.taplalkozasi_forma_id = taplalkozasi_forma_id;
            this.testmeret = testmeret;
            this.testtomeg = testtomeg;
            this.leiras = leiras;
            this.kep = kep;
        }
        public dinok() { }
    }
}
