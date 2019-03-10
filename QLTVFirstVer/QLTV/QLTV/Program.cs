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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var DBCS = ConfigurationManager.ConnectionStrings["QuanLyThuVienEntities"];
            //var writable = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            //writable.SetValue(DBCS, false);
            //DBCS.ConnectionString = Data.DAO.ConnectionSQL.ConSTR();
            //DBCS.ProviderName = "System.Data.SqlClient";
            //DBCS.save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.ConnectionStrings["QuanLyThuVienEntities"].ConnectionString = DBCS;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            Application.Run(new frmTheDocGia());
        }
    }
}
