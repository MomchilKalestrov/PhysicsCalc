using System;
using System.IO;
using System.Windows.Forms;

namespace PC9G
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt"))
            {
                using (StreamWriter sw = File.CreateText(@"C:\Users\" + Environment.UserName + @"\Documents\PC9G_Files\PhysCalcTheme.txt"))
                {
                    sw.Write("dark");
                }

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}