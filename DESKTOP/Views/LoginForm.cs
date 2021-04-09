using Dinobazis.Presenter;
using Dinobazis.ViewInterfaces;
using Dinobazis.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinobazis.View
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter presenter;
        public string EmailAddress => EmailTextBox.Text;
        public string Password => PasswordTextBox.Text;
        public string EmailError { set => ErrorProvider.SetError(EmailTextBox, value); get => ErrorProvider.GetError(EmailTextBox); } 
        public string PasswordError { set => ErrorProvider.SetError(PasswordTextBox, value); get => ErrorProvider.GetError(PasswordTextBox); }
        public string LoginError { set => ErrorProvider.SetError(LoginButton, value); get => ErrorProvider.GetError(LoginButton); }

        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            presenter.CheckConnection();
        }
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            presenter.Authenticate();
            if (presenter.LoginSuccess)
            {
                var MainForm = new MainForm();
                Hide();
                MainForm.ShowDialog();
                Close();
            }
        }
    }
}
