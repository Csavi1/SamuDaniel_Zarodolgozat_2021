using Dinobazis.Models;
using Dinobazis.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinobazis.Repositories
{
    class DinoDetailsRepository : IRepository<felfedezok>
    {
        private dinoContext db = new dinoContext();
        public int TotalItems { get; private set; }

        public BindingList<felfedezok> GetAll(int page = 0, int itemsPerPage = 0, string search = null, string sortBy = null, bool ascending = true)
        {
            var query = db.felfedezok.OrderBy(x => x.id).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.nev.Contains(search));

            if (!string.IsNullOrWhiteSpace(sortBy))
                query = ascending ? query.OrderBy(x => x.nev) : query.OrderByDescending(x => x.nev);

            TotalItems = query.Count();

            if (page + itemsPerPage > 0)
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);

            return new BindingList<felfedezok>(query.ToList());
        }

        public string[] GetAllTapForma()
        {
            return db.taplalkozasi_forma.Select(x => x.nev).ToArray();
        }

        public felfedezok GetFelfedezo(string felfedezoNev)
        {
            return db.felfedezok.AsNoTracking().SingleOrDefault(x => x.nev == felfedezoNev);
        }
        public taplalkozasi_forma GetTapForma(string tapFormaNev)
        { 
            return db.taplalkozasi_forma.AsNoTracking().SingleOrDefault(x => x.nev == tapFormaNev);
        }

        public void Insert(felfedezok instance)
        {
            db.felfedezok.Add(instance);
        }
        public void Delete(int id)
        {
            if (FelfedezoInUse(id))
                throw new Exception();

            var record = db.felfedezok.Find(id);
            if (record != null)
            {
                db.felfedezok.Remove(record);
            }
        }
        public bool DinoExists(string dinoNev)
        {
            return db.dinok.Any(x => x.nev == dinoNev);
        }
        private bool FelfedezoInUse(int felfedezoId)
        {
            return db.dinok.Any(x => x.felfedezo_id == felfedezoId);
        }

        public void Save()
        {
            db.SaveChanges();
        }
        #region NotImplemented
        public void Update(felfedezok param)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
