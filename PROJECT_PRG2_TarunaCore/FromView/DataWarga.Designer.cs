using System;

namespace PROJECT_PRG2_TarunaCore.FromView
{
    partial class Data_Warga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Warga));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTambahData = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvWarga = new Guna.UI2.WinForms.Guna2DataGridView();
            this.wargaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tarunaCore1 = new PROJECT_PRG2_TarunaCore.TarunaCore();
            this.wargaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarunaCore1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wargaTableAdapter1 = new PROJECT_PRG2_TarunaCore.TarunaCoreTableAdapters.WargaTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBeranda = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnData = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnWarga = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeminjamanPengembalian = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrsKeluhan = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.transisiWarga = new System.Windows.Forms.Timer(this.components);
            this.iDNIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaWargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmrTeleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarunaCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarunaCore1BindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.btnMinimize);
            this.panel9.Controls.Add(this.btnExit);
            this.panel9.Location = new System.Drawing.Point(401, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1482, 74);
            this.panel9.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data Warga";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1327, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.Size = new System.Drawing.Size(69, 74);
            this.btnMinimize.TabIndex = 30;
            this.btnMinimize.UseTransparentBackground = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1400, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(82, 74);
            this.btnExit.TabIndex = 29;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtCari
            // 
            this.txtCari.BorderColor = System.Drawing.Color.Black;
            this.txtCari.BorderRadius = 10;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.txtCari.ForeColor = System.Drawing.Color.Black;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(401, 111);
            this.txtCari.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCari.PlaceholderText = "Ketik disini untuk mencari";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(571, 52);
            this.txtCari.TabIndex = 25;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnTambahData
            // 
            this.btnTambahData.BorderRadius = 10;
            this.btnTambahData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahData.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTambahData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahData.ForeColor = System.Drawing.Color.White;
            this.btnTambahData.Location = new System.Drawing.Point(1598, 126);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(201, 52);
            this.btnTambahData.TabIndex = 26;
            this.btnTambahData.Text = "Tambah Data";
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel8.Location = new System.Drawing.Point(401, 221);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1482, 54);
            this.panel8.TabIndex = 27;
            // 
            // dgvWarga
            // 
            this.dgvWarga.AllowUserToAddRows = false;
            this.dgvWarga.AllowUserToDeleteRows = false;
            this.dgvWarga.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvWarga.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvWarga.AutoGenerateColumns = false;
            this.dgvWarga.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvWarga.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            this.dgvWarga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWarga.ColumnHeadersHeight = 40;
            this.dgvWarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvWarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNIKDataGridViewTextBoxColumn,
            this.namaWargaDataGridViewTextBoxColumn,
            this.tglLahirDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nmrTeleponDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn});
            this.dgvWarga.DataSource = this.wargaBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWarga.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWarga.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvWarga.Location = new System.Drawing.Point(401, 281);
            this.dgvWarga.MultiSelect = false;
            this.dgvWarga.Name = "dgvWarga";
            this.dgvWarga.ReadOnly = true;
            this.dgvWarga.RowHeadersVisible = false;
            this.dgvWarga.RowHeadersWidth = 51;
            this.dgvWarga.Size = new System.Drawing.Size(1482, 677);
            this.dgvWarga.TabIndex = 28;
            this.dgvWarga.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvWarga.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvWarga.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvWarga.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWarga.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvWarga.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvWarga.ThemeStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvWarga.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvWarga.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvWarga.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvWarga.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWarga.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWarga.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvWarga.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvWarga.ThemeStyle.ReadOnly = true;
            this.dgvWarga.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvWarga.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWarga.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWarga.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWarga.ThemeStyle.RowsStyle.Height = 22;
            this.dgvWarga.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvWarga.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvWarga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarga_CellContentClick);
            this.dgvWarga.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWarga_CellFormatting);
            // 
            // wargaBindingSource1
            // 
            this.wargaBindingSource1.DataMember = "Warga";
            this.wargaBindingSource1.DataSource = this.tarunaCore1;
            // 
            // tarunaCore1
            // 
            this.tarunaCore1.DataSetName = "TarunaCore";
            this.tarunaCore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wargaBindingSource
            // 
            this.wargaBindingSource.DataMember = "Warga";
            this.wargaBindingSource.DataSource = this.tarunaCore1BindingSource;
            // 
            // tarunaCore1BindingSource
            // 
            this.tarunaCore1BindingSource.DataSource = this.tarunaCore1;
            this.tarunaCore1BindingSource.Position = 0;
            this.tarunaCore1BindingSource.CurrentChanged += new System.EventHandler(this.tarunaCore1BindingSource_CurrentChanged);
            // 
            // wargaTableAdapter1
            // 
            this.wargaTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.guna2PictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 991);
            this.panel3.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBeranda);
            this.panel6.Location = new System.Drawing.Point(31, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(327, 41);
            this.panel6.TabIndex = 23;
            // 
            // btnBeranda
            // 
            this.btnBeranda.BackColor = System.Drawing.Color.Transparent;
            this.btnBeranda.BorderRadius = 10;
            this.btnBeranda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBeranda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBeranda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBeranda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBeranda.FillColor = System.Drawing.Color.Transparent;
            this.btnBeranda.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBeranda.ForeColor = System.Drawing.Color.Black;
            this.btnBeranda.Image = ((System.Drawing.Image)(resources.GetObject("btnBeranda.Image")));
            this.btnBeranda.Location = new System.Drawing.Point(5, 7);
            this.btnBeranda.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Size = new System.Drawing.Size(139, 32);
            this.btnBeranda.TabIndex = 23;
            this.btnBeranda.Text = "Beranda";
            this.btnBeranda.UseTransparentBackground = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnData);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.btnPeminjamanPengembalian);
            this.flowLayoutPanel1.Controls.Add(this.btnTrsKeluhan);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 260);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 661);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.BorderRadius = 10;
            this.btnData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnData.FillColor = System.Drawing.Color.Transparent;
            this.btnData.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnData.ForeColor = System.Drawing.Color.Black;
            this.btnData.Image = ((System.Drawing.Image)(resources.GetObject("btnData.Image")));
            this.btnData.Location = new System.Drawing.Point(2, 2);
            this.btnData.Margin = new System.Windows.Forms.Padding(2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(108, 32);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Data";
            this.btnData.UseTransparentBackground = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRole);
            this.panel5.Controls.Add(this.btnUser);
            this.panel5.Controls.Add(this.btnWarga);
            this.panel5.Location = new System.Drawing.Point(2, 38);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 136);
            this.panel5.TabIndex = 21;
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.Transparent;
            this.btnRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRole.FillColor = System.Drawing.Color.Transparent;
            this.btnRole.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRole.ForeColor = System.Drawing.Color.Black;
            this.btnRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRole.Image")));
            this.btnRole.Location = new System.Drawing.Point(2, 46);
            this.btnRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(148, 37);
            this.btnRole.TabIndex = 9;
            this.btnRole.Text = "Data Role";
            this.btnRole.UseTransparentBackground = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(2, 87);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(148, 37);
            this.btnUser.TabIndex = 10;
            this.btnUser.Text = "Data User";
            this.btnUser.UseTransparentBackground = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnWarga
            // 
            this.btnWarga.BackColor = System.Drawing.Color.Transparent;
            this.btnWarga.BorderRadius = 10;
            this.btnWarga.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWarga.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWarga.FillColor = System.Drawing.Color.Transparent;
            this.btnWarga.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnWarga.ForeColor = System.Drawing.Color.Black;
            this.btnWarga.Image = ((System.Drawing.Image)(resources.GetObject("btnWarga.Image")));
            this.btnWarga.Location = new System.Drawing.Point(2, 10);
            this.btnWarga.Margin = new System.Windows.Forms.Padding(2);
            this.btnWarga.Name = "btnWarga";
            this.btnWarga.Size = new System.Drawing.Size(165, 32);
            this.btnWarga.TabIndex = 22;
            this.btnWarga.Text = "Data Warga";
            this.btnWarga.UseTransparentBackground = true;
            this.btnWarga.Click += new System.EventHandler(this.btnWarga_Click);
            // 
            // btnPeminjamanPengembalian
            // 
            this.btnPeminjamanPengembalian.BackColor = System.Drawing.Color.Transparent;
            this.btnPeminjamanPengembalian.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPeminjamanPengembalian.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPeminjamanPengembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPeminjamanPengembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPeminjamanPengembalian.FillColor = System.Drawing.Color.Transparent;
            this.btnPeminjamanPengembalian.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjamanPengembalian.ForeColor = System.Drawing.Color.Black;
            this.btnPeminjamanPengembalian.Image = ((System.Drawing.Image)(resources.GetObject("btnPeminjamanPengembalian.Image")));
            this.btnPeminjamanPengembalian.Location = new System.Drawing.Point(2, 178);
            this.btnPeminjamanPengembalian.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeminjamanPengembalian.Name = "btnPeminjamanPengembalian";
            this.btnPeminjamanPengembalian.Size = new System.Drawing.Size(299, 36);
            this.btnPeminjamanPengembalian.TabIndex = 10;
            this.btnPeminjamanPengembalian.Text = "Peminjaman Pengembalian";
            this.btnPeminjamanPengembalian.UseTransparentBackground = true;
            // 
            // btnTrsKeluhan
            // 
            this.btnTrsKeluhan.BackColor = System.Drawing.Color.Transparent;
            this.btnTrsKeluhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrsKeluhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrsKeluhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrsKeluhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrsKeluhan.FillColor = System.Drawing.Color.Transparent;
            this.btnTrsKeluhan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrsKeluhan.ForeColor = System.Drawing.Color.Black;
            this.btnTrsKeluhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTrsKeluhan.Image")));
            this.btnTrsKeluhan.Location = new System.Drawing.Point(2, 218);
            this.btnTrsKeluhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrsKeluhan.Name = "btnTrsKeluhan";
            this.btnTrsKeluhan.Size = new System.Drawing.Size(139, 37);
            this.btnTrsKeluhan.TabIndex = 10;
            this.btnTrsKeluhan.Text = "Keluhan";
            this.btnTrsKeluhan.UseTransparentBackground = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Location = new System.Drawing.Point(3, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 41);
            this.panel4.TabIndex = 22;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(2, 2);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(147, 31);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseTransparentBackground = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(367, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 185);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 185);
            this.panel1.TabIndex = 3;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(96, 1);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(190, 208);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // iDNIKDataGridViewTextBoxColumn
            // 
            this.iDNIKDataGridViewTextBoxColumn.DataPropertyName = "ID_NIK";
            this.iDNIKDataGridViewTextBoxColumn.HeaderText = "ID NIK";
            this.iDNIKDataGridViewTextBoxColumn.Name = "iDNIKDataGridViewTextBoxColumn";
            this.iDNIKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaWargaDataGridViewTextBoxColumn
            // 
            this.namaWargaDataGridViewTextBoxColumn.DataPropertyName = "Nama_Warga";
            this.namaWargaDataGridViewTextBoxColumn.HeaderText = "Nama Warga";
            this.namaWargaDataGridViewTextBoxColumn.Name = "namaWargaDataGridViewTextBoxColumn";
            this.namaWargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tglLahirDataGridViewTextBoxColumn
            // 
            this.tglLahirDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Lahir";
            this.tglLahirDataGridViewTextBoxColumn.HeaderText = "Tgl Lahir";
            this.tglLahirDataGridViewTextBoxColumn.Name = "tglLahirDataGridViewTextBoxColumn";
            this.tglLahirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmrTeleponDataGridViewTextBoxColumn
            // 
            this.nmrTeleponDataGridViewTextBoxColumn.DataPropertyName = "Nmr_Telepon";
            this.nmrTeleponDataGridViewTextBoxColumn.HeaderText = "Nmr Telepon";
            this.nmrTeleponDataGridViewTextBoxColumn.Name = "nmrTeleponDataGridViewTextBoxColumn";
            this.nmrTeleponDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // Data_Warga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1884, 991);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dgvWarga);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnTambahData);
            this.Controls.Add(this.txtCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data_Warga";
            this.Text = "Data_Warga";
            this.Load += new System.EventHandler(this.Data_Warga_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarunaCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarunaCore1BindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Button btnTambahData;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2DataGridView dgvWarga;
        private System.Windows.Forms.BindingSource tarunaCore1BindingSource;
        private TarunaCore tarunaCore1;
        private System.Windows.Forms.BindingSource wargaBindingSource;
        private TarunaCoreTableAdapters.WargaTableAdapter wargaTableAdapter1;
        private System.Windows.Forms.BindingSource wargaBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnBeranda;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnData;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnRole;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnWarga;
        private Guna.UI2.WinForms.Guna2Button btnPeminjamanPengembalian;
        private Guna.UI2.WinForms.Guna2Button btnTrsKeluhan;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Timer transisiWarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaWargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmrTeleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
    }
}