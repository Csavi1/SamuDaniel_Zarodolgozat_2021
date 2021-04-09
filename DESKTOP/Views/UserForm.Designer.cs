
namespace Dinobazis.Views
{
    partial class UserForm
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NevLabel = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NevTextBox = new System.Windows.Forms.TextBox();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(79, 58);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(81, 20);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "E-mail cím";
            // 
            // NevLabel
            // 
            this.NevLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NevLabel.AutoSize = true;
            this.NevLabel.Location = new System.Drawing.Point(59, 194);
            this.NevLabel.Name = "NevLabel";
            this.NevLabel.Size = new System.Drawing.Size(120, 20);
            this.NevLabel.TabIndex = 3;
            this.NevLabel.Text = "Felhasználónév";
            // 
            // AdminLabel
            // 
            this.AdminLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Location = new System.Drawing.Point(78, 330);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(82, 20);
            this.AdminLabel.TabIndex = 5;
            this.AdminLabel.Text = "Fejlesztő?";
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.Location = new System.Drawing.Point(30, 438);
            this.OKButton.Margin = new System.Windows.Forms.Padding(30);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(179, 76);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Location = new System.Drawing.Point(269, 438);
            this.BackButton.Margin = new System.Windows.Forms.Padding(30);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(179, 76);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Mégse";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(242, 55);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 24, 3);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(212, 26);
            this.EmailTextBox.TabIndex = 2;
            // 
            // NevTextBox
            // 
            this.NevTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NevTextBox.Location = new System.Drawing.Point(242, 191);
            this.NevTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 24, 3);
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(212, 26);
            this.NevTextBox.TabIndex = 4;
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Location = new System.Drawing.Point(325, 328);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(67, 24);
            this.AdminCheckBox.TabIndex = 6;
            this.AdminCheckBox.Text = "Igen";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 2;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.Controls.Add(this.EmailLabel, 0, 0);
            this.TLP.Controls.Add(this.BackButton, 1, 3);
            this.TLP.Controls.Add(this.AdminCheckBox, 1, 2);
            this.TLP.Controls.Add(this.NevLabel, 0, 1);
            this.TLP.Controls.Add(this.NevTextBox, 1, 1);
            this.TLP.Controls.Add(this.OKButton, 0, 3);
            this.TLP.Controls.Add(this.AdminLabel, 0, 2);
            this.TLP.Controls.Add(this.EmailTextBox, 1, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 4;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP.Size = new System.Drawing.Size(478, 544);
            this.TLP.TabIndex = 0;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.TLP);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinók könyve";
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NevLabel;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}