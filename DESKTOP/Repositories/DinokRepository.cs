using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dinobazis.Models;
using Dinobazis.ViewInterfaces;
using Dinobazis.ViewModels;

namespace Dinobazis.Repositories
{
    class DinokRepository : IRepository<dinoVM>
    {
        private dinoContext db = new dinoContext();
        public int TotalItems { get; private set; }

        public BindingList<dinoVM> GetAll(int page = 0, int itemsPerPage = 0, string search = null, string sortBy = null, bool ascending = true)
        {
            var query = db.dinok.OrderBy(x => x.id).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                if (int.TryParse(search, out int num))
                {
                    query = query.Where(x =>
                    x.felfedezes_datuma.Equals(num) ||
                    x.testmeret.Contains(search) ||
                    x.testtomeg.Contains(search)
                    );
                }
                else
                {
                    query = query.Where(x =>
                    x.nev.Contains(search) ||
                    x.felfedezok.nev.Contains(search) ||
                    x.mikorelt.Contains(search) ||
                    x.lelohelyek.Contains(search) ||
                    x.elohelyek.Contains(search) ||
                    x.taplalek.Contains(search) ||
                    x.taplalkozasi_forma.nev.Contains(search) ||
                    x.testmeret.Contains(search) ||
                    x.testtomeg.Contains(search) ||
                    x.leiras.Contains(search)
                    );
                }
                
            }

            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "nev":
                        query = ascending ? query.OrderBy(x => x.nev) : query.OrderByDescending(x => x.nev);
                        break;

                    case "felfedezo":
                        query = ascending ? query.OrderBy(x => x.felfedezok.nev) : query.OrderByDescending(x => x.felfedezok.nev);
                        break;

                    case "feldatum":
                        query = ascending ? query.OrderBy(x => x.felfedezes_datuma) : query.OrderByDescending(x => x.felfedezes_datuma);
                        break;

                    case "mikorelt":
                        query = ascending ? query.OrderBy(x => x.mikorelt) : query.OrderByDescending(x => x.mikorelt);
                        break;
                    
                    case "tapforma":
                        query = ascending ? query.OrderBy(x => x.taplalkozasi_forma.nev) : query.OrderByDescending(x => x.taplalkozasi_forma.nev);
                        break;

                    case "testmeret":
                        query = ascending ? query.OrderBy(x => x.testmeret) : query.OrderByDescending(x => x.testmeret);
                        break;

                    case "testtomeg":
                        query = ascending ? query.OrderBy(x => x.testtomeg) : query.OrderByDescending(x => x.testtomeg);
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

            var dbList = query.ToList();

            var dinoVMList = new List<dinoVM>();
            foreach (var i in dbList)
            {
                dinoVMList.Add(new dinoVM(i.id, i.nev, i.felfedezo_id, i.felfedezok.nev, i.felfedezes_datuma, i.mikorelt, i.lelohelyek, i.elohelyek, i.taplalek, i.taplalkozasi_forma_id, i.taplalkozasi_forma.nev, i.testmeret, i.testtomeg, i.leiras, i.kep));
            }

            return new BindingList<dinoVM>(dinoVMList);
        }

        //public dinok GetDino(string nev)
        //{
        //    return db.dinok.AsNoTracking().SingleOrDefault(x => x.nev.Equals(nev));
        //}
        public void Insert(dinoVM dinoVM)
        {
            var dino = new dinok(dinoVM.nev, dinoVM.felfedezoId, dinoVM.felfedezesDatuma, dinoVM.mikorelt, dinoVM.lelohelyek, dinoVM.elohelyek, dinoVM.taplalekok, dinoVM.taplalkozasiFormaId, dinoVM.testmeret, dinoVM.testtomeg, dinoVM.leiras, dinoVM.kep);
            db.dinok.Add(dino);
        }
        public void Update(dinoVM param)
        {
            var record = db.dinok.Find(param.id);
            if (record != null)
            {
                record.nev = param.nev;
                record.felfedezo_id = param.felfedezoId;
                record.felfedezes_datuma = param.felfedezesDatuma;
                record.mikorelt = param.mikorelt;
                record.lelohelyek = param.lelohelyek;
                record.elohelyek = param.elohelyek;
                record.taplalek = param.taplalekok;
                record.taplalkozasi_forma_id = param.taplalkozasiFormaId;
                record.testmeret = param.testmeret;
                record.testtomeg = param.testtomeg;
                record.kep = param.kep;
                record.leiras = param.leiras;

                db.Entry(record).State = EntityState.Modified;
            }
        }
        public void Delete(int id)
        {
            var record = db.dinok.Find(id);
            db.dinok.Remove(record);
        }
        public void Save()
        {
            db.SaveChanges();
        }
        //public bool Exists(dinoVM dinoVM)
        //{
        //    return db.dinok.Any(x => x.id == dinoVM.id);
        //}
    }
}
