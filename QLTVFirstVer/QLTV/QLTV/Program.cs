using System;
using System.Windows.Forms;
using Desktop.GUI;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Configuration;
using System.Reflection;
using System.Data.SqlClient;
namespace Desktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            Application.Run(new frmMain());
        }
    }
}
