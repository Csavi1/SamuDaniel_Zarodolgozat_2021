using Dinobazis.Models;
using Dinobazis.Services;
using Dinobazis.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Repositories
{
    class UserRepository : IRepository<felhasznalok>
    {
        dinoContext db = new dinoContext();
        public bool DbExists()
        {
            return db.Database.Exists();
        }
        public felhasznalok GetFelhasznalo(string emailAddress)
        {
            return db.felhasznalok.SingleOrDefault(x => x.email.Equals(emailAddress));
        }

        public BindingList<felhasznalok> GetAll(int page = 0, int itemsPerPage = 0, string search = null, string sortBy = null, bool ascending = true)
        {
            var query = db.felhasznalok.OrderBy(x => x.id).Where(x => x.id != CurrentUser.Id).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.email.Contains(search) || x.nev.Contains(search));
            }

            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "email":
                        query = ascending ? query.OrderBy(x => x.email) : query.OrderByDescending(x => x.email);
                        break;

                    case "nev":
                        query = ascending ? query.OrderBy(x => x.nev) : query.OrderByDescending(x => x.nev);
                        break;

                    case "fejleszto":
                        query = ascending ? query.OrderBy(x => x.fejleszto_logikai) : query.OrderByDescending(x => x.fejleszto_logikai);
                        break;

                    default:
                        break;
                }
            }

            TotalItems = query.Count();

            if (page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            return new BindingList<felhasznalok>(query.ToList());
        }

        public int TotalItems { get; private set; }

        public void Delete(int id)
        {
            var record = db.felhasznalok.Find(id);
            if (record != null)
            {
                db.felhasznalok.Remove(record);
            }
        }
        public void Update(felhasznalok param)
        {
            var record = db.felhasznalok.Find(param.id);
            if (record != null)
            {
                db.Entry(record).CurrentValues.SetValues(param);
                db.Entry(record).State = EntityState.Modified;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        #region NotImplemented
        public void Insert(felhasznalok instance)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
