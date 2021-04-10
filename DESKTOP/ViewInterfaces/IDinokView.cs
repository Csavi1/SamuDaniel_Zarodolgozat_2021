using Dinobazis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewInterfaces
{
    interface IDinokView
    {
        dinoVM dino { get; set; }
        bool isNew { get; set; }

        string[] felfedezoList { set; }
        string[] tapformaList { set; }

        string nevError { set; }
        string felfedezoError { set; }
        string felDatumError { set; }
        string mikoreltError { set; }
        string lelohelyekErrror { set; }
        string elohelyekError { set; }
        string taplalekError { set; }
        string tapformaError { set; }
        string testmeretError { set; }
        string testtomegError { set; }
        string leirasError { set; }
    }
}
