using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.ViewInterfaces
{
    interface IPresenter<T>
    {
        void LoadData();

        void Add(T newInstance);
        void Modify(int index, T instance);
        void Remove(int index);
        void Save();
    }
}
