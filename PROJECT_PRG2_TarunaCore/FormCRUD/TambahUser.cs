using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore.FormCRUD
{
    public partial class TambahUser : Form
    {
        public TambahUser()
        {
            InitializeComponent();
        }

        int i = 0;
        int y = 0;

        private void TambahUser_Load(object sender, EventArgs e)
        {
            txtIDUser.Text = Program.formatID;
            i = FromView.DataUser.parentY + 290;
            this.Location = new Point(FromView.DataUser.parentX + 220, FromView.DataUser.parentY + 150);
            txtStatus.Text = "Aktif";
            LoadRoles();
        }

        private int startY;

        private void TambahUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            FromView.DataUser.parentY = startY;
        }

        private void LoadRoles()
        {
           
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID_Role, RoleName FROM Role"; // Ganti dengan query yang sesuai untuk mengambil role dari tabel Anda
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbRole.Items.Add(new { ID = reader["ID_Role"].ToString(), Name = reader["RoleName"].ToString() });
                            }
                            cbRole.DisplayMember = "Name";
                            cbRole.ValueMember = "ID";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(.jpg; *.jpeg; *.png) | *.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string Filename = openFileDialog.FileName;
                        if (myStream.Length > 5120000)
                        {
                            Peringatan.Show("Ukuran file terlalu besar!, maksimum hanya 500 Kb", Peringatan.AlertType.error);
                        }
                        else
                        {
                            pbFoto.Load(Filename);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Peringatan.Show(ex.Message, Peringatan.AlertType.error);
                }
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void Clear()
        {
            txtIDUser.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbRole.Text = "";
            pbFoto.Image = null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string idUser = txtIDUser.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = (cbRole.SelectedItem as dynamic).ID;
           // string idNIK = txtIDNIK.Text; // Ambil nilai dari TextBox txtIDNIK
            byte[] foto = null;

            if (pbFoto.Image != null)
            {
                foto = ConvertImageToByteArray(pbFoto.Image);
            }

          
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_InsertUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID_User", idUser);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Status", txtStatus); // Atau bisa disesuaikan dengan input dari form
                      //  command.Parameters.AddWithValue("@ID_NIK", ); // Menggunakan nilai dari TextBox txtIDNIK
                        command.Parameters.AddWithValue("@ID_Role", role);
                        command.Parameters.AddWithValue("@foto", foto);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan!");
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
