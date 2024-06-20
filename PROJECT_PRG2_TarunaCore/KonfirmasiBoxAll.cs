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
    public partial class KonfirmasiBoxAll : Form
    {

        public KonfirmasiBoxAll(string _message)
        {
            InitializeComponent();
            messege.Text = _message;
        }
        public static void Show(string _message)
        {
            new PROJECT_PRG2_TarunaCore.KonfirmasiBoxAll(_message).Show();
        }
        private int startY;
        private void btnBatal_Click(object sender, EventArgs e)
        {
            Program.Box_Konfirmasi = 0;
            this.Close();
        }

        int i = 0;
        int y = 0;
        private void btnYakin_Click(object sender, EventArgs e)
        {
            Program.Box_Konfirmasi = 1;
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
                Opacity += .04;
            }

            y = Program.koordinasiAwalY_KonfirmasiBox += 15; //INCREMENT
            this.Location = new Point(FromView.Data_Warga.parentX + 670, y);
            if (y >= i)
            {
                Timer_FormWarga.Stop();
            }
        }

        private void KonfirmasiBoxAll_Load(object sender, EventArgs e)
        {

            i = Program.koordinasiAwalY + 540;
            this.Location = new Point(Program.koordinasiAwalX + 840, Program.koordinasiAwalY + 400);
            /*  i = Program.koordinasiAwalY + 400;
               this.Location = new Point(Program.koordinasiAwalX + 330, Program.koordinasiAwalY + 400);*/

        }
    }
}

