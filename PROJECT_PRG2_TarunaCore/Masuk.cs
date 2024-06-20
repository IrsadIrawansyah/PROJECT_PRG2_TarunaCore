using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore
{
   
    public partial class Masuk : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths;
       
        public Masuk()
        {
            InitializeComponent();
            string currentDirectory = Directory.GetCurrentDirectory();
            string projectPath = Path.GetDirectoryName(currentDirectory);
        }

        private void Timer_SplashScreen_Tick(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
        private void btnMasuk_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
          
        }

        private void Masuk_Load_1(object sender, EventArgs e)
        {
            // Mengatur event handler untuk Timer
            Timer_SplashScreen.Tick += Timer_SplashScreen_Tick;

            // Mengatur interval Timer ke 3000 (3 detik)
             Timer_SplashScreen.Interval = 300000;

            // Mulai Timer
            Timer_SplashScreen.Start();
            //this.WindowState = FormWindowState.Maximized;
        }
       
    }
}
