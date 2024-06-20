using Guna.UI2.WinForms;
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
    public partial class DashboardBendahara : Form
    {
        public DashboardBendahara()
        {
            InitializeComponent();

            panel5.Height = 0;
            transisiTrsBarang.Tick +=transisiTrsBarang_Tick;
            btnTransaksiBarang.Click += btnTransaksiBarang_Click;
        }

        private void DashboardBendahara_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void btnTransaksiBarang_Click(object sender, EventArgs e)
        {
            transisiTrsBarang.Start();
        }

        bool menuExpandTrsBarang = false;
        private void transisiTrsBarang_Tick(object sender, EventArgs e)
        {
            if (menuExpandTrsBarang)
            {
                if (panel5.Height > 0)
                {
                    panel5.Height -= 14; // Adjust the decrement value for a smoother dropdown
                }
                else
                {
                    transisiTrsBarang.Stop();
                    menuExpandTrsBarang = false;
                    panel5.Visible = false;
                }
            }
            else
            {
                panel5.Visible = true;
                if (panel5.Height < 120)
                {
                    panel5.Height += 12; // Adjust the increment value for a smoother dropdown
                }
                else
                {
                    transisiTrsBarang.Stop();
                    menuExpandTrsBarang = true;
                }
            }
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            TambahBarang formDataUser = new TambahBarang();
            formDataUser.StartPosition = FormStartPosition.CenterScreen;
            formDataUser.Show();
        }
    }
}
    


