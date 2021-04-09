
namespace Dinobazis.Views
{
    partial class MainForm
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
            this.DinoButton = new System.Windows.Forms.Button();
            this.FelfedezoButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.BackgroundPanel = new System.Windows.Forms.TableLayoutPanel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TablePanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DinoButton
            // 
            this.DinoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DinoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DinoButton.Location = new System.Drawing.Point(20, 20);
            this.DinoButton.Margin = new System.Windows.Forms.Padding(20);
            this.DinoButton.Name = "DinoButton";
            this.DinoButton.Size = new System.Drawing.Size(179, 160);
            this.DinoButton.TabIndex = 0;
            this.DinoButton.TabStop = false;
            this.DinoButton.Text = "Dinoszauruszok";
            this.DinoButton.UseVisualStyleBackColor = true;
            this.DinoButton.Click += new System.EventHandler(this.DinoButton_Click);
            // 
            // FelfedezoButton
            // 
            this.FelfedezoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FelfedezoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelfedezoButton.Location = new System.Drawing.Point(458, 20);
            this.FelfedezoButton.Margin = new System.Windows.Forms.Padding(20);
            this.FelfedezoButton.Name = "FelfedezoButton";
            this.FelfedezoButton.Size = new System.Drawing.Size(180, 160);
            this.FelfedezoButton.TabIndex = 0;
            this.FelfedezoButton.TabStop = false;
            this.FelfedezoButton.Text = "Felfedezők";
            this.FelfedezoButton.UseVisualStyleBackColor = true;
            this.FelfedezoButton.Click += new System.EventHandler(this.FelfedezoButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserButton.Location = new System.Drawing.Point(239, 20);
            this.UserButton.Margin = new System.Windows.Forms.Padding(20);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(179, 160);
            this.UserButton.TabIndex = 0;
            this.UserButton.TabStop = false;
            this.UserButton.Text = "Felhasználók";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // TablePanel
            // 
            this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel.ColumnCount = 3;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanel.Controls.Add(this.DinoButton, 0, 0);
            this.TablePanel.Controls.Add(this.FelfedezoButton, 2, 0);
            this.TablePanel.Controls.Add(this.UserButton, 1, 0);
            this.TablePanel.Location = new System.Drawing.Point(60, 66);
            this.TablePanel.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 1;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TablePanel.Size = new System.Drawing.Size(658, 200);
            this.TablePanel.TabIndex = 0;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.ColumnCount = 1;
            this.BackgroundPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundPanel.Controls.Add(this.TablePanel, 0, 0);
            this.BackgroundPanel.Controls.Add(this.QuitButton, 0, 1);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.RowCount = 2;
            this.BackgroundPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.BackgroundPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BackgroundPanel.Size = new System.Drawing.Size(778, 444);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // QuitButton
            // 
            this.QuitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuitButton.Location = new System.Drawing.Point(590, 336);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(158, 78);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.TabStop = false;
            this.QuitButton.Text = "Kilépés";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinók könyve - Főoldal";
            this.TablePanel.ResumeLayout(false);
            this.BackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DinoButton;
        private System.Windows.Forms.Button FelfedezoButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.TableLayoutPanel BackgroundPanel;
        private System.Windows.Forms.Button QuitButton;
    }
}