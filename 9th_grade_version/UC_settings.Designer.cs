namespace PC9G
{
    partial class UC_settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkForUpdates = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Label();
            this.settingsContainer = new System.Windows.Forms.Panel();
            this.changeTheme = new System.Windows.Forms.Button();
            this.developers = new System.Windows.Forms.Label();
            this.MK = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BK = new System.Windows.Forms.Label();
            this.atom = new System.Windows.Forms.PictureBox();
            this.copyright = new System.Windows.Forms.PictureBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.settingsContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyright)).BeginInit();
            this.SuspendLayout();
            // 
            // checkForUpdates
            // 
            this.checkForUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.checkForUpdates.FlatAppearance.BorderSize = 0;
            this.checkForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkForUpdates.ForeColor = System.Drawing.Color.White;
            this.checkForUpdates.Location = new System.Drawing.Point(3, 34);
            this.checkForUpdates.Name = "checkForUpdates";
            this.checkForUpdates.Size = new System.Drawing.Size(165, 25);
            this.checkForUpdates.TabIndex = 4;
            this.checkForUpdates.Text = "Проверете за нова версия";
            this.checkForUpdates.UseVisualStyleBackColor = false;
            this.checkForUpdates.Click += new System.EventHandler(this.checkForUpdates_Click);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(3, 62);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(44, 16);
            this.update.TabIndex = 5;
            this.update.Text = "label1";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsContainer
            // 
            this.settingsContainer.Controls.Add(this.changeTheme);
            this.settingsContainer.Controls.Add(this.update);
            this.settingsContainer.Controls.Add(this.checkForUpdates);
            this.settingsContainer.Location = new System.Drawing.Point(86, 303);
            this.settingsContainer.Name = "settingsContainer";
            this.settingsContainer.Size = new System.Drawing.Size(171, 81);
            this.settingsContainer.TabIndex = 6;
            // 
            // changeTheme
            // 
            this.changeTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.changeTheme.FlatAppearance.BorderSize = 0;
            this.changeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeTheme.ForeColor = System.Drawing.Color.White;
            this.changeTheme.Location = new System.Drawing.Point(3, 3);
            this.changeTheme.Name = "changeTheme";
            this.changeTheme.Size = new System.Drawing.Size(165, 25);
            this.changeTheme.TabIndex = 6;
            this.changeTheme.Text = "Промени темата";
            this.changeTheme.UseVisualStyleBackColor = false;
            this.changeTheme.Click += new System.EventHandler(this.changeTheme_Click);
            // 
            // developers
            // 
            this.developers.AutoSize = true;
            this.developers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developers.ForeColor = System.Drawing.Color.White;
            this.developers.Location = new System.Drawing.Point(64, 3);
            this.developers.Name = "developers";
            this.developers.Size = new System.Drawing.Size(352, 55);
            this.developers.TabIndex = 6;
            this.developers.Text = "Създадено от:";
            this.developers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MK
            // 
            this.MK.AutoSize = true;
            this.MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MK.ForeColor = System.Drawing.Color.White;
            this.MK.Location = new System.Drawing.Point(68, 65);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(254, 31);
            this.MK.TabIndex = 8;
            this.MK.Text = "Момчил Калестров";
            this.MK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GV
            // 
            this.GV.AutoSize = true;
            this.GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GV.ForeColor = System.Drawing.Color.White;
            this.GV.Location = new System.Drawing.Point(68, 96);
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(242, 31);
            this.GV.TabIndex = 9;
            this.GV.Text = "Георги Веселинов";
            this.GV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BK);
            this.panel1.Controls.Add(this.MK);
            this.panel1.Controls.Add(this.atom);
            this.panel1.Controls.Add(this.GV);
            this.panel1.Controls.Add(this.developers);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 161);
            this.panel1.TabIndex = 11;
            // 
            // BK
            // 
            this.BK.AutoSize = true;
            this.BK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BK.ForeColor = System.Drawing.Color.White;
            this.BK.Location = new System.Drawing.Point(68, 127);
            this.BK.Name = "BK";
            this.BK.Size = new System.Drawing.Size(220, 31);
            this.BK.TabIndex = 10;
            this.BK.Text = "Боян Копринков";
            this.BK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atom
            // 
            this.atom.BackgroundImage = global::PC9G.Properties.Resources.atom;
            this.atom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.atom.Location = new System.Drawing.Point(3, 3);
            this.atom.Name = "atom";
            this.atom.Size = new System.Drawing.Size(55, 55);
            this.atom.TabIndex = 7;
            this.atom.TabStop = false;
            // 
            // copyright
            // 
            this.copyright.BackgroundImage = global::PC9G.Properties.Resources.ohHeyThatsMe;
            this.copyright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyright.Location = new System.Drawing.Point(574, 100);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(300, 300);
            this.copyright.TabIndex = 12;
            this.copyright.TabStop = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(3, 481);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(51, 16);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "version";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // UC_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingsContainer);
            this.Name = "UC_settings";
            this.Size = new System.Drawing.Size(945, 500);
            this.Load += new System.EventHandler(this.UC_settings_Load);
            this.settingsContainer.ResumeLayout(false);
            this.settingsContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkForUpdates;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Panel settingsContainer;
        private System.Windows.Forms.PictureBox atom;
        private System.Windows.Forms.Label developers;
        private System.Windows.Forms.Label MK;
        private System.Windows.Forms.Label GV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox copyright;
        private System.Windows.Forms.Button changeTheme;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label BK;
    }
}
