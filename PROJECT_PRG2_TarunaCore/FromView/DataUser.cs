using PROJECT_PRG2_TarunaCore.FormCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore.FromView
{
    public partial class DataUser : Form
    {
        public DataUser()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public static int parentX, parentY;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda Yakin Ingin Keluar?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // Log out if the user confirms
            if (result == DialogResult.OK)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void btnWarga_Click(object sender, EventArgs e)
        {
            Data_Warga formLihatData = new Data_Warga();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            DataRole formLihatData = new DataRole();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }

        private void DataUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tarunaCore.MasterUser' table. You can move, or remove it, as needed.
            this.masterUserTableAdapter.Fill(this.tarunaCore.MasterUser);

        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            TambahUser Tambahuser = new TambahUser();

            // Menampilkan formEditWarga sebagai dialog
            Tambahuser.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
           
        }
    }
}
