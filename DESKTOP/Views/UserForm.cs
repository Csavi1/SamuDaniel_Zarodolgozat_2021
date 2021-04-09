using Dinobazis.Models;
using Dinobazis.Presenters;
using Dinobazis.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinobazis.Views
{
    public partial class UserForm : Form, IUserView
    {
        private UserPresenter presenter;
        private int _id;
        private string _jelszo;

        public UserForm()
        {
            InitializeComponent();
            presenter = new UserPresenter(this);
        }

        public felhasznalok user
        {
            get
            {
                var item = new felhasznalok(
                    EmailTextBox.Text,
                    NevTextBox.Text,
                    _jelszo,
                    AdminCheckBox.Checked)
                    { id = _id > 0 ? _id : 0 };

                return item;
            }
            set
            {
                NevTextBox.Text = value.nev;
                EmailTextBox.Text = value.email;
                AdminCheckBox.Checked = value.fejleszto_logikai;

                _id = value.id;
                _jelszo = value.jelszo;
            }
        }

        public string emailError { set => ErrorProvider.SetError(EmailTextBox, value); }
        public string nevError { set => ErrorProvider.SetError(NevTextBox, value); }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (presenter.ValidateData())
                DialogResult = DialogResult.OK;
        }
    }
}
