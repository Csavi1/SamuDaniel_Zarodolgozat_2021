using Dinobazis.Services;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DinoButton_Click(object sender, EventArgs e)
        {
            LoadForm(new DinokListForm());
        }
        private void UserButton_Click(object sender, EventArgs e)
        {
            LoadForm(new UserListForm());
        }
        private void FelfedezoButton_Click(object sender, EventArgs e)
        {
            LoadForm(new FelfedezokForm());
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadForm(Form _Form)
        {
            //var Form = new MainForm();
            Hide();
            _Form.ShowDialog();
            Close();
        }
    }
}
