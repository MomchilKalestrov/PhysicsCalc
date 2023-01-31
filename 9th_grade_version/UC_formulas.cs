using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PC9G
{
    public partial class UC_formulas : UserControl
    {
        public UC_formulas()
        {
            InitializeComponent();
        }

        public Byte formula; //The data stored here doesn't go over 30, so theres not much of a point to reserve 32 bits.

        public double imp1;
        public double imp2;
        public double imp3;
        public double imp4;

        private void UC_formulas_Load(object sender, EventArgs e)
        {
            string theme = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt");
            if (theme == "light")
            {
                pictureBox1.BackgroundImage = Properties.Resources.sideLight;
                pictureBox2.BackgroundImage = Properties.Resources.middleLight;
                pictureBox3.BackgroundImage = Properties.Resources.sideLight;
                calculate.BackgroundImage = Properties.Resources.calcButtonLight;
                BackColor = Color.FromArgb(217, 205, 199);
                label1.BackColor = Color.FromArgb(176, 164, 157);
                label2.BackColor = Color.FromArgb(176, 164, 157);
                label3.BackColor = Color.FromArgb(176, 164, 157);
                label4.BackColor = Color.FromArgb(176, 164, 157);
            }

            formula = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            input1.Hide();
            input2.Hide();
            input3.Hide();
            input4.Hide();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            formula = 1;
            label1.Text = "Въведи q:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            formula = 2;
            label1.Text = "Въведи U:";
            label2.Text = "Въведи R:";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            formula = 3;
            label1.Text = "Въведи ρ:";
            label2.Text = "Въведи l:";
            label3.Text = "Въведи S:";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            formula = 4;
            label1.Text = "Въведи R:";
            label2.Text = "Въведи S:";
            label3.Text = "Въведи l:";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            formula = 5;
            label1.Text = "Въведи I:";
            label2.Text = "Въведи R:";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            formula = 6;
            label1.Text = "Въведи R1:";
            label2.Text = "Въведи R2:";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            formula = 7;
            label1.Text = "Въведи R1:";
            label2.Text = "Въведи R2:";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            formula = 8;
            label1.Text = "Въведи U:";
            label2.Text = "Въведи I:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            formula = 9;
            label1.Text = "Въведи U:";
            label2.Text = "Въведи I:";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            formula = 10;
            label1.Text = "Въведи А     :";
            label2.Text = "Въведи q:";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "стр";

            input1.Show();
            input2.Show();
            input3.Hide();
            input4.Hide();
        }
        private void rb11_CheckedChanged(object sender, EventArgs e)
        {
            formula = 11;
            label1.Text = "Въведи ε:";
            label2.Text = "Въведи R:";
            label3.Text = "Въведи r:";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
        }

        private void rb12_CheckedChanged(object sender, EventArgs e)
        {
            formula = 12;
            label1.Text = "Въведи ε:";
            label2.Text = "Въведи I:";
            label3.Text = "Въведи r:";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
        }

        private void rb13_CheckedChanged(object sender, EventArgs e)
        {
            formula = 13;
            label1.Text = "Въведи I:";
            label2.Text = "Въведи R:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            label5.Text = "";

            input1.Show();
            input2.Show();
            input3.Show();
            input4.Hide();
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
                        MessageBox.Show($"R = R1 + R2 = {imp1 + imp2}");
                    }
                    break;
                case 7:
                    {
                        MessageBox.Show($"R = 1/R1 + 1/R2 = {1 / imp1 + 1 / imp2}");
                    }
                    break;
                case 8:
                    {
                        MessageBox.Show($"A = U * I * t = {imp1 * imp2 * imp3}");
                    }
                    break;
                case 9:
                    {
                        MessageBox.Show($"P = U * I = {imp1 * imp2}");
                    }
                    break;
                case 10:
                    {
                        MessageBox.Show($"ε = Aстр / q = {imp1 / imp2}");
                    }
                    break;
                case 11:
                    {
                        MessageBox.Show($"I = ε / (R + r) = {imp1 / (imp2 + imp3)}");
                    }
                    break;
                case 12:
                    {
                        MessageBox.Show($"U = ε - I * r = {imp1 - imp2 * imp3}");
                    }
                    break;
                case 13:
                    {
                        MessageBox.Show($"Q = I^2 * R * t = {Math.Pow(imp1, 2) * imp2 * imp3}");
                    }
                    break;
            }
        }
    }
}
