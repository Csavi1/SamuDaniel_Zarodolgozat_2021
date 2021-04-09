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
    class DinokPresenter
    {
        private DinoDetailsRepository repo;
        private IDinokView view;
        public DinokPresenter(IDinokView param)
        {
            view = param;
            repo = new DinoDetailsRepository();
        }

        public void LoadData()
        {
            view.felfedezoList = repo.GetAll().Select(x => x.nev).ToArray();
            view.tapformaList = repo.GetAllTapForma();
        }
        public bool ValidateData()
        {
            bool isValid = true;

            view.nevError = null;
            if (string.IsNullOrWhiteSpace(view.dino.nev))
            {
                view.nevError = Resources.FieldRequired;
                isValid = false;
            }
            else if (repo.DinoExists(view.dino.nev))
            {
                view.nevError = Resources.AlreadyExists;
                isValid = false;
            }

            view.felfedezoError = null;
            if (string.IsNullOrWhiteSpace(view.dino.felfedezoNev))
            {
                view.felfedezoError = Resources.FieldRequired;
                isValid = false;
            }
            else if (view.dino.felfedezoId == 0)
            {
                view.felfedezoError = Resources.ForbiddenValue;
                isValid = false;
            }

            view.felDatumError = null;
            if (view.dino.felfedezesDatuma < 1 || view.dino.felfedezesDatuma > 2021)
            {
                view.felDatumError = Resources.FieldRequired;
                isValid = false;
            }

            view.mikoreltError = null;
            if (string.IsNullOrWhiteSpace(view.dino.mikorelt))
            {
                view.mikoreltError = Resources.FieldRequired;
                isValid = false;
            }

            view.lelohelyekErrror = null;
            if (string.IsNullOrWhiteSpace(view.dino.lelohelyek))
            {
                view.lelohelyekErrror = Resources.FieldRequired;
                isValid = false;
            }

            view.elohelyekError = null;
            if (string.IsNullOrWhiteSpace(view.dino.elohelyek))
            {
                view.elohelyekError = Resources.FieldRequired;
                isValid = false;
            }

            view.taplalekError = null;
            if (string.IsNullOrWhiteSpace(view.dino.taplalekok))
            {
                view.taplalekError = Resources.FieldRequired;
                isValid = false;
            }

            view.tapformaError = null;
            if (string.IsNullOrWhiteSpace(view.dino.taplalkozasiFormaNev))
            {
                view.tapformaError = Resources.FieldRequired;
                isValid = false;
            }
            else if (view.dino.taplalkozasiFormaId == 0)
            {
                view.tapformaError = Resources.ForbiddenValue;
                isValid = false;
            }

            view.testmeretError = null;
            if (string.IsNullOrWhiteSpace(view.dino.testmeret))
            {
                view.testmeretError = Resources.FieldRequired;
                isValid = false;
            }
            else if (!view.dino.testmeret.Any(char.IsDigit))
            {
                view.testmeretError = Resources.MustContainDigit;
                isValid = false;
            }

            view.testtomegError = null;
            if (string.IsNullOrWhiteSpace(view.dino.testtomeg))
            {
                view.testtomegError = Resources.FieldRequired;
                isValid = false;
            }
            else if (!view.dino.testtomeg.Any(char.IsDigit))
            {
                view.testtomegError = Resources.MustContainDigit;
                isValid = false;
            }

            view.leirasError = null;
            if (string.IsNullOrWhiteSpace(view.dino.leiras))
            {
                view.leirasError = Resources.FieldRequired;
                isValid = false;
            }

            return isValid;
        }
        public int GetFelfedezoId(string felfedezoNev)
        {
            var felfedezo = repo.GetFelfedezo(felfedezoNev);
            if (felfedezo != null)
            {
                return felfedezo.id;
            }
            return 0;
        }
        public int GetTapFormaId(string tapFormaNev)
        {
            var forma = repo.GetTapForma(tapFormaNev);
            if (forma != null)
            {
                return forma.id;
            }
            return 0;
        }
    }
}
