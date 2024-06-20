using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore
{
    public partial class KonfirmasiBox : Form
    {
        public string CustomMessage { get; set; }
        public KonfirmasiBox()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Program.Box_Konfirmasi = 0;
            this.Close();
        }

        private void Timer_FormWarga_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Timer_FormWarga.Stop();
            }
            else
            {
                Opacity += .03;
            }

            y = Program.koordinasiAwalY_KonfirmasiBox += 5; //INCREMENT
            this.Location = new Point(FromView.Data_Warga.parentX + 720, y);
            if (y >= i)
            {
                Timer_FormWarga.Stop();
            }
        }

        private void btnYakin_Click(object sender, EventArgs e)
        {
            Program.Box_Konfirmasi = 1;
            this.Close();
        }
        int i = 0;
        int y = 0;
        private void KonfirmasiBox_Load(object sender, EventArgs e)
        {
            i = FromView.Data_Warga.parentY + 500;
            this.Location = new Point(FromView.Data_Warga.parentX + 220, FromView.Data_Warga.parentY + 150);
           
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        
    }
        private int startY;

        private void KonfirmasiBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            FromView.Data_Warga.parentY = startY;
        }

        private void KonfirmasiBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.koordinasiAwalY_KonfirmasiBox = 0;
            Program.koordinasiAwalX_KonfirmasiBox = 0;
        }
    }
}
