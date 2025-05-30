using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // เรียกฟอร์ม Login
        }
    }
}
