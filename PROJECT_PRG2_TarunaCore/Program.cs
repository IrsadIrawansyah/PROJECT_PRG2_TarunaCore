using PROJECT_PRG2_TarunaCore.FormCRUD;
using PROJECT_PRG2_TarunaCore.FromView;
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
        // public static string connectionString = "integrated security=true;data source=IRAWANSYAH;initial catalog=TarunaCore";
        public static string Login_role;
        public static string connectionString = "integrated security = false; data source =IRAWANSYAH; User ID = sa; Password = POLTEK123; initial catalog = TarunaCore;";
        public static int koordinasiAwalY_KonfirmasiBox, koordinasiAwalX_KonfirmasiBox, koordinasiAwalY, koordinasiAwalX;
        public static int Box_Konfirmasi;

        //variabel global WARGA
        public static string ID_NIK, Nama_Warga, Alamat, Nmr_Telepon, Status, Tgl_Lahir;

        public static string formatID;

        //variabel foto
        public static byte[] photo;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Data_Warga());
        }
    }
}
