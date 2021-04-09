using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewInterfaces
{
    interface IRepository<Type>
    {
        int TotalItems { get; }

        BindingList<Type> GetAll(int page = 0, int itemsPerPage = 0, string search = null, string sortBy = null, bool ascending = true);
        
        void Insert(Type instance);
        void Update(Type param);
        void Delete(int id);

        void Save();
    }
}
