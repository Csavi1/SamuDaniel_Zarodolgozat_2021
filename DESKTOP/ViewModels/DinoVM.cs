using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewModels
{
    public class dinoVM
    {
        public dinoVM(int id, string nev, int felfedezoId, string felfedezoNev, int felfedezesDatuma, string mikorelt, string lelohelyek, string elohelyek, string taplalekok, int taplalkozasiFormaId, string taplalkozasiFormaNev, string testmeret, string testtomeg, string leiras, byte[] kep)
        {
            this.id = id;
            this.nev = nev;
            this.felfedezoId = felfedezoId;
            this.felfedezoNev = felfedezoNev;
            this.felfedezesDatuma = felfedezesDatuma;
            this.mikorelt = mikorelt;
            this.lelohelyek = lelohelyek;
            this.elohelyek = elohelyek;
            this.taplalekok = taplalekok;
            this.taplalkozasiFormaId = taplalkozasiFormaId;
            this.taplalkozasiFormaNev = taplalkozasiFormaNev;
            this.testmeret = testmeret;
            this.testtomeg = testtomeg;
            this.leiras = leiras;
            this.kep = kep;
        }
        public dinoVM(string nev, string felfedezoNev, int felfedezesDatuma, string mikorelt, string lelohelyek, string elohelyek, string taplalekok, string taplalkozasiFormaNev, string testmeret, string testtomeg, string leiras)
        {
            this.nev = nev;
            this.felfedezoNev = felfedezoNev;
            this.felfedezesDatuma = felfedezesDatuma;
            this.mikorelt = mikorelt;
            this.lelohelyek = lelohelyek;
            this.elohelyek = elohelyek;
            this.taplalekok = taplalekok;
            this.taplalkozasiFormaNev = taplalkozasiFormaNev;
            this.testmeret = testmeret;
            this.testtomeg = testtomeg;
            this.leiras = leiras;
        }

        public int id { get; set; }
        public string nev { get; set; }
        public int felfedezoId { get; set; }
        public string felfedezoNev { get; set; }
        public int felfedezesDatuma { get; set; }
        public string mikorelt { get; set; }
        public string lelohelyek { get; set; }
        public string elohelyek { get; set; }
        public string taplalekok { get; set; }
        public int taplalkozasiFormaId { get; set; }
        public string taplalkozasiFormaNev { get; set; }
        public string testmeret { get; set; }
        public string testtomeg { get; set; }
        public string leiras { get; set; }
        public byte[] kep { get; set; }
    }
}
