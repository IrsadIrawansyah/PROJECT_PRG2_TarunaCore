using System;

namespace PROJECT_PRG2_TarunaCore
{
    partial class DashboardKetua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardKetua));
            this.transisiWarga = new System.Windows.Forms.Timer(this.components);
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
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // transisiWarga
            // 
            this.transisiWarga.Tick += new System.EventHandler(this.transisiWarga_Tick);
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
            this.panel3.TabIndex = 18;
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
            this.btnLogOut.Size = new System.Drawing.Size(136, 31);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Keluar";
            this.btnLogOut.UseTransparentBackground = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
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
            this.guna2PictureBox2.Location = new System.Drawing.Point(95, 2);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(190, 208);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // DashboardKetua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1619, 991);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardKetua";
            this.Text = "DashboardKetua";
            this.Load += new System.EventHandler(this.DashboardKetua_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Timer transisiWarga;
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
    }
}