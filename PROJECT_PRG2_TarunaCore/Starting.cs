using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore
{
    public partial class Starting : Form
    {
        private bool formClosed = false;

        public Starting()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(500);
            InitializeComponent();
            //t.Abort();
            t.Join();

            this.FormClosing += Starting_FormClosing;
        }

        public void StartForm()
        {
            Application.Run(new Masuk());
        }

        private void Starting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formClosed)
            {
                e.Cancel = true; // Membatalkan penutupan form
                                
            }
        }
    }
}
