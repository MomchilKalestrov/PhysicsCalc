using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC9G
{
    public partial class UC_formulas : UserControl
    {
        public UC_formulas()
        {
            InitializeComponent();
        }

        public int formula;

        public double imp1;
        public double imp2;
        public double imp3;
        public double imp4;

        private void UC_formulas_Load(object sender, EventArgs e)
        {
            formula = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            input1.Hide();
            input2.Hide();
            input3.Hide();
            input4.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            formula = 1;
            label1.Text = "Въведи q:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            formula = 2;
            label1.Text = "Въведи U:";
            label2.Text = "Въведи R:";
            label3.Text = "";
            label4.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            formula = 3;
            label1.Text = "Въведи ρ:";
            label2.Text = "Въведи l:";
            label3.Text = "Въведи S:";
            label4.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            formula = 4;
            label1.Text = "Въведи R:";
            label2.Text = "Въведи S:";
            label3.Text = "Въведи l:";
            label4.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            formula = 5;
            label1.Text = "Въведи I:";
            label2.Text = "Въведи R:";
            label3.Text = "";
            label4.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            bool imb1 = double.TryParse(input1.Text, out imp1);
            if (!imb1)
                imp1 = 0;

            bool imb2 = double.TryParse(input2.Text, out imp2);
            if (!imb2)
                imp2 = 0;

            bool imb3 = double.TryParse(input3.Text, out imp3);
            if (!imb3)
                imp3 = 0;

            bool imb4 = double.TryParse(input4.Text, out imp4);
            if (!imb4)
                imp4 = 0;

            switch (formula)
            {
                case 1:
                    {
                        MessageBox.Show($"I = q / t = {imp1 / imp2}");
                    }
                    break;
                case 2:
                    {
                        MessageBox.Show($"I = U / R = {imp1 / imp2}");
                    }
                    break;
                case 3:
                    {
                        MessageBox.Show($"R = ρ * l / S = {imp1 * imp2 / imp3}");
                    }
                    break;
                case 4:
                    {
                        MessageBox.Show($"ρ = R * S / l = {imp1 * imp2 / imp3}");
                    }
                    break;
                case 5:
                    {
                        MessageBox.Show($"U = I * R = {imp1 * imp2}");
                    }
                    break;
                case 6:
                    {

                    }
                    break;
                case 7:
                    {

                    }
                    break;
                case 8:
                    {

                    }
                    break;
                case 9:
                    {

                    }
                    break;
                case 0:
                    {

                    }
                    break;
                case 11:
                    {

                    }
                    break;
                case 12:
                    {

                    }
                    break;
                case 13:
                    {

                    }
                    break;
                case 14:
                    {

                    }
                    break;
                case 15:
                    {

                    }
                    break;
                case 16:
                    {

                    }
                    break;
                case 17:
                    {

                    }
                    break;
                case 18:
                    {

                    }
                    break;
                case 19:
                    {

                    }
                    break;
                case 20:
                    {

                    }
                    break;
                case 21:
                    {

                    }
                    break;
                case 22:
                    {

                    }
                    break;
                case 23:
                    {

                    }
                    break;
                case 24:
                    {

                    }
                    break;
                case 25:
                    {

                    }
                    break;
                case 26:
                    {

                    }
                    break;
                case 27:
                    {

                    }
                    break;
                case 28:
                    {

                    }
                    break;
                case 29:
                    {

                    }
                    break;
                case 30:
                    {

                    }
                    break;
                case 31:
                    {

                    }
                    break;
                case 32:
                    {

                    }
                    break;
                case 33:
                    {

                    }
                    break;
                case 34:
                    {

                    }
                    break;
                case 35:
                    {

                    }
                    break;
                case 36:
                    {

                    }
                    break;
            }
        }
    }
}
