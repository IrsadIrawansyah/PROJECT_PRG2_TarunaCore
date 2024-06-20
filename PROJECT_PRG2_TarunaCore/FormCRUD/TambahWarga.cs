using PROJECT_PRG2_TarunaCore.FromView;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore.FormCRUD
{
    public partial class TambahWarga : Form
    {
        public TambahWarga()
        {
            InitializeComponent();
        }

        private void TambahWarga_Load(object sender, EventArgs e)
        {
            // Initialize form settings here if needed
            txtStatus.Text = "Aktif";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Data_Warga warga = new Data_Warga();
            warga.Show();
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validasi() && CekAngka_nama(txtNamaWarga.Text) && IsValidPhoneNumber() && IsValidDate(txtTglLahir.Text))
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    try
                    {
                        MemoryStream stream = new MemoryStream();
                        pbFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();

                        connection.Open();
                        SqlCommand command = new SqlCommand("sp_InsertWarga", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID_NIK", txtNIK.Text);
                        command.Parameters.AddWithValue("@Nama_Warga", txtNamaWarga.Text);
                        command.Parameters.AddWithValue("@Tgl_Lahir", DateTime.ParseExact(txtTglLahir.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        command.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                        command.Parameters.AddWithValue("@Nmr_Telepon", txtNomorHandphone.Text);
                        command.Parameters.AddWithValue("@Status", txtStatus.Text);
                        command.Parameters.AddWithValue("@foto", pic);
                        command.ExecuteNonQuery();
                        connection.Close();
                        Peringatan.Show("Data berhasil ditambahkan!", Peringatan.AlertType.success);
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        Peringatan.Show(ex.Message, Peringatan.AlertType.error);
                    }
                }
            }
        }

        private void ClearFields()
        {
            txtNIK.Text = "";
            txtNamaWarga.Text = "";
            txtTglLahir.Text = "";
            txtAlamat.Text = "";
            txtNomorHandphone.Text = "";
            txtStatus.Text = "";
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(.jpg; *.jpeg; *.png) | *.jpg;.jpeg; *.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string Filename = openFileDialog.FileName;
                        if (myStream.Length > 5120000)
                        {
                            Peringatan.Show("Ukuran file terlalu besar!, maksimum hanya 5 MB", Peringatan.AlertType.error);
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

        private bool Validasi()
        {
            if (string.IsNullOrEmpty(txtNIK.Text) ||
                string.IsNullOrEmpty(txtNamaWarga.Text) ||
                string.IsNullOrEmpty(txtTglLahir.Text) ||
                string.IsNullOrEmpty(txtAlamat.Text) ||
                string.IsNullOrEmpty(txtNomorHandphone.Text) ||
                string.IsNullOrEmpty(txtStatus.Text))
            {
                Peringatan.Show("Harap Lengkapi Semua!", Peringatan.AlertType.error);
                return false;
            }


            return true;
        }

        private bool CekAngka_nama(string inputString)
        {
            if (inputString.All(char.IsDigit))
            {
                Peringatan.Show("Format nama tidak valid!", Peringatan.AlertType.warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsValidPhoneNumber()
        {
            string phoneNumber = txtNomorHandphone.Text;
            bool isValid = Regex.IsMatch(phoneNumber, @"^\d{13}$");

            if (!isValid)
            {
                Peringatan.Show("Nomor Telepon Harus 13 Digit Angka!", Peringatan.AlertType.warning);
            }

            return isValid;
        }

        private bool IsValidDate(string date)
        {
            if (!DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                Peringatan.Show("Format Tanggal Lahir harus dd/MM/yyyy", Peringatan.AlertType.warning);
                return false;
            }

            if (parsedDate > DateTime.Now)
            {
                Peringatan.Show("Tanggal Lahir Tidak Boleh Melebihi Tanggal Hari Ini", Peringatan.AlertType.warning);
                return false;
            }

            return true;
        }
        
    }
}
