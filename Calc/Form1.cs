using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcGUI
{
    public partial class Form1 : Form
    {

        public static class Globals
        {
            public static int a = 0;
        }

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи S:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи S:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V:";
            label2.Text = "Въведи V0:";
            label3.Text = "Въведи t:";
            label4.Text = "Въведи t0:";
            Globals.a = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V:";
            label2.Text = "Въведи V0:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи V:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 7;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 8;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи t:";
            label3.Text = "Въведи a:";
            label4.Text = "";
            Globals.a = 9;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи t:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 10;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 11;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 12;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 13;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 14;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 15;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 16;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи V:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 17;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 18;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 19;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            //не ми се оправят радио бутоните, а тоя беше свързан с трети принцип на механиката

            label1.Text = "ERR";
            label2.Text = "ERR";
            label3.Text = "ERR";
            label4.Text = "ERR";
            Globals.a = 20;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Не";
            label2.Text = "Знам";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 21;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи k:";
            label2.Text = "Въведи N:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 22;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи F:";
            label2.Text = "Въведи s:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 23;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи N:";
            label2.Text = "Въведи m:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 24;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи J:";
            label2.Text = "Въведи s:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 25;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи A:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 26;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи v:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 27;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи h:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 28;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи v:";
            label3.Text = "Въведи h:";
            label4.Text = "";
            Globals.a = 29;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи F:";
            label2.Text = "Въведи S:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 30;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи V:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 31;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи S:";
            label2.Text = "Въведи m:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 32;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи S:";
            label2.Text = "Въведи P:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 33;
        }

        //I don't know why, but when I delete the stuff down there
        //ALL, and I mean ALL the code breaks. Also I need these 'cos the other private voids 

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи t:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            int a = 10;
        }

        private void radioButton11_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 11;
        }

        private void radioButton12_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 12;
        }

        private void radioButton13_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 13;
        }

        private void radioButton14_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 14;
        }

        private void radioButton15_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 15;
        }

        private void radioButton16_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 16;
        }

        private void radioButton17_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи V:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 17;
        }

        private void radioButton18_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 18;
        }

        private void radioButton19_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 19;
        }

        private void radioButton20_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "ERR";
            label2.Text = "ERR";
            label3.Text = "ERR";
            label4.Text = "ERR";
            Globals.a = 20;
        }

        private void radioButton21_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 21;
        }

        private void radioButton22_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи k:";
            label2.Text = "Въведи N:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 22;
        }

        private void radioButton23_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи F:";
            label2.Text = "Въведи s:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 23;
        }

        private void radioButton24_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи N:";
            label2.Text = "Въведи m:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 24;
        }

        private void radioButton25_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи J:";
            label2.Text = "Въведи s:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 25;
        }

        private void radioButton26_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи A:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 26;
        }

        private void radioButton27_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи v:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 27;
        }

        private void radioButton28_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи h:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 28;
        }

        private void radioButton29_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи v:";
            label3.Text = "Въведи h:";
            label4.Text = "";
            Globals.a = 29;
        }

        private void radioButton30_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи F:";
            label2.Text = "Въведи S:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 30;
        }

        private void radioButton31_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи m:";
            label2.Text = "Въведи V:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 31;
        }

        private void radioButton33_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи S:";
            label2.Text = "Въведи m:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 32;
        }

        private void radioButton32_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Text = "Въведи S:";
            label2.Text = "Въведи P:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 33;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Globals.a;

            if (a == 1)
            {
                double S = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);
                double Vср = (S / t);
                MessageBox.Show("Средна скорост е равна: " + Math.Round(Vср, 2) + " m/s ");
            }
            else if (a == 2)
            {
                double S = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);

                double V = (S / t);

                MessageBox.Show("Моментна скорост: " + Math.Round(V, 2) + " m/s ");
            }
            else if (a == 3)
            {
                double V = Convert.ToInt32(Input1.Text);
                double V0 = Convert.ToInt32(Input2.Text);
                double t = Convert.ToInt32(Input3.Text);
                double t0 = Convert.ToInt32(Input4.Text);

                double aa = (V - V0) / (t - t0);

                MessageBox.Show("Ускорение: " + Math.Round(aa, 2) + " m/s^2 ");
            }
            else if (a == 4)
            {
                double V = Convert.ToInt32(Input1.Text);
                double V0 = Convert.ToInt32(Input2.Text);
                double t = Convert.ToInt32(Input3.Text);

                double aa = (V - V0) / t;

                MessageBox.Show("Равно ускорително: " + Math.Round(aa, 2) + " m/s^2 ");
            }
            else if (a == 5)
            {
                double V0 = Convert.ToInt32(Input1.Text);
                double aa = Convert.ToInt32(Input2.Text);
                double t = Convert.ToInt32(Input3.Text);

                double V = (V0 + (aa * t));

                MessageBox.Show("Закона за скоростта е равен на при равнозакъснително с V0 е равен на: " + Math.Round(V, 2) + " m/s ");
            }
            else if (a == 6)
            {
                double aa = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);

                double V = (aa * t);

                MessageBox.Show("Закона за скоростта при равнозакъснително без V0 е равен на: " + Math.Round(V, 2) + " m/s ");
            }
            else if (a == 7)
            {
                double V0 = Convert.ToInt32(Input1.Text);
                double V = Convert.ToInt32(Input2.Text);
                double t = Convert.ToInt32(Input3.Text);

                double Vср = (V0 + V / 2);

                MessageBox.Show("Средната скорост при равноускорително двиение с V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
            }
            else if (a == 8)
            {
                double aa = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);

                double Vср = (aa * t / 2);

                MessageBox.Show("Средната скорост при равноускорително двиение без V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
            }
            else if (a == 9)
            {
                double V0 = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);
                double aa = Convert.ToInt32(Input3.Text);

                double S = (V0 * t + (aa * t * t) / 2);

                MessageBox.Show("Закона за пътя при равноускорително е равен на: " + Math.Round(S, 2) + " m ");
            }
            else if (a == 10)
            {
                double t = Convert.ToInt32(Input1.Text);
                double aa = Convert.ToInt32(Input2.Text);

                double S = (t + (aa * t * t) / 2);

                MessageBox.Show("Закона за пътя при равноускорително без V0 e равен на: " + Math.Round(S, 2) + " m ");
            }
            else if (a == 11)
            {
                double V0 = Convert.ToInt32(Input1.Text);
                double aa = Convert.ToInt32(Input2.Text);
                double t = Convert.ToInt32(Input3.Text);

                double V = (V0 - aa * t);

                MessageBox.Show("Закон за скоростта при равнозакъснително движение с V0 е равен на: " + Math.Round(V, 2) + " m ");
            }
            else if (a == 12)
            {
                double aa = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);

                double V = (aa * t);

                MessageBox.Show("Закон за скоростта при равнозакъснително движение без V0 е равен на: " + Math.Round(V, 2) + " m ");
            }
            else if (a == 13)
            {
                double V0 = Convert.ToInt32(Input1.Text);
                double aa = Convert.ToInt32(Input2.Text);
                double t = Convert.ToInt32(Input3.Text);

                double Vср = (V0 - (aa * t / 2));

                MessageBox.Show("Средна скорост при равнозакъснително с V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
            }
            else if (a == 14)
            {
                double aa = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);

                double Vср = (aa * t / 2);

                MessageBox.Show("Средна скорост при равнозакъснително с V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
            }
            else if (a == 15)
            {
                double V0 = Convert.ToInt32(Input1.Text);
                double aa = Convert.ToInt32(Input2.Text);
                double t = Convert.ToInt32(Input3.Text);

                double S = (V0 * t - (aa * t * t / 2));

                MessageBox.Show("Закон за пътя при равнозакъснително с V0 е равно на: " + Math.Round(S, 2) + " m ");

            }
            else if (a == 16)
            {
                double aa = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);

                double S = (t - (aa * t * t / 2));

                MessageBox.Show("Закон за пътя при равнозакъснително без V0 е равно на: " + Math.Round(S, 2) + " m ");
            }
            else if (a == 17)
            {
                double V0 = Convert.ToInt32(Input1.Text);
                double aa = Convert.ToInt32(Input2.Text);

                double tсп = (V0 / aa);

                MessageBox.Show("Спирачният път е равен на: " + Math.Round(tсп, 2) + " m");
            }
            else if (a == 18)
            {
                double m = Convert.ToInt32(Input1.Text);

                double G = (m * 10);

                MessageBox.Show("Свободното падане е равно на: " + Math.Round(G, 2) + " N ");

            }
            else if (a == 19)
            {
                double m = Convert.ToInt32(Input1.Text);
                double aa = Convert.ToInt32(Input2.Text);

                double F = (m * aa);

                MessageBox.Show("Втори принцип на механиката е равен на: " + Math.Round(F, 2) + " N ");
            }
            else if (a == 20)
            {

            }
            else if (a == 21)
            {
                double m = Convert.ToInt32(Input1.Text);

                double G = (m * 10);

                MessageBox.Show("Силата е равна: " + Math.Round(G, 2) + " N ");
            }
            else if (a == 22)
            {
                double k = Convert.ToInt32(Input1.Text);
                double N = Convert.ToInt32(Input2.Text);

                double f = (k * N);

                MessageBox.Show("Tриенето е равно на: " + Math.Round(f, 2) + "");
            }
            else if (a == 23)
            {
                double F = Convert.ToInt32(Input1.Text);
                double s = Convert.ToInt32(Input2.Text);

                double A = (F * s);

                MessageBox.Show("Механичната работа е равна на: " + Math.Round(A, 2) + " J ");
            }
            else if (a == 24)
            {
                double N = Convert.ToInt32(Input1.Text);
                double m = Convert.ToInt32(Input2.Text);

                double J = (N * m);

                MessageBox.Show("Джаулът е равен: " + Math.Round(J, 2) + " J ");
            }
            else if (a == 25)
            {
                double A = Convert.ToInt32(Input1.Text);
                double t = Convert.ToInt32(Input2.Text);

                double P = (A / t);

                Console.WriteLine("Мощността е равна на: " + Math.Round(P, 2) + " W ");
            }
            else if (a == 26)
            {
                double m = Convert.ToInt32(Input1.Text);
                double v = Convert.ToInt32(Input2.Text);

                double Ek = (m + v * v) / 2;

                MessageBox.Show("Кинетичната енргия е равна на: " + Math.Round(Ek, 2) + "J ");
            }
            else if (a == 27)
            {
                double m1 = Convert.ToInt32(Input1.Text);
                double h = Convert.ToInt32(Input2.Text);

                double Ep = (m1 * 10 * h);

                MessageBox.Show("Масата е равна на " + Math.Round(Ep, 2) + " J ");

            }
            else if (a == 28)
            {
                double m1 = Convert.ToInt32(Input1.Text);
                double h = Convert.ToInt32(Input2.Text);

                double Ep = (m1 * 10 * h);

                MessageBox.Show("Масата е равна на " + Math.Round(Ep, 2) + " J ");
            }
            else if (a == 29)
            {
                double m = Convert.ToInt32(Input1.Text);
                double v = Convert.ToInt32(Input2.Text);
                double h = Convert.ToInt32(Input3.Text);

                double E = (m + v * v) / 2 + (m * 10 * h);

                MessageBox.Show("Масата е равна на: " + Math.Round(E, 2) + " J ");

            }
            else if (a == 30)
            {
                double F = Convert.ToInt32(Input1.Text);
                double S = Convert.ToInt32(Input2.Text);

                double p = (F / S);

                MessageBox.Show("Налягането е равно на: " + Math.Round(p, 2) + " Pa ");
            }
            else if (a == 31)
            {
                double m = Convert.ToInt32(Input1.Text);
                double V = Convert.ToInt32(Input2.Text);

                double Ро = (m / V);

                MessageBox.Show("Плътността (Ро) е равно на: " + Math.Round(Ро, 2) + " kg/cm^3 ");

            }
            else if (a == 32)
            {
                double S = Convert.ToInt32(Input1.Text);
                double m = Convert.ToInt32(Input2.Text);

                double V = (S * m);

                MessageBox.Show($"Обемът е равен на: " + Math.Round(V, 2) + " m^3 ");

            }
            else if (a == 33)
            {
                double S = Convert.ToInt32(Input1.Text);
                double P = Convert.ToInt32(Input2.Text);

                double p = (P / S);

                MessageBox.Show($"Хидростатично налягане е равно на: " + Math.Round(p, 2) + " Pa ");
            }
            else if (a == 34)
            {
                double Uk = Convert.ToInt32(Input1.Text);
                double Up = Convert.ToInt32(Input2.Text);

                double U = (Uk + Up);

                MessageBox.Show($"Вътрешната енергия е равна на: " + Math.Round(U, 2) + " J ");
            }
            else if (a == 35)
            {

            }
            else
            {
                MessageBox.Show("Error 204: \n No input.");
            }
        }

        private void groupBox2_Enter_2(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged_2(object sender, EventArgs e)
        {
            label1.Text = "Въведи Uk:";
            label2.Text = "Въведи Up:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 34;
        }
    }
}
