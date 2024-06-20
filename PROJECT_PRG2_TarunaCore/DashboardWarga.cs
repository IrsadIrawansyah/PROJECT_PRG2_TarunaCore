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

namespace PROJECT_PRG2_TarunaCore
{
    public partial class DashboardWarga : Form
    {
        public DashboardWarga()
        {
            InitializeComponent();

            panel5.Height = 0;
            transisiJenisKeluhan.Tick += transisiJenisKeluhan_Tick;
            btnJnsKeluhan.Click += btnJnsKeluhan_Click;

            panel4.Height = 0;
            transisiTransaksi.Tick += transisiTransaksi_Tick;
            btnTransaksi.Click += btnTransaksi_Click;
        }

        private void btnJnsKeluhan_Click(object sender, EventArgs e)
        {
           transisiJenisKeluhan.Start();
        }
        bool menuExpandJenisKeluhan = false;
        private void transisiJenisKeluhan_Tick(object sender, EventArgs e)
        {
            if (menuExpandJenisKeluhan)
            {
                if (panel5.Height > 0)
                {
                    panel5.Height -= 16;
                    //btnRole.Top -= 6;
                }
                else
                {
                    transisiJenisKeluhan.Stop();
                    menuExpandJenisKeluhan = false;
                    panel5.Visible = false;
                }
            }
            else
            {
                panel5.Visible = true;
                if (panel5.Height <= 160)
                {
                    panel5.Height += 12;
                    //btnRole.Top += 6;
                }
                else
                {
                    transisiJenisKeluhan.Stop();
                    menuExpandJenisKeluhan = true;
                }
            }
        }

        private void DashboardWarga_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            transisiTransaksi.Start();
        }
        bool menuExpandTransaksiWarga = false;
        private void transisiTransaksi_Tick(object sender, EventArgs e)
        {
            if (menuExpandTransaksiWarga)
            {
                if (panel4.Height > 0)
                {
                    panel4.Height -= 14; // Adjust the decrement value for a smoother dropdown
                }
                else
                {
                    transisiTransaksi.Stop();
                    menuExpandTransaksiWarga = false;
                    panel4.Visible = false;
                }
            }
            else
            {
                panel4.Visible = true;
                if (panel4.Height < 120)
                {
                    panel4.Height += 12; // Adjust the increment value for a smoother dropdown
                }
                else
                {
                    transisiTransaksi.Stop();
                    menuExpandTransaksiWarga = true;
                }
            }
        }

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

        private void btntmbhjnsklhn_Click(object sender, EventArgs e)
        {
            TambahJenisKeluhan formDataWarga = new TambahJenisKeluhan();
            formDataWarga.StartPosition = FormStartPosition.CenterScreen;
            formDataWarga.Show();
        }

        private void btnaksijnsklhn_Click(object sender, EventArgs e)
        {
            EditJenisKeluhan formDataWarga = new EditJenisKeluhan();
            formDataWarga.StartPosition = FormStartPosition.CenterScreen;
            formDataWarga.Show();
        }
    }
}
