
namespace Dinobazis.Views
{
    partial class DinokListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinokListForm));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinoVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.DelButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.LayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.FirstButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felfedezo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feldatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikorelt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testmeret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testtomeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.RightClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dinoVMBindingSource)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.LayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.felfedezo,
            this.feldatum,
            this.mikorelt,
            this.tapforma,
            this.testmeret,
            this.testtomeg});
            this.DataGridView.ContextMenuStrip = this.RightClickMenu;
            this.DataGridView.DataSource = this.dinoVMBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(12, 51);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 42, 3, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(1154, 408);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.TabStop = false;
            this.DataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_ColumnHeaderMouseClick);
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenuItem,
            this.DelMenuItem});
            this.RightClickMenu.Name = "ContextMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(174, 68);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(173, 32);
            this.EditMenuItem.Text = "Szerkesztés";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // DelMenuItem
            // 
            this.DelMenuItem.Name = "DelMenuItem";
            this.DelMenuItem.Size = new System.Drawing.Size(173, 32);
            this.DelMenuItem.Text = "Törlés";
            // 
            // dinoVMBindingSource
            // 
            this.dinoVMBindingSource.DataSource = typeof(Dinobazis.ViewModels.dinoVM);
            // 
            // MenuBar
            // 
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.DelButton,
            this.SaveButton,
            this.Separator,
            this.SearchTextBox,
            this.SearchButton,
            this.HomeButton});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1178, 34);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "Menüsáv";
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(56, 29);
            this.NewButton.Text = "Új";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Image = ((System.Drawing.Image)(resources.GetObject("DelButton.Image")));
            this.DelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(85, 29);
            this.DelButton.Text = "Törlés";
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 29);
            this.SaveButton.Text = "Mentés";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(6, 34);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(200, 34);
            // 
            // SearchButton
            // 
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 29);
            this.SearchButton.Text = "Keresés";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0, 2, 9, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(99, 29);
            this.HomeButton.Text = "Főoldal";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LayoutPanelButton
            // 
            this.LayoutPanelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LayoutPanelButton.ColumnCount = 5;
            this.LayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPanelButton.Controls.Add(this.FirstButton, 0, 0);
            this.LayoutPanelButton.Controls.Add(this.PrevButton, 1, 0);
            this.LayoutPanelButton.Controls.Add(this.NextButton, 3, 0);
            this.LayoutPanelButton.Controls.Add(this.LastButton, 4, 0);
            this.LayoutPanelButton.Controls.Add(this.PageLabel, 2, 0);
            this.LayoutPanelButton.Location = new System.Drawing.Point(349, 462);
            this.LayoutPanelButton.Name = "LayoutPanelButton";
            this.LayoutPanelButton.RowCount = 1;
            this.LayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.LayoutPanelButton.Size = new System.Drawing.Size(480, 70);
            this.LayoutPanelButton.TabIndex = 0;
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(3, 17);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(90, 35);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.TabStop = false;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(99, 17);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(90, 35);
            this.PrevButton.TabIndex = 0;
            this.PrevButton.TabStop = false;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(291, 17);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(90, 35);
            this.NextButton.TabIndex = 0;
            this.NextButton.TabStop = false;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(387, 17);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(90, 35);
            this.LastButton.TabIndex = 0;
            this.LastButton.TabStop = false;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(224, 25);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(31, 20);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "1/1";
            // 
            // nev
            // 
            this.nev.DataPropertyName = "nev";
            this.nev.HeaderText = "Név";
            this.nev.MinimumWidth = 8;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // felfedezo
            // 
            this.felfedezo.DataPropertyName = "felfedezoNev";
            this.felfedezo.HeaderText = "Felfedező";
            this.felfedezo.MinimumWidth = 8;
            this.felfedezo.Name = "felfedezo";
            this.felfedezo.ReadOnly = true;
            // 
            // feldatum
            // 
            this.feldatum.DataPropertyName = "felfedezesDatuma";
            this.feldatum.HeaderText = "Felfedezés dátuma";
            this.feldatum.MinimumWidth = 8;
            this.feldatum.Name = "feldatum";
            this.feldatum.ReadOnly = true;
            // 
            // mikorelt
            // 
            this.mikorelt.DataPropertyName = "mikorelt";
            this.mikorelt.HeaderText = "Mikor élt?";
            this.mikorelt.MinimumWidth = 8;
            this.mikorelt.Name = "mikorelt";
            this.mikorelt.ReadOnly = true;
            // 
            // tapforma
            // 
            this.tapforma.DataPropertyName = "taplalkozasiFormaNev";
            this.tapforma.HeaderText = "Táplálkozási forma";
            this.tapforma.MinimumWidth = 8;
            this.tapforma.Name = "tapforma";
            this.tapforma.ReadOnly = true;
            // 
            // testmeret
            // 
            this.testmeret.DataPropertyName = "testmeret";
            this.testmeret.HeaderText = "Testméret";
            this.testmeret.MinimumWidth = 8;
            this.testmeret.Name = "testmeret";
            this.testmeret.ReadOnly = true;
            // 
            // testtomeg
            // 
            this.testtomeg.DataPropertyName = "testtomeg";
            this.testtomeg.HeaderText = "Testtömeg";
            this.testtomeg.MinimumWidth = 8;
            this.testtomeg.Name = "testtomeg";
            this.testtomeg.ReadOnly = true;
            // 
            // DinokListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.LayoutPanelButton);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.DataGridView);
            this.Name = "DinokListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinók könyve - Dinoszauruszok";
            this.Load += new System.EventHandler(this.DinokListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.RightClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dinoVMBindingSource)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.LayoutPanelButton.ResumeLayout(false);
            this.LayoutPanelButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ToolStrip MenuBar;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton DelButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelMenuItem;
        private System.Windows.Forms.TableLayoutPanel LayoutPanelButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.BindingSource dinoVMBindingSource;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn felfedezo;
        private System.Windows.Forms.DataGridViewTextBoxColumn feldatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mikorelt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tapforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn testmeret;
        private System.Windows.Forms.DataGridViewTextBoxColumn testtomeg;
    }
}