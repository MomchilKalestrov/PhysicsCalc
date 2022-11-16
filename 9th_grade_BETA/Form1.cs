using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC9G
{
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            string theme = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\PhysCalcTheme.txt");
            if (theme == "light")
            {
                beta.BackgroundImage = Properties.Resources.testLight;
                close.BackgroundImage = Properties.Resources.exitLight;
                minimize.BackgroundImage = Properties.Resources.minimizeLight;
                panel1.BackgroundImage = Properties.Resources.backgroundLight;
                settings.BackgroundImage = Properties.Resources.tabLight;
                definitions.BackgroundImage = Properties.Resources.tabLight;
                formulas.BackgroundImage = Properties.Resources.tabLight;
                BackColor = Color.FromArgb(255, 245, 237);
            }

            uC_formulas1.Hide();
            formulas.Location = new Point(202, 10);
            uC_definitions1.Hide();
            definitions.Location = new Point(112, 10);
            uC_settings1.Show();
            settings.Location = new Point(22, 15);
        }

        #region Navigation
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            uC_definitions1.Hide();
            definitions.Location = new Point(112, 10);
            uC_formulas1.Hide();
            formulas.Location = new Point(202, 10);
            uC_settings1.Show();
            settings.Location = new Point(22, 15);
        }

        private void definitions_Click(object sender, EventArgs e)
        {
            uC_formulas1.Hide();
            formulas.Location = new Point(202, 10);
            uC_settings1.Hide();
            settings.Location = new Point(22, 10);
            uC_definitions1.Show();
            definitions.Location = new Point(112, 15);
        }

        private void formulas_Click(object sender, EventArgs e)
        {
            uC_definitions1.Hide();
            definitions.Location = new Point(112, 10);
            uC_settings1.Hide();
            settings.Location = new Point(22, 10);
            uC_formulas1.Show();
            formulas.Location = new Point(202, 15);
        }
        #endregion

        private void beta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Това е бета версия. Версията е направена е за проверяване на способностите на програмата. Скоро ще се добавят повече формули и определения");
        }

        private void uC_formulas1_Load(object sender, EventArgs e)
        {

        }
    }
}