using System;
using System.Windows.Forms;

namespace ST10043352_PROG7312_PART_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Menu());
        }
    }
}
