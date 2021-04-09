using Dinobazis.ViewInterfaces;
using Dinobazis.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dinobazis.Models;
using Dinobazis.Presenters;

namespace Dinobazis.Views
{
    public partial class UserListForm : Form, IUserListView
    {
        private UserListPresenter presenter;
        private int _totalItems;
        private int _sortIndex;
        private int _pageCount;

        public UserListForm()
        {
            InitializeComponent();
            presenter = new UserListPresenter(this);
            Ini();
        }
        private void Ini()
        {
            _sortIndex = 0;
            Page = 1;
            ItemsPerPage = 10;
            Ascending = true;
        }

        public BindingList<felhasznalok> BindingList { get => (BindingList<felhasznalok>)DataGridView.DataSource; set => DataGridView.DataSource = value; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public string SortBy { get; set; }
        public bool Ascending { get; set; }

        public string Search => SearchTextBox.Text;

        public int TotalItems
        {
            get => _totalItems;
            set
            {
                _totalItems = value;
                _pageCount = (value - 1) / ItemsPerPage + 1;
                PageLabel.Text = Page + "/" + _pageCount;
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_sortIndex == e.ColumnIndex)
                Ascending = !Ascending;

            switch (e.ColumnIndex)
            {
                case 0:
                    SortBy = "email";
                    break;

                case 1:
                    SortBy = "nev";
                    break;

                case 2:
                    SortBy = "fejleszto";
                    break;
                
                default:
                    break;
            }

            _sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedCells.Count > 0)
            {
                var sorIndex = DataGridView.SelectedCells[0].RowIndex;
                DataGridView.Rows[sorIndex].Selected = true;
                AlterPermissions(sorIndex);
            }
        }
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedCells.Count > 0)
            {
                var sorIndex = DataGridView.SelectedCells[0].RowIndex;
                DataGridView.Rows[sorIndex].Selected = true;
                EditRecord(sorIndex);
            }
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            DelRecord();
        }
        private void DelMenuItem_Click(object sender, EventArgs e)
        {
            DelRecord();
        }

        private void DelRecord()
        {
            for (int i = 0; i < DataGridView.SelectedCells.Count; i++)
            {
                var sorIndex = DataGridView.SelectedCells[i].RowIndex;
                DataGridView.Rows[sorIndex].Selected = true;
            }

            while (DataGridView.SelectedRows.Count > 0)
            {
                presenter.Remove(DataGridView.SelectedCells[0].RowIndex);
            }
        }
        private void EditRecord(int index)
        {
            var record = (felhasznalok)DataGridView.Rows[index].DataBoundItem;
            using (var editForm = new UserForm())
            {
                editForm.user = record;
                DialogResult dialogResult = editForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    presenter.Modify(index, editForm.user);
                    editForm.Close();
                }
            }
        }
        private void AlterPermissions(int index)
        {
            var record = (felhasznalok)DataGridView.Rows[index].DataBoundItem;
            presenter.ChangePermission(index, record);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MainForm().ShowDialog();
            Close();
        }
    }
}
