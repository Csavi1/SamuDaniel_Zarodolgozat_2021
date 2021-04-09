using Dinobazis.Repositories;
using Dinobazis.ViewInterfaces;
using Dinobazis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Presenters
{
    class DinokListPresenter : IPresenter<dinoVM>
    {
        private DinokRepository repo;
        private IDinokListView view;
        public DinokListPresenter(IDinokListView param)
        {
            view = param;
            repo = new DinokRepository();
        }

        public void LoadData()
        {
            view.BindingList = repo.GetAll(view.Page, view.ItemsPerPage, view.Search, view.SortBy, view.Ascending);
            view.TotalItems = repo.TotalItems;
        }
        public void Add(dinoVM newInstance)
        {
            view.BindingList.Insert(0, newInstance);
            view.TotalItems++;
            repo.Insert(newInstance);
        }
        public void Modify(int index, dinoVM instance)
        {
            if (instance.id != 0)
            {
                view.BindingList[index] = instance;
                repo.Update(instance);
            }
        }
        public void Remove(int index)
        {
            var item = view.BindingList.ElementAt(index);
            view.BindingList.RemoveAt(index);
            if (item.id != 0)
            {
                repo.Delete(item.id);
                view.TotalItems--;
            }
        }
        public void Save()
        {
            repo.Save();
        }
    }
}
