using PROJECT_PRG2_TarunaCore.FormCRUD;
using PROJECT_PRG2_TarunaCore.FromView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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

            panel5.Height = 0;
            transisiWarga.Tick += transisiWarga_Tick;
            btnData.Click += btnData_Click;
        }
        private void DashboardKetua_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        bool menuExpandWarga = false;
        private void transisiWarga_Tick(object sender, EventArgs e)
        {
            if (menuExpandWarga)
            {
                if (panel5.Height > 0)
                {
                    panel5.Height -= 16;

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
                if (panel5.Height <= 160)
                {
                    panel5.Height += 12;

                }
                else
                {
                    transisiWarga.Stop();
                    menuExpandWarga = true;
                }
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            transisiWarga.Start();
        }

        private void btnWarga_Click(object sender, EventArgs e)
        {
            Data_Warga formLihatData = new Data_Warga();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }
        public static int parentX, parentY;

        private void btnRole_Click(object sender, EventArgs e)
        {
            DataRole formLihatData = new DataRole();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
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
    }
}