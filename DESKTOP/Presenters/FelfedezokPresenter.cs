using Dinobazis.Models;
using Dinobazis.Properties;
using Dinobazis.Repositories;
using Dinobazis.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Presenters
{
    class FelfedezokPresenter : IPresenter<felfedezok>
    {
        private IFelfedezoView view;
        private DinoDetailsRepository repo;

        public FelfedezokPresenter(IFelfedezoView param)
        {
            view = param;
            repo = new DinoDetailsRepository();
        }

        public void LoadData()
        {
            view.felfedezok = repo.GetAll().Select(x => x.nev).ToArray();
        }
        public void Add(felfedezok newInstance)
        {
            if (view.felfedezok.Contains(newInstance.nev))
            {
                view.felfedezoError = Resources.AlreadyExists;
                return;
            }

            repo.Insert(newInstance);

            var _list = view.felfedezok.ToList();
            _list.Add(newInstance.nev);
            view.felfedezok = _list.ToArray();
        }
        public void Remove(int index)
        {
            var felfedezoNev = view.felfedezok.ElementAt(index);
            if (felfedezoNev == null) return;

            var felfedezo = repo.GetFelfedezo(felfedezoNev);
            if (felfedezo == null) return;

            try { repo.Delete(felfedezo.id); }
            catch (Exception) { view.felfedezoError = Resources.CannotDeletePerson; return; }

            var _list = view.felfedezok.ToList();
            _list.RemoveAt(index);
            view.felfedezok = _list.ToArray();
        }
        public void Save()
        {
            repo.Save();
        }

        #region NotImplemented
        public void Modify(int index, felfedezok instance)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
