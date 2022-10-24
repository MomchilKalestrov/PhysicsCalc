using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using PC9G;

namespace PC9G
{
    public partial class UC_settings : UserControl
    {
        public static int version = 1000;
        public bool goToSite = false;
        public UC_settings()
        {
            InitializeComponent();
        }

        private void UC_settings_Load(object sender, EventArgs e)
        {
            update.Text = "";
        }

        private void checkForUpdates_Click(object sender, EventArgs e)
        {
            if (goToSite)
            {
                System.Diagnostics.Process.Start("https://momchil-k.github.io/PhysicsCalc/");
                return;
            }

            update.Text = "Търсене на нова версия...";
            WebClient Client = new WebClient();
            Client.DownloadFile("https://github.com/Momchil-k/PhysicsCalc/archive/refs/heads/Update.zip", "C:/update_data.zip");
            ZipFile.ExtractToDirectory("C:/update_data.zip", "C:/");
            int newVersion = int.Parse(File.ReadAllText("C:/PhysicsCalc-Update/dev.txt"));

            if (newVersion <= version)
               update.Text = "Няма нова версия.";
            else
            {
                update.Text = "Намерена нова версия.";
                goToSite = true;
                checkForUpdates.Text = "Към сайта";
            }

            File.Delete("C:/update_data.zip");
            File.Delete("C:/PhysicsCalc-Update/dev.txt");
        }
    }
}
