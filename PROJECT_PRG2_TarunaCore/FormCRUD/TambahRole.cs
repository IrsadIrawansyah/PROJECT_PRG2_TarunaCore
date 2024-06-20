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
using System.Web.Security;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore.FormCRUD
{
    public partial class TambahRole : Form
    {
        public TambahRole()
        {
            InitializeComponent();
        }
        int i = 0;
        int y = 0;

        private void TambahRole_Load(object sender, EventArgs e)
        {
            txtIDRole.Text = Program.formatID;
            i = FromView.DataRole.parentY + 290;
            this.Location = new Point(FromView.DataRole.parentX + 220, FromView.DataUser.parentY + 150);
        }
        private int startY;

        private void TambahRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            FromView.DataRole.parentY = startY;
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
            txtIDRole.Text = "";
            cbRole.Text = "";
            txtStatus.Text = "";
            pbFoto.Image = null;
        }
        int role;
        private void ConvertRole()
        {
            if (cbRole.Text == "Ketua")
            {
                role = 1;
            }
            else if (cbRole.Text == "Bendahara")
            {
                role = 2;
            }
            else if (cbRole.Text == "Sekretaris")
            {
                role = 3;
            }
           
            {
                Peringatan.Show("Role tidak valid!", Peringatan.AlertType.error);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string idRole = txtIDRole.Text;
            string namaRole = cbRole.Text;
            int status;
            byte[] foto = null;

            if (!int.TryParse(txtStatus.Text, out status))
            {
                MessageBox.Show("Status harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pbFoto.Image != null)
            {
                foto = ConvertImageToByteArray(pbFoto.Image);
            }


            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                if (Validasi() && !string.IsNullOrEmpty(idRole) && !string.IsNullOrEmpty(namaRole))
                {
                    ConvertRole();

                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_InsertRole", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Role", idRole);
                    command.Parameters.AddWithValue("@Nama_Role", namaRole);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Foto", foto);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan!");
                    Clear();
                }
                    try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_InsertRole", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID_Role", idRole);
                        command.Parameters.AddWithValue("@Nama_Role", namaRole);
                        command.Parameters.AddWithValue("@Status", "1");
                        command.Parameters.AddWithValue("@foto", foto);

                        command.ExecuteNonQuery();
                        Peringatan.Show("Data berhasil ditambahkan!", Peringatan.AlertType.success);
                        Clear();
                        connection.Close();

                        FromView.DataRole fromview = Application.OpenForms.OfType<FromView.DataRole>().FirstOrDefault();
                        if (fromview != null)
                        {
                            fromview.RefreshDataGridView();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private bool Validasi()
        {
            if (string.IsNullOrEmpty(txtIDRole.Text) || string.IsNullOrEmpty(cbRole.Text) ||
                string.IsNullOrEmpty(txtStatus.Text))
            {
                Peringatan.Show("Harap isi semua field yang diperlukan!", Peringatan.AlertType.error);
                return false;
            }

            int status;
            if (!int.TryParse(txtStatus.Text, out status))
            {
                Peringatan.Show("Status harus diisi dengan angka!", Peringatan.AlertType.warning);
                return false;
            }

            if (pbFoto.Image == null)
            {
                Peringatan.Show("Harap pilih foto!", Peringatan.AlertType.error);
                return false;
            }

            return true;
        }
    }
}