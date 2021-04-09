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
    class UserPresenter
    {
        UserRepository repo;
        IUserView view;

        public UserPresenter(IUserView param)
        {
            view = param;
            repo = new UserRepository();
        }

        public bool ValidateData()
        {
            bool isValid = true;

            view.nevError = null;
            if (string.IsNullOrWhiteSpace(view.user.nev))
            {
                view.nevError = Resources.FieldRequired;
                isValid = false;
            }

            view.emailError = null;
            if (string.IsNullOrWhiteSpace(view.user.email))
            {
                view.emailError = Resources.FieldRequired;
                isValid = false;
            }

            return isValid;
        }
    }
}
