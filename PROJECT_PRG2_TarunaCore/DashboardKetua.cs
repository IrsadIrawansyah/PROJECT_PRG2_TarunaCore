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
using static System.TimeZoneInfo;

namespace PROJECT_PRG2_TarunaCore
{
    public partial class DashboardKetua : Form
    {

        public DashboardKetua()
        {
            InitializeComponent();
            panel7.Height = 0;
            transisitransaksi.Tick += transisitransaksi_Tick;
            btnTransaksi.Click += btnTransaksi_Click;

            panel5.Height = 0;
            transisiWarga.Tick += transisiWarga_Tick;
            btnDataPengguna.Click += btnDataPengguna_Click;

            panel4.Height = 0;
            transisiRole.Tick += transisiRole_Tick;
            btnRole.Click += btnRole_Click;

            guna2Panel2.Height = 0;
            transisiUser.Tick += transisiUser_Tick;
           btnUser.Click += btnUser_Click;
        }

        private void DashboardKetua_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        
        private void btnDataPengguna_Click(object sender, EventArgs e)
        {
            transisiWarga.Start();
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            transisitransaksi.Start();
        }

        bool menuExpand = false;
        private void transisitransaksi_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                if (panel7.Height > 0)
                {
                    panel7.Height -= 16; // Adjust the decrement value for a smoother dropdown
                }
                else
                {
                    transisitransaksi.Stop();
                    menuExpand = false;
                    panel7.Visible = false;
                }
            }
            else
            {
                panel7.Visible = true;
                if (panel7.Height < 120)
                {
                    panel7.Height += 12; // Adjust the increment value for a smoother dropdown
                }
                else
                {
                    transisitransaksi.Stop();
                    menuExpand = true;
                }
            }
    }

        private void btnRole_Click(object sender, EventArgs e)
        {
            transisiRole.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTambahWarga_Click(object sender, EventArgs e)
        {
            TambahWarga formDataUser = new TambahWarga();
            formDataUser.StartPosition = FormStartPosition.CenterScreen;
            formDataUser.Show();
        }

        private void btnPeminjamanPengembalian_Click(object sender, EventArgs e)
        {

        }
        bool menuExpandWarga = false;
        private void transisiWarga_Tick(object sender, EventArgs e)
        {
            if (menuExpandWarga)
            {
                if (panel5.Height > 0)
                {
                    panel5.Height -= 16;
                    //btnRole.Top -= 6;
                }
                else
                {
                    transisiWarga.Stop();
                    menuExpandWarga = false;
                    panel5.Visible = false;
                }
            }
            else
            {
                panel5.Visible = true;
                if (panel5.Height <= 170)
                {
                    panel5.Height += 12;
                    //btnRole.Top += 6;
                }
                else
                {
                    transisiWarga.Stop();
                    menuExpandWarga = true;
                }
            }
        }
        bool menuExpandRole = false;
        private void transisiRole_Tick(object sender, EventArgs e)
        {
            if (menuExpandRole)
            {
                if (panel4.Height > 0)
                {
                    panel4.Height -= 16;
                  // btnTransaksi.Top -= 6;
                }
                else
                {
                    transisiRole.Stop();
                    menuExpandRole = false;
                    panel4.Visible = false;
                }
            }
            else
            {
                panel4.Visible = true;
                if (panel4.Height <= 170)
                {
                    panel4.Height += 12;
                   // btnTransaksi.Top += 24;
                }
                else
                {
                    transisiRole.Stop();
                    menuExpandRole = true;
                }
            }
        
          }

     
        private void btnAksiDataWarga_Click(object sender, EventArgs e)
        {
            EditWarga formDataUser = new EditWarga();
            formDataUser.StartPosition = FormStartPosition.CenterScreen;
            formDataUser.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            transisiUser.Start();
        }
        bool menuExpandUser = false;
        private void transisiUser_Tick(object sender, EventArgs e)
        {
            if (menuExpandUser)
            {
                if (guna2Panel2.Height > 0)
                {
                    guna2Panel2.Height -= 16;
                    // btnTransaksi.Top -= 6;
                }
                else
                {
                    transisiUser.Stop();
                    menuExpandUser = false;
                  guna2Panel2.Visible = false;
                }
            }
            else
            {
               guna2Panel2.Visible = true;
                if (guna2Panel2.Height <= 170)
                {
                   guna2Panel2.Height += 12;
                    // btnTransaksi.Top += 24;
                }
                else
                {
                    transisiUser.Stop();
                    menuExpandUser = true;
                }
            }

        }
    }
}