using System;
using System.Windows.Forms;

namespace CizioApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Ba�lang�� formu olarak Form1 kullan�l�yor
        }
    }
}
