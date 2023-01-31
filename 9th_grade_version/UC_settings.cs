using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace PC9G
{
    public partial class UC_settings : UserControl
    {
        public static int version = 1005;
        public static int major = version / 1000;
        public static int minor = (version - version / 1000 * 1000) / 100;
        public static int build = (version - version / 100 * 100) / 10;
        public static int revision = version - version / 10 * 10;
        public bool goToSite = false;
        public string theme = "dark";
        public UC_settings()
        {
            InitializeComponent();
        }

        private void UC_settings_Load(object sender, EventArgs e)
        {
            theme = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt");
            if (theme == "light")
            {
                atom.BackgroundImage = Properties.Resources.atomLight;
                BackColor = Color.FromArgb(217, 205, 199);
            }

            update.Text = "";
            versionLabel.Text = $"{major}.{minor}.{build}.{revision}";
        }

        private void checkForUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                if (goToSite)
                {
                    System.Diagnostics.Process.Start("https://raw.githubusercontent.com/pAx24/PhysicsCalc/Update/Installer.exe");
                    return;
                }

                update.Text = "Търсене на нова версия...";
                WebClient Client = new WebClient();
                Client.DownloadFile("https://raw.githubusercontent.com/pAx24/PhysicsCalc/Update/dev.txt", @"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\dev.txt");
                int newVersion = int.Parse(File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\dev.txt"));

                if (newVersion <= version)
                    update.Text = "Няма нова версия.";
                else
                {
                    update.Text = "Намерена нова версия.";
                    goToSite = true;
                    checkForUpdates.Text = "Натиснете за нова версия";
                }
            }
            catch
            {
                update.Text = "";
                MessageBox.Show("Сървърът с данните не може да бъде контактуван. Моля проверете дали сте свързани към интернет. Ако сте, посетете сайта за да видите дали сте с най-новата версия.");
            }

            try
            {
                File.Delete(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\dev.txt");
            }
            catch { }
        }

        private void changeTheme_Click(object sender, EventArgs e)
        {
            if (theme == "dark")
            {
                theme = "light";
            }
            else if (theme == "light")
            {
                theme = "dark";
            }

            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt"))
            {
                File.Delete(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt");
            }

            using (StreamWriter sw = File.CreateText(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt"))
            {
                sw.Write(theme);
            }

            Application.Restart();
        }

        private void versionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Версията е:\n{major}.{minor}.{build}.{revision}");
        }
    }
}
