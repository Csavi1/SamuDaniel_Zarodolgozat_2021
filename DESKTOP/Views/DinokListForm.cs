using Dinobazis.Presenters;
using Dinobazis.ViewInterfaces;
using Dinobazis.ViewModels;
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
    public partial class DinokListForm : Form, IDinokListView
    {
        private DinokListPresenter presenter;
        private int _totalItems;
        private int _sortIndex;
        private int _pageCount;


        public DinokListForm()
        {
            InitializeComponent();
            presenter = new DinokListPresenter(this);
            Ini();
        }
        private void Ini()
        {
            _sortIndex = 0;
            Page = 1;
            ItemsPerPage = 10;
            Ascending = true;
        }

        public BindingList<dinoVM> BindingList { get => (BindingList<dinoVM>)DataGridView.DataSource; set => DataGridView.DataSource = value; }

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

        private void DinokListForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_sortIndex == e.ColumnIndex)
                Ascending = !Ascending;

            switch (e.ColumnIndex)
            {
                case 0:
                    SortBy = "nev";
                    break;
                case 1:
                    SortBy = "felfedezo";
                    break;
                case 2:
                    SortBy = "feldatum";
                    break;
                case 3:
                    SortBy = "mikorelt";
                    break;
                case 4:
                    SortBy = "tapforma";
                    break;
                case 5:
                    SortBy = "testmeret";
                    break;
                case 6:
                    SortBy = "testtomeg";
                    break;
                default:
                    break;
            }

            _sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewRecord();
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            DelRecord();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            Page = 1;
            presenter.LoadData();
        }
        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (Page > 1)
            {
                Page--;
                presenter.LoadData();
            }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Page < _pageCount)
            {
                Page++;
                presenter.LoadData();
            }
        }
        private void LastButton_Click(object sender, EventArgs e)
        {
            Page = _pageCount;
            presenter.LoadData();
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedCells.Count > 0)
            {
                var sorIndex = DataGridView.SelectedCells[0].RowIndex;
                //DataGridView.ClearSelection();
                DataGridView.Rows[sorIndex].Selected = true;
                EditRecord(sorIndex);
            }
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
        private void NewRecord()
        {
            using (var editForm = new DinoForm())
            {
                DialogResult dialogResult = editForm.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    presenter.Add(editForm.dino);
                    editForm.Close();
                }
            }
        }
        private void EditRecord(int index)
        {
            var record = (dinoVM)DataGridView.Rows[index].DataBoundItem;
            using (var editForm = new DinoForm())
            {
                editForm.dino = record;
                DialogResult dialogResult = editForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    presenter.Modify(index, editForm.dino);
                    editForm.Close();
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MainForm().ShowDialog();
            Close();
        }
    }
}
