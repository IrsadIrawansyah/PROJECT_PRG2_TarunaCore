using PROJECT_PRG2_TarunaCore.FromView;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJECT_PRG2_TarunaCore.FormCRUD
{
    public partial class EditWarga : Form
    {
        public EditWarga(string nik, string nama, string tglLahir, string alamat, string nmrTelepon, string status)
        {
            InitializeComponent();
            LoadData();
            // Isi kontrol pada form EditWarga dengan data yang diterima
            txtNIK.Text = nik; // Asumsi txtNIK adalah kontrol TextBox untuk NIK
            txtNamaWarga.Text = nama; // Asumsi txtNama adalah kontrol TextBox untuk Nama
            txtTglLahir.Text = tglLahir; // Asumsi dtpTglLahir adalah kontrol DateTimePicker untuk Tgl Lahir
            txtAlamat.Text = alamat; // Asumsi txtAlamat adalah kontrol TextBox untuk Alamat
            txtNomorHandphone.Text = nmrTelepon; // Asumsi txtNmrTelepon adalah kontrol TextBox untuk Nmr Telepon
            txtStatus.Text = status;
            btnSubmit.Text = status == "Aktif" ? "Ubah Data" : "Aktifkan";

        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID_NIK FROM Warga", connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtNIK.Text = reader["ID_NIK"].ToString();
                }

                reader.Close();
                connection.Close();
            }
        }

     /*   private string GetStatusText(string status)
        {
            if (status == "Aktif")
            {
                return "Aktif";
            }
            else if (status == "Tidak Aktif")
            {
                return "Tidak Aktif";
            }
            else
            {
                return "Aktif";
            }


        }*/

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtNIK.Text) ||
                string.IsNullOrEmpty(txtNamaWarga.Text) ||
                string.IsNullOrEmpty(txtTglLahir.Text) ||
                string.IsNullOrEmpty(txtAlamat.Text) ||
                string.IsNullOrEmpty(txtNomorHandphone.Text) ||
                string.IsNullOrEmpty(txtStatus.Text))
            {
                Peringatan.Show("Harap Lengkapi Semua!", Peringatan.AlertType.info);
                return false;
            }

            if (txtNomorHandphone.Text.Length != 13 || !long.TryParse(txtNomorHandphone.Text, out _))
            {
                Peringatan.Show("Nomor Handphone Harus 13 Angka", Peringatan.AlertType.warning);
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            if (txtStatus.Text == "Aktif")
            {
                string ID_NIK = txtNIK.Text;
                string Nama_Warga = txtNamaWarga.Text;
                string Alamat = txtAlamat.Text;
                string Nmr_Telepon = txtNomorHandphone.Text;
                string Status = txtStatus.Text == "Aktif" ? "Aktif" : "Tidak Aktif";
                DateTime txtTglLahir = DateTime.ParseExact(this.txtTglLahir.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    try
                    {
                        MemoryStream stream = new MemoryStream();
                        pbFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();

                        connection.Open();
                        SqlCommand command = new SqlCommand("sp_UpdateWarga", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@ID_NIK", ID_NIK);
                        command.Parameters.AddWithValue("@Nama_Warga", Nama_Warga);
                        command.Parameters.AddWithValue("@Tgl_Lahir", txtTglLahir);
                        command.Parameters.AddWithValue("@Alamat", Alamat);
                        command.Parameters.AddWithValue("@Nmr_Telepon", Nmr_Telepon);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@foto", pic);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Peringatan.Show("Data berhasil diperbarui!", Peringatan.AlertType.success);
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        Peringatan.Show(ex.Message, Peringatan.AlertType.error);
                    }
                }

            }
            else if (txtStatus.Text == "Tidak Aktif")
            {
                string ID_NIK = txtNIK.Text;
                string Nama_Warga = txtNamaWarga.Text;
                string Alamat = txtAlamat.Text;
                string Nmr_Telepon = txtNomorHandphone.Text;
                string Status = "Aktif";
                DateTime txtTglLahir = DateTime.ParseExact(this.txtTglLahir.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    try
                    {
                        MemoryStream stream = new MemoryStream();
                        pbFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();

                        connection.Open();
                        SqlCommand command = new SqlCommand("sp_UpdateWarga", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@ID_NIK", ID_NIK);
                        command.Parameters.AddWithValue("@Nama_Warga", Nama_Warga);
                        command.Parameters.AddWithValue("@Tgl_Lahir", txtTglLahir);
                        command.Parameters.AddWithValue("@Alamat", Alamat);
                        command.Parameters.AddWithValue("@Nmr_Telepon", Nmr_Telepon);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@foto", pic);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Peringatan.Show("Data berhasil diperbarui!", Peringatan.AlertType.success);
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        Peringatan.Show(ex.Message, Peringatan.AlertType.error);
                    }
                }
            }
        }
        

        private void EditWarga_Load_1(object sender, EventArgs e)
        {
            //LoadData();
           // txtStatus.Text = GetStatusText(txtStatus.Text);
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            ClearFields();
            this.Close();
        }

        private void ClearFields()
        {
            txtNIK.Text = "";
            txtNamaWarga.Text = "";
            txtTglLahir.Text = "";
            txtAlamat.Text = "";
            txtNomorHandphone.Text = "";
            txtStatus.Text = "";
            pbFoto.Image = null;
        }

        private void btnPilihFoto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image File(.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        using (Stream myStream = openFileDialog.OpenFile())
                        {
                            if (myStream.Length > 5120000)
                            {
                                Peringatan.Show("Ukuran file terlalu besar!, maksimum hanya 5 MB", Peringatan.AlertType.warning);
                            }
                            else
                            {
                                pbFoto.Load(openFileDialog.FileName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Peringatan.Show(ex.Message, Peringatan.AlertType.error);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Data_Warga warga = new Data_Warga();
            warga.Show();
            this.Hide();
        }

        private void Timer_FormWarga_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Timer_FormWarga.Stop();
            }
            else
            {
                Opacity += .02;
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
