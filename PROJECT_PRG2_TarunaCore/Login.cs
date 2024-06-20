using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace PROJECT_PRG2_TarunaCore
{
    public partial class Login : Form
    {
        private bool passwordVisible = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtKataSandi_TextChanged(object sender, EventArgs e)
        {
            if (!passwordVisible)
            {
                if (txtKataSandi.Text != "")
                {
                    txtKataSandi.PasswordChar = '*';
                }
                else
                {
                    txtKataSandi.PasswordChar = '\0';
                }
            }
        }

        int success = 1;
        private object label;

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (txtNamaPengguna.Text == "KETUA" && txtKataSandi.Text == "polman")
            {
                DashboardKetua dashboard = new DashboardKetua();
                dashboard.Show();
                this.Hide();
                Peringatan.Show("Login Berhasi! Selamat Datang "+ txtNamaPengguna.Text, Peringatan.AlertType.success);
            }
            else
            {
                Peringatan.Show("Username atau Password salah!", Peringatan.AlertType.error);
            }
             /*   string username = txtNamaPengguna.Text;
                string password = txtKataSandi.Text;

                // Connect to the database
                string connectionString = "integrated security = false; data source = .; User ID = sa; Password = POLTEK123; initial catalog = TesTarunaCore";
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the user exists and the password is correct
                    string query = "SELECT COUNT(*) FROM Warga WHERE username = @username AND password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                       int count = (int)command.ExecuteScalar();

                        if (count == 1)
                        {
                            // User exists and the password is correct
                            MessageBox.Show("Login successful");

                            // Get the role of the user
                            string queryRole = "SELECT MasterRole FROM Warga WHERE username = @username";
                            using (SqlCommand commandRole = new SqlCommand(queryRole, connection))
                            {
                                commandRole.Parameters.AddWithValue("@username", username);
                                string role = (string)commandRole.ExecuteScalar();

                                // Redirect the user to the appropriate form based on their role
                            }
                        }
                    }
                }*/
            
            }

        private void TampilPassword_Click(object sender, EventArgs e)
        {
            if (!passwordVisible)
            {
                // Mengubah ikon menjadi "eye.png"
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "eye.png");
                if (File.Exists(imagePath))
                {
                    TampilPassword.Image = Image.FromFile(imagePath);
                    txtKataSandi.PasswordChar = '\0'; // Menampilkan teks biasa
                    passwordVisible = true;
                }
                else
                {
                    MessageBox.Show("File gambar tidak ditemukan: " + imagePath);
                }
            }
            else
            {
                // Mengubah ikon menjadi "eye-off.png"
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "eye-off.png");
                if (File.Exists(imagePath))
                {
                    TampilPassword.Image = Image.FromFile(imagePath);
                    txtKataSandi.PasswordChar = '*'; // Menampilkan karakter bintang
                    passwordVisible = false;
                }
                else
                {
                    MessageBox.Show("File gambar tidak ditemukan: " + imagePath);
                }
            }
        }

        private void NamPengguna(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
   }

            
            
    
   
