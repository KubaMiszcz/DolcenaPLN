namespace dolcenapln
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stawkaUSD_textbox = new System.Windows.Forms.TextBox();
            this.cenaUSD_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cenaPLN_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.zawszeNaWierzchuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przezroczystość75ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kubaMiszcz2015ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveRate = new System.Windows.Forms.Button();
            this.btnAlwaysOnTop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stawkaUSD_textbox
            // 
            this.stawkaUSD_textbox.Location = new System.Drawing.Point(35, 26);
            this.stawkaUSD_textbox.Name = "stawkaUSD_textbox";
            this.stawkaUSD_textbox.Size = new System.Drawing.Size(50, 19);
            this.stawkaUSD_textbox.TabIndex = 10;
            this.stawkaUSD_textbox.Text = "3,75";
            this.stawkaUSD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stawkaUSD_textbox.TextChanged += new System.EventHandler(this.stawkaUSD_textbox_TextChanged);
            // 
            // cenaUSD_textbox
            // 
            this.cenaUSD_textbox.Location = new System.Drawing.Point(35, 54);
            this.cenaUSD_textbox.Name = "cenaUSD_textbox";
            this.cenaUSD_textbox.Size = new System.Drawing.Size(50, 19);
            this.cenaUSD_textbox.TabIndex = 0;
            this.cenaUSD_textbox.Text = "1";
            this.cenaUSD_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cenaUSD_textbox.TextChanged += new System.EventHandler(this.cenaUSD_textbox_TextChanged);
            this.cenaUSD_textbox.MouseHover += new System.EventHandler(this.cenaUSD_textbox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(84, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 9);
            this.label1.TabIndex = 3;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(-1, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 9);
            this.label2.TabIndex = 3;
            this.label2.Text = "1PLN=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(84, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 9);
            this.label3.TabIndex = 3;
            this.label3.Text = "USD";
            // 
            // cenaPLN_textbox
            // 
            this.cenaPLN_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cenaPLN_textbox.Location = new System.Drawing.Point(35, 81);
            this.cenaPLN_textbox.Name = "cenaPLN_textbox";
            this.cenaPLN_textbox.ReadOnly = true;
            this.cenaPLN_textbox.Size = new System.Drawing.Size(50, 19);
            this.cenaPLN_textbox.TabIndex = 1;
            this.cenaPLN_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cenaPLN_textbox.TextChanged += new System.EventHandler(this.cenaPLN_textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(84, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 9);
            this.label4.TabIndex = 3;
            this.label4.Text = "PLN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(201, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMinimize
            // 
            this.mnuMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuMinimize.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.mnuMinimize.Name = "mnuMinimize";
            this.mnuMinimize.Size = new System.Drawing.Size(50, 20);
            this.mnuMinimize.Text = "Minimize";
            this.mnuMinimize.Click += new System.EventHandler(this.mnuMinimize_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zawszeNaWierzchuToolStripMenuItem,
            this.przezroczystość75ToolStripMenuItem,
            this.kubaMiszcz2015ToolStripMenuItem});
            this.mnuSettings.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(107, 20);
            this.mnuSettings.Text = "Ustawienia Kuby Miszcza";
            // 
            // zawszeNaWierzchuToolStripMenuItem
            // 
            this.zawszeNaWierzchuToolStripMenuItem.Name = "zawszeNaWierzchuToolStripMenuItem";
            this.zawszeNaWierzchuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.zawszeNaWierzchuToolStripMenuItem.Text = "Zawsze na wierzchu";
            this.zawszeNaWierzchuToolStripMenuItem.Click += new System.EventHandler(this.zawszeNaWierzchuToolStripMenuItem_Click);
            // 
            // przezroczystość75ToolStripMenuItem
            // 
            this.przezroczystość75ToolStripMenuItem.Name = "przezroczystość75ToolStripMenuItem";
            this.przezroczystość75ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.przezroczystość75ToolStripMenuItem.Text = "przezroczystość 75%";
            this.przezroczystość75ToolStripMenuItem.Click += new System.EventHandler(this.przezroczystość75ToolStripMenuItem_Click);
            // 
            // kubaMiszcz2015ToolStripMenuItem
            // 
            this.kubaMiszcz2015ToolStripMenuItem.Name = "kubaMiszcz2015ToolStripMenuItem";
            this.kubaMiszcz2015ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.kubaMiszcz2015ToolStripMenuItem.Text = "Pomoc/About";
            this.kubaMiszcz2015ToolStripMenuItem.Click += new System.EventHandler(this.kubaMiszcz2015ToolStripMenuItem_Click);
            // 
            // btnSaveRate
            // 
            this.btnSaveRate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveRate.BackgroundImage")));
            this.btnSaveRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveRate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveRate.FlatAppearance.BorderSize = 0;
            this.btnSaveRate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSaveRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRate.Location = new System.Drawing.Point(108, 26);
            this.btnSaveRate.Name = "btnSaveRate";
            this.btnSaveRate.Size = new System.Drawing.Size(20, 20);
            this.btnSaveRate.TabIndex = 12;
            this.btnSaveRate.UseVisualStyleBackColor = true;
            this.btnSaveRate.Click += new System.EventHandler(this.btnSaveRate_Click);
            // 
            // btnAlwaysOnTop
            // 
            this.btnAlwaysOnTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlwaysOnTop.BackgroundImage")));
            this.btnAlwaysOnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlwaysOnTop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlwaysOnTop.FlatAppearance.BorderSize = 0;
            this.btnAlwaysOnTop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAlwaysOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlwaysOnTop.Location = new System.Drawing.Point(134, 27);
            this.btnAlwaysOnTop.Name = "btnAlwaysOnTop";
            this.btnAlwaysOnTop.Size = new System.Drawing.Size(20, 20);
            this.btnAlwaysOnTop.TabIndex = 13;
            this.btnAlwaysOnTop.UseVisualStyleBackColor = true;
            this.btnAlwaysOnTop.Click += new System.EventHandler(this.btnAlwaysOnTop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(201, 106);
            this.Controls.Add(this.btnAlwaysOnTop);
            this.Controls.Add(this.btnSaveRate);
            this.Controls.Add(this.cenaPLN_textbox);
            this.Controls.Add(this.cenaUSD_textbox);
            this.Controls.Add(this.stawkaUSD_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "USD->PLN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stawkaUSD_textbox;
        private System.Windows.Forms.TextBox cenaUSD_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cenaPLN_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem zawszeNaWierzchuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kubaMiszcz2015ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przezroczystość75ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMinimize;
        private System.Windows.Forms.Button btnSaveRate;
        private System.Windows.Forms.Button btnAlwaysOnTop;
    }
}

