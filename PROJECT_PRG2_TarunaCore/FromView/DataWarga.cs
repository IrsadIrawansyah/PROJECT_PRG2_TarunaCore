using PROJECT_PRG2_TarunaCore.FormCRUD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Reflection;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore.FromView
{
    public partial class Data_Warga : Form
    {
        public Data_Warga()
        {
            InitializeComponent();
        }

        private void Data_Warga_Load(object sender, EventArgs e)
        {
            // Mengisi data ke dalam DataGridView dari dataset
            this.wargaTableAdapter1.Fill(this.tarunaCore1.Warga);
            this.WindowState = FormWindowState.Maximized;

            // Menambahkan kolom gambar setelah DataGridView terisi dengan data
            AddEditButtonColumn();
            AddDeleteButtonColumn();
        }

        private string GenerateNIK()
        {
            string nikOtomatis = string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    connection.Open();
                    string query = "EXEC sp_UpdateWarga @ID_NIK = NULL, @Nama_Warga = NULL, @Tgl_Lahir = NULL, @Alamat = NULL, @Nmr_Telepon = NULL, @Status = NULL, @foto = NULL";
                    SqlCommand command = new SqlCommand(query, connection);
                    nikOtomatis = command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                Peringatan.Show("Error", Peringatan.AlertType.error);
            }
            return nikOtomatis;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvWarga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Pastikan kolom yang diklik adalah kolom "btnEdit"
                if (dgvWarga.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    DataGridViewRow selectedRow = dgvWarga.Rows[e.RowIndex];
                    string nik = selectedRow.Cells["iDNIKDataGridViewTextBoxColumn"].Value.ToString();
                    string nama = selectedRow.Cells["namaWargaDataGridViewTextBoxColumn"].Value.ToString();
                    string tglLahir = selectedRow.Cells["tglLahirDataGridViewTextBoxColumn"].Value.ToString();
                    string alamat = selectedRow.Cells["alamatDataGridViewTextBoxColumn"].Value.ToString();
                    string nmrTelepon = selectedRow.Cells["nmrTeleponDataGridViewTextBoxColumn"].Value.ToString();
                    string status = selectedRow.Cells["statusDataGridViewTextBoxColumn"].Value.ToString();

                    // Buka form EditWarga dan kirim data yang diperlukan
                    DateTime date = DateTime.ParseExact(tglLahir, "dd/MM/yyyy HH.mm.ss", CultureInfo.InvariantCulture);
                    tglLahir = date.ToString("dd/MM/yyyy");
                    EditWarga editForm = new EditWarga(nik, nama, tglLahir, alamat, nmrTelepon, status);
                    editForm.ShowDialog();
                    RefreshDataGrid();
                }

                // Pastikan kolom yang diklik adalah kolom "btnDelete"
                if (dgvWarga.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    // Memastikan ada baris yang dipilih
                    if (dgvWarga.SelectedRows.Count > 0)
                    {
                        // Menampilkan pesan konfirmasi
                        DialogResult result = MessageBox.Show("Apakah Anda yakin untuk mengubah status data ini menjadi 'Tidak Aktif'?", "Konfirmasi Ubah Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Mendapatkan baris yang dipilih
                            DataGridViewRow selectedRow = dgvWarga.Rows[e.RowIndex];
                            string NIK = selectedRow.Cells["iDNIKDataGridViewTextBoxColumn"].Value.ToString();

                            try
                            {
                                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                                {
                                    connection.Open();
                                    using (SqlCommand cmd = new SqlCommand("UPDATE Warga SET Status = @Status WHERE ID_NIK = @ID_NIK", connection))
                                    {
                                        cmd.Parameters.AddWithValue("@ID_NIK", NIK);
                                        cmd.Parameters.AddWithValue("@Status", "Tidak Aktif");
                                        cmd.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("Status Warga berhasil diubah menjadi 'Tidak Aktif'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Memperbarui data di DataGridView
                                    selectedRow.Cells["statusDataGridViewTextBoxColumn"].Value = "Tidak Aktif";
                                    dgvWarga.InvalidateRow(e.RowIndex); // Memastikan bahwa baris di-refresh
                                    RefreshDataGrid();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void AddEditButtonColumn()
        {
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "btnEdit";
            imgColumn.HeaderText = "";
            imgColumn.Image = Properties.Resources.Group_211;
            dgvWarga.Columns.Add(imgColumn);

            // Menetapkan nilai kolom gambar untuk setiap baris
            foreach (DataGridViewRow row in dgvWarga.Rows)
            {
                row.Cells["btnEdit"].Value = Properties.Resources.Group_211;
            }
        }

        private void tarunaCore1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            TambahWarga TambahWarga = new TambahWarga();

            // Menampilkan formEditWarga sebagai dialog
            TambahWarga.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
            string ID_NIK = GenerateNIK();
            RefreshDataGrid();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtCari.Text.Trim();

            // Hapus pemilihan atau fokus dari baris yang dipilih sebelum pencarian
            dgvWarga.ClearSelection();
            dgvWarga.CurrentCell = null;

            if (string.IsNullOrEmpty(searchText))
            {
                // Jika teks pencarian kosong, tampilkan semua baris
                foreach (DataGridViewRow row in dgvWarga.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                // Filter baris berdasarkan kriteria pencarian
                foreach (DataGridViewRow row in dgvWarga.Rows)
                {
                    bool match = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            // Jika ada kecocokan dengan kriteria pencarian, tandai sebagai kecocokan
                            match = true;
                            break;
                        }
                    }
                    row.Visible = match;
                }
            }
        }

        private void AddDeleteButtonColumn()
        {
            // Membuat kolom gambar untuk tombol Delete
            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Name = "btnDelete";
            deleteColumn.HeaderText = "";
            deleteColumn.Image = Properties.Resources.Group_212__1_; // Ganti dengan gambar yang sesuai

            // Menambahkan kolom ke DataGridView
            dgvWarga.Columns.Add(deleteColumn);

            // Menetapkan nilai kolom gambar untuk setiap baris
            foreach (DataGridViewRow row in dgvWarga.Rows)
            {
                row.Cells["btnDelete"].Value = Properties.Resources.Group_212__1_; // Ganti dengan gambar yang sesuai
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (KonfirmasiBoxAll modal = new KonfirmasiBoxAll("Apakah anda yakin ingin keluar?"))
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                Program.koordinasiAwalX = this.Location.X;
                Program.koordinasiAwalY = this.Location.Y + 540;
                Program.koordinasiAwalY_KonfirmasiBox = parentY;

                modal.ShowDialog();
                modalBackground.Dispose();
            }

            if (Program.Box_Konfirmasi == 1)
            {
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }

        private void dgvWarga_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            DataRole formLihatData = new DataRole();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DashboardKetua formLihatData = new DashboardKetua();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
            transisiWarga.Start();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            DataUser formLihatData = new DataUser();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }

        private void btnWarga_Click(object sender, EventArgs e)
        {

        }  
        public static int parentX, parentY;
        private void RefreshDataGrid()
        {
            this.wargaTableAdapter1.Fill(this.tarunaCore1.Warga);
        }
    }
}
