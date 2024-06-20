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
    public partial class Peringatan : Form
    {


        public Peringatan(string _message, AlertType type)
        {
            InitializeComponent();

            message.Text = _message;
            switch (type)
            {

                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    break;
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    break;

            }
        }
        public static void Show(string _message, AlertType type)
        {
            new Peringatan(_message, type).Show();
        }

        private void Peringatan_Load(object sender, EventArgs e)
        {
            this.Top = 40;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 40;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            close.Start();
        }

        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            close.Start();
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.5;
            }
            else
            {
                this.Close();
            }
        }

        public enum AlertType
        {
            success, info, warning, error,
            OKCancel
        }
    }
}