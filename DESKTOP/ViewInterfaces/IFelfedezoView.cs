using Dinobazis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewInterfaces
{
    interface IFelfedezoView
    {
        felfedezok ujFelfedezo { get; set; }
        string[] felfedezok { get; set; }
        string felfedezoError { set; }
    }
}
