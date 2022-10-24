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
            this.updateContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkForUpdates
            // 
            this.checkForUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(158)))));
            this.checkForUpdates.FlatAppearance.BorderSize = 0;
            this.checkForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkForUpdates.ForeColor = System.Drawing.Color.White;
            this.checkForUpdates.Location = new System.Drawing.Point(3, 3);
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
            this.update.Location = new System.Drawing.Point(3, 31);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(44, 16);
            this.update.TabIndex = 5;
            this.update.Text = "label1";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateContainer
            // 
            this.updateContainer.Controls.Add(this.update);
            this.updateContainer.Controls.Add(this.checkForUpdates);
            this.updateContainer.Location = new System.Drawing.Point(89, 307);
            this.updateContainer.Name = "updateContainer";
            this.updateContainer.Size = new System.Drawing.Size(171, 50);
            this.updateContainer.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PC9G.Properties.Resources.atom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Създадено от:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Момчил Калестров";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Георги Веселинов";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Боян Копринков";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 166);
            this.panel1.TabIndex = 11;
            // 
            // UC_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateContainer);
            this.Name = "UC_settings";
            this.Size = new System.Drawing.Size(945, 500);
            this.Load += new System.EventHandler(this.UC_settings_Load);
            this.updateContainer.ResumeLayout(false);
            this.updateContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkForUpdates;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Panel updateContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}
