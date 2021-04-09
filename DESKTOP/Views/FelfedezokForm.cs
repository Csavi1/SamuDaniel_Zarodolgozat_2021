using Dinobazis.Models;
using Dinobazis.Presenters;
using Dinobazis.Properties;
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
    public partial class FelfedezokForm : Form, IFelfedezoView
    {
        private string[] _felfedezok;
        private int _id;
        private FelfedezokPresenter presenter;

        public FelfedezokForm()
        {
            InitializeComponent();
            presenter = new FelfedezokPresenter(this);
        }
        private void FelfedezokForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        public felfedezok ujFelfedezo
        {
            get
            {
                var item = new felfedezok(FelfedezoComboBox.Text) { id = _id > 0 ? _id : 0 };
                return item;
            }
            set
            {
                FelfedezoComboBox.Text = value.nev;
                _id = value.id;
            }
        }
        public string[] felfedezok
        {
            get => _felfedezok;
            set
            {
                FelfedezoComboBox.Items.Clear();
                FelfedezoComboBox.Items.AddRange(value);
                _felfedezok = value;
            }
        }
        public string felfedezoError { set => ErrorProvider.SetError(FelfedezoComboBox, value); }

        private void AddButton_Click(object sender, EventArgs e)
        {
            felfedezoError = null;
            if (string.IsNullOrWhiteSpace(ujFelfedezo.nev))
            {
                felfedezoError = Resources.FieldRequired;
                return;
            }

            presenter.Add(ujFelfedezo);
            ClearComboBoxText();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            felfedezoError = null;
            if (string.IsNullOrWhiteSpace(ujFelfedezo.nev))
            {
                felfedezoError = Resources.FieldRequired;
                return;
            }

            var felfedezoIndex = Array.IndexOf(felfedezok, ujFelfedezo.nev);
            if (felfedezoIndex == -1)
            {
                felfedezoError = Resources.ForbiddenValue;
                return;
            }

            presenter.Remove(felfedezoIndex);
            ClearComboBoxText();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            LoadMainForm();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            LoadMainForm();
        }

        private void ClearComboBoxText()
        {
            FelfedezoComboBox.Text = null;
        } 
        private void LoadMainForm()
        {
            Hide();
            new MainForm().ShowDialog();
            Close();
        }
    }
}
