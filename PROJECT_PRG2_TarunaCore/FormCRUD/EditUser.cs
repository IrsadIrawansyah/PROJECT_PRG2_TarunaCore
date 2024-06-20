using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2_TarunaCore.FormCRUD
{
    public partial class EditUser : Form
    {
        //int i = 0;
        //int y = 0;
        // private object btnSubmit;

        public EditUser()
        {
            InitializeComponent();
        }

        private void EditRole_Load(object sender, EventArgs e)
        {

        }
        /*private string GetStatusText()
        {
            if (Program.User_status == "1")
            {
                btnSubmit.Text = "Ubah Admin";
                return "Aktif";
            }
            else if (Program.User_status == "0")
            {
                txtEmail.Enabled = false;
                txtNama.Enabled = false;
                txtPassword.Enabled = false;
                cmbRole.Enabled = false;
                txtNama.Enabled = false;
                txtUsername.Enabled = false;
                txtNoTelp.Enabled = false;
                btnSubmit.Text = "Aktifkan";
                return "Tidak Aktif";
            }
            else
            {
                return "Status Tidak Valid";
            }
        }*/

    }
}
