using PROJECT_PRG2_TarunaCore.FormCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore.FromView
{
    public partial class DataRole : Form
    {
        int counter = 0;
        public DataRole()
        {
            InitializeComponent();
        }
        public static int parentX, parentY;


        public void RefreshDataGridView()
        {
            // dgvWarga.CellFormatting += dgvWarga_CellFormatting;

           /* BindingSource bindingSource = new BindingSource();

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connectionString))
                {
                    DataTable dt = new DataTable();
                    SqlCommand loadCommand = new SqlCommand("SELECT * FROM sp_InsertRole", connection);
                    loadCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(loadCommand);
                    adapter.Fill(dt);
                    bindingSource.DataSource = dt;
                    dgvWarga.DataSource = bindingSource;
                    DataGridViewColumn column = dgvWarga.Columns[2];

                    int rowCount = dt.Rows.Count;
                    counter = rowCount + 1;


                }
            }
            catch (Exception ex)
            {
                Peringatan.Show(ex.Message, Peringatan.AlertType.error);
            }*/
        
        /*    public void ConvertStatus()
            {
                foreach (DataGridViewRow row in dgvWarga.Rows)
                {
                    int role = Convert.ToInt32(row.Cells["status"].Value);

                    if (role == 1)
                    {
                        row.Cells["statusString"].Value = "Aktif";
                    }
                    else if (role == 0)
                    {
                        row.Cells["statusString"].Value = "Tidak Aktif";
                    }
                }
                dgvWarga.Columns["statusString"].DisplayIndex = 2;

            }
            
        }*/
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda Yakin Ingin Keluar?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // Log out if the user confirms
            if (result == DialogResult.OK)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void DataRole_Load(object sender, EventArgs e)
        {
           /* if (Program.Login_role == "1")
            {
                btnTambahData.Visible = true;
                dgvWarga.Columns["btnEdit"].Visible = false;
                dgvWarga.Columns["btnDelete"].Visible = false;

            }
            else if (Program.Login_role == "2")
            {
                dgvWarga.Columns["btnEdit"].Visible = false;
                dgvWarga.Columns["btnDelete"].Visible = false;

            }
            else if (Program.Login_role == "3")
            {
                dgvWarga.Columns["btnEdit"].Visible = false;
                dgvWarga.Columns["btnDelete"].Visible = false;

            }
            else if (Program.Login_role == "4")
            {
                dgvWarga.Columns["btnEdit"].Visible = false;
                dgvWarga.Columns["btnDelete"].Visible = false;

            }
            else if (Program.Login_role == "5")
            {
                dgvWarga.Columns["btnEdit"].Visible = false;
                dgvWarga.Columns["btnDelete"].Visible = false;

            }

            dgvWarga.Columns["roleID"].Visible = false;
            dgvWarga.Columns["status"].Visible = false;
            DataGridViewColumn newColumn = new DataGridViewTextBoxColumn();

            // TODO: This line of code loads data into the 'tarunaCore.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.tarunaCore.Role);*/
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnWarga_Click(object sender, EventArgs e)
        {
            Data_Warga formLihatData = new Data_Warga();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            DataUser formLihatData = new DataUser();
            formLihatData.StartPosition = FormStartPosition.CenterScreen;
            formLihatData.Show();
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            TambahRole Tambahrole = new TambahRole();

            // Menampilkan formEditWarga sebagai dialog
            Tambahrole.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
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
    }
}
