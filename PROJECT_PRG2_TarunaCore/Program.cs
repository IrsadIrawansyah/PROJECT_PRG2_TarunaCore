using PROJECT_PRG2_TarunaCore.FormCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore
{
    internal static class Program
    {
        //variabel / atribut global

        //koneksi database
        public static string Login_role, Login_nama, Login_pekerjaan, Login_nama2, Login_id, CheckIsNew;

        public static string User_status { get; internal set; }

        //public static string connectionString = "integrated security = false; data source = .; User ID = sa; Password = POLTEK123; initial catalog = Roomify";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Masuk());
        }
    }
}
