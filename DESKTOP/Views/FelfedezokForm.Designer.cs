
namespace Dinobazis.Views
{
    partial class FelfedezokForm
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
            this.FelfedezoComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Table.SuspendLayout();
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FelfedezoComboBox
            // 
            this.FelfedezoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FelfedezoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FelfedezoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FelfedezoComboBox.FormattingEnabled = true;
            this.FelfedezoComboBox.Location = new System.Drawing.Point(30, 66);
            this.FelfedezoComboBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.FelfedezoComboBox.Name = "FelfedezoComboBox";
            this.FelfedezoComboBox.Size = new System.Drawing.Size(406, 28);
            this.FelfedezoComboBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(491, 50);
            this.AddButton.Margin = new System.Windows.Forms.Padding(25, 50, 25, 50);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 60);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Hozzáadás";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Table
            // 
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.Controls.Add(this.FelfedezoComboBox, 0, 0);
            this.Table.Controls.Add(this.AddButton, 1, 0);
            this.Table.Controls.Add(this.RemoveButton, 2, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.Table.Size = new System.Drawing.Size(778, 160);
            this.Table.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(646, 50);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(25, 50, 25, 50);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(107, 60);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Törlés";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.Location = new System.Drawing.Point(110, 10);
            this.OKButton.Margin = new System.Windows.Forms.Padding(110, 10, 110, 20);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(169, 70);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Location = new System.Drawing.Point(499, 10);
            this.BackButton.Margin = new System.Windows.Forms.Padding(110, 10, 110, 20);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(169, 70);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Vissza";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 2;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.Controls.Add(this.OKButton, 0, 0);
            this.TLP.Controls.Add(this.BackButton, 1, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TLP.Location = new System.Drawing.Point(0, 244);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 1;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP.Size = new System.Drawing.Size(778, 100);
            this.TLP.TabIndex = 0;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FelfedezokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 344);
            this.Controls.Add(this.TLP);
            this.Controls.Add(this.Table);
            this.Name = "FelfedezokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinók könyve - Felfedezők";
            this.Load += new System.EventHandler(this.FelfedezokForm_Load);
            this.Table.ResumeLayout(false);
            this.TLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FelfedezoComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}