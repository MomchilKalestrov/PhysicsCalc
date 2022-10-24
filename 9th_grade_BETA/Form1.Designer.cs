namespace PC9G
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_formulas1 = new PC9G.UC_formulas();
            this.uC_definitions1 = new PC9G.UC_definitions();
            this.uC_settings1 = new PC9G.UC_settings();
            this.formulas = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.definitions = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PC9G.Properties.Resources.test;
            this.pictureBox1.InitialImage = global::PC9G.Properties.Resources.test;
            this.pictureBox1.Location = new System.Drawing.Point(631, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 25);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::PC9G.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.uC_formulas1);
            this.panel1.Controls.Add(this.uC_definitions1);
            this.panel1.Controls.Add(this.uC_settings1);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 530);
            this.panel1.TabIndex = 5;
            // 
            // uC_formulas1
            // 
            this.uC_formulas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.uC_formulas1.Location = new System.Drawing.Point(13, 18);
            this.uC_formulas1.Name = "uC_formulas1";
            this.uC_formulas1.Size = new System.Drawing.Size(945, 500);
            this.uC_formulas1.TabIndex = 1;
            // 
            // uC_definitions1
            // 
            this.uC_definitions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.uC_definitions1.Location = new System.Drawing.Point(13, 18);
            this.uC_definitions1.Name = "uC_definitions1";
            this.uC_definitions1.Size = new System.Drawing.Size(945, 500);
            this.uC_definitions1.TabIndex = 0;
            // 
            // uC_settings1
            // 
            this.uC_settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.uC_settings1.Location = new System.Drawing.Point(13, 18);
            this.uC_settings1.Name = "uC_settings1";
            this.uC_settings1.Size = new System.Drawing.Size(945, 500);
            this.uC_settings1.TabIndex = 2;
            // 
            // formulas
            // 
            this.formulas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.formulas.BackgroundImage = global::PC9G.Properties.Resources.tab;
            this.formulas.FlatAppearance.BorderSize = 0;
            this.formulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formulas.ForeColor = System.Drawing.Color.White;
            this.formulas.Location = new System.Drawing.Point(200, 10);
            this.formulas.Name = "formulas";
            this.formulas.Size = new System.Drawing.Size(85, 25);
            this.formulas.TabIndex = 4;
            this.formulas.Text = "Формули";
            this.formulas.UseVisualStyleBackColor = false;
            this.formulas.Click += new System.EventHandler(this.formulas_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.IndianRed;
            this.close.BackgroundImage = global::PC9G.Properties.Resources.exit;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(940, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize.Location = new System.Drawing.Point(915, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 2;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // definitions
            // 
            this.definitions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.definitions.BackgroundImage = global::PC9G.Properties.Resources.tab;
            this.definitions.FlatAppearance.BorderSize = 0;
            this.definitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.definitions.ForeColor = System.Drawing.Color.White;
            this.definitions.Location = new System.Drawing.Point(110, 10);
            this.definitions.Name = "definitions";
            this.definitions.Size = new System.Drawing.Size(85, 25);
            this.definitions.TabIndex = 1;
            this.definitions.Text = "Определения";
            this.definitions.UseVisualStyleBackColor = false;
            this.definitions.Click += new System.EventHandler(this.definitions_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.settings.BackgroundImage = global::PC9G.Properties.Resources.tab;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Location = new System.Drawing.Point(20, 10);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(85, 25);
            this.settings.TabIndex = 0;
            this.settings.Text = "Настройки";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(970, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formulas);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.definitions);
            this.Controls.Add(this.settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button definitions;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button formulas;
        private System.Windows.Forms.Panel panel1;
        private UC_definitions uC_definitions1;
        private UC_settings uC_settings1;
        private UC_formulas uC_formulas1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}