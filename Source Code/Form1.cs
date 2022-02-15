using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace materialUI
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static int a = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи S:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи S:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();
            label1.Text = "Въведи V:";
            label2.Text = "Въведи V0:";
            label3.Text = "Въведи t:";
            label4.Text = "Въведи t0:";
            Globals.a = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи V:";
            label2.Text = "Въведи V0:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи V:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 7;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 8;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи t:";
            label3.Text = "Въведи a:";
            label4.Text = "";
            Globals.a = 9;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи t:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 10;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 11;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 12;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 13;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи a:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 14;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи a:";
            label3.Text = "Въведи t:";
            label4.Text = "";
            Globals.a = 15;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи V0:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 16;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи V:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 17;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input2.Hide();
            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи m:";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 18;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи m:";
            label2.Text = "Въведи a:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 19;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи Uk";
            label2.Text = "Въведи Uп";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 20;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Не";
            label2.Text = "Знам";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 21;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи k:";
            label2.Text = "Въведи N:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 22;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи F:";
            label2.Text = "Въведи s:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 23;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи N:";
            label2.Text = "Въведи m:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 24;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи J:";
            label2.Text = "Въведи s:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 25;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи A:";
            label2.Text = "Въведи t:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 26;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи m:";
            label2.Text = "Въведи v:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 27;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи m:";
            label2.Text = "Въведи h:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 28;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input4.Hide();
            label1.Text = "Въведи m:";
            label2.Text = "Въведи v:";
            label3.Text = "Въведи h:";
            label4.Text = "";
            Globals.a = 29;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи F:";
            label2.Text = "Въведи S:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 30;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи m:";
            label2.Text = "Въведи V:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 31;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи S:";
            label2.Text = "Въведи m:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 32;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи S:";
            label2.Text = "Въведи P:";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 33;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Show();
            Input2.Show();
            Input3.Show();
            Input4.Show();

            Input2.Hide();
            Input3.Hide();
            Input4.Hide();
            label1.Text = "Въведи t:";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            Globals.a = 35;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Credits.Show();
            Credits.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formuli1.Hide();
            Credits.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formuli1.Show();
            formuli1.BringToFront();
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            int a = Globals.a;

            switch (a)
            {
                case 1:
                    {
                        double S = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double Vср = (S / t);
                        MessageBox.Show("Средна скорост е равна: " + Math.Round(Vср, 2) + " m/s ");
                    }
                    break;
                case 2:
                    {
                        double S = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double V = (S / t);
                        MessageBox.Show("Моментна скорост: " + Math.Round(V, 2) + " m/s ");
                    }
                    break;
                case 3:
                    {
                        double V = Convert.ToInt32(Input1.Text);
                        double V0 = Convert.ToInt32(Input2.Text);
                        double t = Convert.ToInt32(Input3.Text);
                        double t0 = Convert.ToInt32(Input4.Text);
                        double aa = (V - V0) / (t - t0);
                        MessageBox.Show("Ускорение: " + Math.Round(aa, 2) + " m/s^2 ");
                    }
                    break;
                case 4:
                    {
                        double V = Convert.ToInt32(Input1.Text);
                        double V0 = Convert.ToInt32(Input2.Text);
                        double t = Convert.ToInt32(Input3.Text);
                        double aa = (V - V0) / t;
                        MessageBox.Show("Равно ускорително: " + Math.Round(aa, 2) + " m/s^2 ");
                    }
                    break;
                case 5:
                    {
                        double V0 = Convert.ToInt32(Input1.Text);
                        double aa = Convert.ToInt32(Input2.Text);
                        double t = Convert.ToInt32(Input3.Text);
                        double V = (V0 + (aa * t));
                        MessageBox.Show("Закона за скоростта е равен на при равнозакъснително с V0 е равен на: " + Math.Round(V, 2) + " m/s ");
                    }
                    break;
                case 6:
                    {
                        double aa = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double V = (aa * t);
                        MessageBox.Show("Закона за скоростта при равнозакъснително без V0 е равен на: " + Math.Round(V, 2) + " m/s ");
                    }
                    break;
                case 7:
                    {
                        double V0 = Convert.ToInt32(Input1.Text);
                        double V = Convert.ToInt32(Input2.Text);
                        double t = Convert.ToInt32(Input3.Text);
                        double Vср = (V0 + V / 2);
                        MessageBox.Show("Средната скорост при равноускорително двиение с V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
                    }
                    break;
                case 8:
                    {
                        double aa = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double Vср = (aa * t / 2);
                        MessageBox.Show("Средната скорост при равноускорително двиение без V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
                    }
                    break;
                case 9:
                    {
                        double V0 = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double aa = Convert.ToInt32(Input3.Text);
                        double S = (V0 * t + (aa * t * t) / 2);
                        MessageBox.Show("Закона за пътя при равноускорително е равен на: " + Math.Round(S, 2) + " m ");
                    }
                    break;
                case 10:
                    {
                        double t = Convert.ToInt32(Input1.Text);
                        double aa = Convert.ToInt32(Input2.Text);
                        double S = (t + (aa * t * t) / 2);
                        MessageBox.Show("Закона за пътя при равноускорително без V0 e равен на: " + Math.Round(S, 2) + " m ");
                    }
                    break;
                case 11:
                    {
                        double V0 = Convert.ToInt32(Input1.Text);
                        double aa = Convert.ToInt32(Input2.Text);
                        double t = Convert.ToInt32(Input3.Text);
                        double V = (V0 - aa * t);
                        MessageBox.Show("Закон за скоростта при равнозакъснително движение с V0 е равен на: " + Math.Round(V, 2) + " m ");
                    }
                    break;
                case 12:
                    {
                        double aa = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double V = (aa * t);
                        MessageBox.Show("Закон за скоростта при равнозакъснително движение без V0 е равен на: " + Math.Round(V, 2) + " m ");
                    }
                    break;
                case 13:
                    {
                        double V0 = Convert.ToInt32(Input1.Text);
                        double aa = Convert.ToInt32(Input2.Text);
                        double t = Convert.ToInt32(Input3.Text);
                        double Vср = (V0 - (aa * t / 2));
                        MessageBox.Show("Средна скорост при равнозакъснително с V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
                    }
                    break;
                case 14:
                    {
                        double aa = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double Vср = (aa * t / 2);
                        MessageBox.Show("Средна скорост при равнозакъснително с V0 е равна на: " + Math.Round(Vср, 2) + " m/s ");
                    }
                    break;
                case 15:
                    {
                        double V0 = Convert.ToInt32(Input1.Text);
                        double aa = Convert.ToInt32(Input2.Text);
                        double t = Convert.ToInt32(Input3.Text);
                        double S = (V0 * t - (aa * t * t / 2));
                        MessageBox.Show("Закон за пътя при равнозакъснително с V0 е равно на: " + Math.Round(S, 2) + " m ");

                    }
                    break;
                case 16:
                    {
                        double aa = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double S = (t - (aa * t * t / 2));
                        MessageBox.Show("Закон за пътя при равнозакъснително без V0 е равно на: " + Math.Round(S, 2) + " m ");
                    }
                    break;
                case 17:
                    {
                        double V0 = Convert.ToInt32(Input1.Text);
                        double aa = Convert.ToInt32(Input2.Text);
                        double tсп = (V0 / aa);
                        MessageBox.Show("Спирачният път е равен на: " + Math.Round(tсп, 2) + " m");
                    }
                    break;
                case 18:
                    {
                        double m = Convert.ToInt32(Input1.Text);
                        double G = (m * 10);
                        MessageBox.Show("Свободното падане е равно на: " + Math.Round(G, 2) + " N ");
                    }
                    break;
                case 19:
                    {
                        double m = Convert.ToInt32(Input1.Text);
                        double aa = Convert.ToInt32(Input2.Text);
                        double F = (m * aa);
                        MessageBox.Show("Втори принцип на механиката е равен на: " + Math.Round(F, 2) + " N ");
                    }
                    break;
                case 20:
                    {
                        double nahui = Convert.ToInt32(Input1.Text);
                        double pizdec = Convert.ToInt32(Input2.Text);
                        double durak = (nahui * pizdec);
                        MessageBox.Show("Втори принцип на механиката е равен на: " + Math.Round(durak, 2) + " J ");
                    }
                    break;
                case 21:
                    {
                        double m = Convert.ToInt32(Input1.Text);
                        double G = (m * 10);
                        MessageBox.Show("Силата е равна: " + Math.Round(G, 2) + " N ");
                    } break;
                case 22:
                    {
                        double k = Convert.ToInt32(Input1.Text);
                        double N = Convert.ToInt32(Input2.Text);
                        double f = (k * N);
                        MessageBox.Show("Tриенето е равно на: " + Math.Round(f, 2) + "");
                    } break;
                case 23:
                    {
                        double F = Convert.ToInt32(Input1.Text);
                        double s = Convert.ToInt32(Input2.Text);
                        double A = (F * s);
                        MessageBox.Show("Механичната работа е равна на: " + Math.Round(A, 2) + " J ");
                    } break;
                case 24:
                    {
                        double N = Convert.ToInt32(Input1.Text);
                        double m = Convert.ToInt32(Input2.Text);
                        double J = (N * m);
                        MessageBox.Show("Джаулът е равен: " + Math.Round(J, 2) + " J ");
                    } break;
                case 25:
                    {
                        double A = Convert.ToInt32(Input1.Text);
                        double t = Convert.ToInt32(Input2.Text);
                        double P = (A / t);
                        MessageBox.Show("Мощността е равна на: " + Math.Round(P, 2) + " W ");
                    } break;
                case 26:
                    {
                        double m = Convert.ToInt32(Input1.Text);
                        double v = Convert.ToInt32(Input2.Text);
                        double Ek = (m + v * v) / 2;
                        MessageBox.Show("Кинетичната енргия е равна на: " + Math.Round(Ek, 2) + "J ");
                    } break;
                case 27:
                    {
                        double m1 = Convert.ToInt32(Input1.Text);
                        double h = Convert.ToInt32(Input2.Text);
                        double Ep = (m1 * 10 * h);
                        MessageBox.Show("Масата е равна на " + Math.Round(Ep, 2) + " J ");

                    } break;
                case 28:
                    {
                        double m1 = Convert.ToInt32(Input1.Text);
                        double h = Convert.ToInt32(Input2.Text);
                        double Ep = (m1 * 10 * h);
                        MessageBox.Show("Масата е равна на " + Math.Round(Ep, 2) + " J ");
                    } break;
                case 29:
                    {
                        double m = Convert.ToInt32(Input1.Text);
                        double v = Convert.ToInt32(Input2.Text);
                        double h = Convert.ToInt32(Input3.Text);
                        double E = (m + v * v) / 2 + (m * 10 * h);
                        MessageBox.Show("Масата е равна на: " + Math.Round(E, 2) + " J ");
                    } break;
                case 30:
                    {
                        double F = Convert.ToInt32(Input1.Text);
                        double S = Convert.ToInt32(Input2.Text);
                        double p = (F / S);
                        MessageBox.Show("Налягането е равно на: " + Math.Round(p, 2) + " Pa ");
                    } break;
                case 31:
                    {
                        double m = Convert.ToInt32(Input1.Text);
                        double V = Convert.ToInt32(Input2.Text);
                        double Ро = (m / V);
                        MessageBox.Show("Плътността (Ро) е равно на: " + Math.Round(Ро, 2) + " kg/cm^3 ");
                    }
                    break;
                case 32:
                    {
                        double S = Convert.ToInt32(Input1.Text);
                        double m = Convert.ToInt32(Input2.Text);
                        double V = (S * m);
                        MessageBox.Show($"Обемът е равен на: " + Math.Round(V, 2) + " m^3 ");

                    }
                    break;
                case 33:
                    {
                        double S = Convert.ToInt32(Input1.Text);
                        double P = Convert.ToInt32(Input2.Text);
                        double p = (P / S);
                        MessageBox.Show($"Хидростатично налягане е равно на: " + Math.Round(p, 2) + " Pa ");
                    }
                    break;
                case 34:
                    {
                        double Uk = Convert.ToInt32(Input1.Text);
                        double Up = Convert.ToInt32(Input2.Text);
                        double U = (Uk + Up);
                        MessageBox.Show($"Вътрешната енергия е равна на: " + Math.Round(U, 2) + " J ");
                    }
                    break;
                case 35:
                    {
                        double t = Convert.ToInt32(Input1.Text);
                        double tt = (t + 273.15);
                        MessageBox.Show("Температурата е равна на: " + Math.Round(tt, 2) + " K ");
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Error 204: \n No input.");
                    }
                    break;
            }
        }
        private void Base_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void textBox3_TextChanged(object sender, EventArgs e){}
        private void textBox4_TextChanged(object sender, EventArgs e){}
        private void formuli1_Load(object sender, EventArgs e){}
        private void pictureBox1_Click(object sender, EventArgs e){System.Diagnostics.Process.Start("https://material.io/");}
        private void Credits_Click(object sender, EventArgs e){System.Diagnostics.Process.Start("https://momchil-k.github.io/PhysicsCalc");}
    }
}
