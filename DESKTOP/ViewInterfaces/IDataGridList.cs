using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewInterfaces
{
    interface IDataGridList<T>
    {
        BindingList<T> BindingList { get; set; }

        int Page { get; set; }
        int ItemsPerPage { get; set; }

        string SortBy { get; set; }
        bool Ascending { get; set; }

        string Search { get; }

        int TotalItems { get; set; }
    }
}
