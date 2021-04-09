using Dinobazis.Models;
using Dinobazis.Presenters;
using Dinobazis.ViewInterfaces;
using Dinobazis.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinobazis.Views
{
    public partial class DinoForm : Form, IDinokView
    {
        private int _id, _felfedezo_id, _tapforma_id;
        private byte[] _kep;
        private DinokPresenter presenter;

        public DinoForm()
        {
            InitializeComponent();
            presenter = new DinokPresenter(this);
            presenter.LoadData();
        }

        public dinoVM dino
        {
            get
            {
                var item = new dinoVM(
                    NevTextBox.Text,
                    FelfedezoComboBox.Text,
                    (int)FelDatumNum.Value,
                    MikoreltTextBox.Text,
                    LelohelyTextBox.Text,
                    ElohelyTextBox.Text,
                    TaplalekTextBox.Text,
                    TapFormaComboBox.Text,
                    TestmeretTextBox.Text,
                    TesttomegTextBox.Text,
                    LeirasTextBox.Text)
                    { id = _id > 0 ? _id : 0,
                    felfedezoId = _felfedezo_id,
                    taplalkozasiFormaId = _tapforma_id,
                    kep = _kep };

                return item;
            }
            set
            {
                NevTextBox.Text = value.nev;
                FelfedezoComboBox.Text = value.felfedezoNev;
                FelDatumNum.Value = value.felfedezesDatuma;
                MikoreltTextBox.Text = value.mikorelt;
                LelohelyTextBox.Text = value.lelohelyek;
                ElohelyTextBox.Text = value.elohelyek;
                TaplalekTextBox.Text = value.taplalekok;
                TapFormaComboBox.Text = value.taplalkozasiFormaNev;
                TestmeretTextBox.Text = value.testmeret;
                TesttomegTextBox.Text = value.testtomeg;
                LeirasTextBox.Text = value.leiras;

                ShowPicture(value.kep);

                _id = value.id;
                _felfedezo_id = presenter.GetFelfedezoId(value.felfedezoNev);
                _tapforma_id = presenter.GetTapFormaId(value.taplalkozasiFormaNev);
                _kep = value.kep;
            }
        }

        public string[] felfedezoList { set { FelfedezoComboBox.Items.AddRange(value); } }
        public string[] tapformaList { set { TapFormaComboBox.Items.AddRange(value); } }
        public string nevError { set => ErrorProvider.SetError(NevTextBox, value); }
        public string felfedezoError { set => ErrorProvider.SetError(FelfedezoComboBox, value); }
        public string felDatumError { set => ErrorProvider.SetError(FelDatumNum, value); }
        public string mikoreltError { set => ErrorProvider.SetError(MikoreltTextBox, value); }
        public string lelohelyekErrror { set => ErrorProvider.SetError(LelohelyTextBox, value); }
        public string elohelyekError { set => ErrorProvider.SetError(ElohelyTextBox, value); }
        public string taplalekError { set => ErrorProvider.SetError(TaplalekTextBox, value); }
        public string tapformaError { set => ErrorProvider.SetError(TapFormaComboBox, value); }
        public string testmeretError { set => ErrorProvider.SetError(TestmeretTextBox, value); }
        public string testtomegError { set => ErrorProvider.SetError(TesttomegTextBox, value); }
        public string leirasError { set => ErrorProvider.SetError(UploadButton, value); }

        private void OKButton_Click(object sender, EventArgs e)
        {
            _felfedezo_id = presenter.GetFelfedezoId(FelfedezoComboBox.Text);
            _tapforma_id = presenter.GetTapFormaId(TapFormaComboBox.Text);

            if (presenter.ValidateData())
                DialogResult = DialogResult.OK;
        }
        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.FileName = null;
            OpenFileDialog.Filter = "Minden típus (*.*) | *.*";
            DialogResult dr = OpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var fajlnev = OpenFileDialog.FileName;
                // Kiválasztottuk a feltöltendő fájlt
                if (!string.IsNullOrEmpty(fajlnev))
                {
                    _kep = File.ReadAllBytes(OpenFileDialog.FileName);
                    ShowPicture(dino.kep);
                }
            }
        }

        private void ShowPicture(byte[] data)
        {
            if (data != null)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    Image img = Image.FromStream(ms);
                    PictureBox.Image = img;
                }
            }
        }
    }
}
