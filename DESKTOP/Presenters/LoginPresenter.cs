using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dinobazis.Models;
using Dinobazis.Properties;
using Dinobazis.Repositories;
using Dinobazis.Services;
using Dinobazis.ViewInterfaces;

namespace Dinobazis.Presenter
{
    class LoginPresenter
    {
        private UserRepository repo;
        private ILoginView view;
        public bool LoginSuccess { get; private set; }


        public LoginPresenter(ILoginView param)
        {
            view = param;
            repo = new UserRepository();
        }


        private bool ConnectionExist()
        {
            return repo.DbExists();
        }
        public void CheckConnection()
        {
            if (!ConnectionExist())
            {
                view.LoginError = Resources.ConnectionError;
                return;
            }
            view.LoginError = null;
        }
        public void Authenticate()
        {
            view.LoginError = null;
            view.EmailError = null;
            view.PasswordError = null;

            LoginSuccess = false;

            if (!ConnectionExist())
                return;

            if (string.IsNullOrWhiteSpace(view.EmailAddress))
                view.EmailError = Resources.FieldRequired;
            if (string.IsNullOrWhiteSpace(view.Password))
                view.PasswordError = Resources.FieldRequired;

            if (string.IsNullOrWhiteSpace(view.EmailError))
            {
                var dbUser = repo.GetFelhasznalo(view.EmailAddress);
                if (dbUser != null)
                {
                    if (string.IsNullOrWhiteSpace(view.PasswordError))
                    {
                        if (Hash.Verify(view.Password, dbUser.jelszo))
                        {
                            if (dbUser.fejleszto_logikai)
                            {
                                LoginSuccess = true;
                                CurrentUser.Id = dbUser.id;
                            }
                            else
                            {
                                view.LoginError = Resources.PermissionError;
                            }
                        }
                        else
                        {
                            view.PasswordError = Resources.PasswordError;
                        }

                    }
                }
                else
                {
                    view.EmailError = Resources.EmailError;
                }
            }
        }
    }
}
