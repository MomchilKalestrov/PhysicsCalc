using System;
using System.Drawing;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace PC9G
{
    public partial class UC_settings : UserControl
    {
        public static int version = 1003;
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
                theme = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\PhysCalcTheme.txt");
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
                    System.Diagnostics.Process.Start("https://github.com/pAx24/PhysicsCalc/raw/main/PC9_Installer.rar");
                    return;
                }

                update.Text = "Търсене на нова версия...";
                WebClient Client = new WebClient();
                Client.DownloadFile("https://github.com/pAx24/PhysicsCalc/archive/refs/heads/Update.zip", @"C:\Users\" + Environment.UserName + @"\Documents\update_data.zip");
                ZipFile.ExtractToDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\update_data.zip", @"C:\Users\" + Environment.UserName + @"\Documents\");
                int newVersion = int.Parse(File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\PhysicsCalc-Update\dev.txt"));

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
                File.Delete(@"C:\Users\" + Environment.UserName + @"\Documents\update_data.zip");
                File.Delete(@"C:\Users\" + Environment.UserName + @"\Documents\PhysicsCalc-Update\dev.txt");
            }
            catch{ }
        }
        
        private void changeTheme_Click(object sender, EventArgs e)
        {
            if(theme == "dark")
            {
                theme = "light";
            }
            else if (theme == "light")
            {
                theme = "dark";
            }

            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\PhysCalcTheme.txt"))
            {
                File.Delete(@"C:\Users\" + Environment.UserName + @"\Documents\PhysCalcTheme.txt");
            }

            using (StreamWriter sw = File.CreateText(@"C:\Users\" + Environment.UserName + @"\Documents\PhysCalcTheme.txt"))
            {
                sw.Write(theme);
            }

            MessageBox.Show("Приложението трябва да се рестартира, за да влязат в сила промените.");
        }

        private void versionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Версията е:\n{major}.{minor}.{build}.{revision}");
        }
    }
}
