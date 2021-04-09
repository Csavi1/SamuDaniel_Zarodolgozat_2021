using Dinobazis.Models;
using Dinobazis.Repositories;
using Dinobazis.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Presenters
{
    class UserListPresenter : IPresenter<felhasznalok>
    {
        private IUserListView view;
        private UserRepository repo;
        public UserListPresenter(IUserListView param)
        {
            view = param;
            repo = new UserRepository();
        }

        public void LoadData()
        {
            view.BindingList = repo.GetAll(view.Page, view.ItemsPerPage, view.Search, view.SortBy, view.Ascending);
            view.TotalItems = repo.TotalItems;
        }
        public void Remove(int index)
        {
            var item = view.BindingList.ElementAt(index);
            if (item.id != 0)
            {
                view.BindingList.RemoveAt(index);
                view.TotalItems--;
                repo.Delete(item.id);
            }
        }
        public void Save()
        {
            repo.Save();
        }
        public void Modify(int index, felhasznalok instance)
        {
            if (instance.id != 0)
            {
                view.BindingList[index] = instance;
                repo.Update(instance);
            }
        }

        public void ChangePermission(int index, felhasznalok param)
        {
            param.fejleszto_logikai = !param.fejleszto_logikai;
            Modify(index, param);
        }

        #region NotImplemented
        public void Add(felhasznalok newInstance)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
