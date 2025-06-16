
namespace Database_Bimbel_Time
{
    partial class UCJadwalStaf
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblNamaLengkap = new Label();
            dgvJadwal = new DataGridView();
            txtHari = new DataGridViewTextBoxColumn();
            txtJamMulai = new DataGridViewTextBoxColumn();
            txtJamSelesai = new DataGridViewTextBoxColumn();
            txtKelasID = new DataGridViewTextBoxColumn();
            txtPengajarID = new DataGridViewTextBoxColumn();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dateTimePickerMulai = new DateTimePicker();
            dateTimePickerSelesai = new DateTimePicker();
            cmbHari = new ComboBox();
            cmbKelas = new ComboBox();
            cmbPengajar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(235, 91);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(93, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tes Jadwal";
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Location = new Point(172, 141);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(131, 25);
            lblNamaLengkap.TabIndex = 1;
            lblNamaLengkap.Text = "Nama Lengkap";
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Columns.AddRange(new DataGridViewColumn[] { txtHari, txtJamMulai, txtJamSelesai, txtKelasID, txtPengajarID });
            dgvJadwal.Location = new Point(87, 188);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 62;
            dgvJadwal.Size = new Size(906, 371);
            dgvJadwal.TabIndex = 2;
            // 
            // txtHari
            // 
            txtHari.HeaderText = "Hari";
            txtHari.MinimumWidth = 8;
            txtHari.Name = "txtHari";
            txtHari.Width = 150;
            // 
            // txtJamMulai
            // 
            txtJamMulai.HeaderText = "Jam Mulai";
            txtJamMulai.MinimumWidth = 8;
            txtJamMulai.Name = "txtJamMulai";
            txtJamMulai.Width = 150;
            // 
            // txtJamSelesai
            // 
            txtJamSelesai.HeaderText = "Jam Selesai";
            txtJamSelesai.MinimumWidth = 8;
            txtJamSelesai.Name = "txtJamSelesai";
            txtJamSelesai.Width = 150;
            // 
            // txtKelasID
            // 
            txtKelasID.HeaderText = "Kelas ID";
            txtKelasID.MinimumWidth = 8;
            txtKelasID.Name = "txtKelasID";
            txtKelasID.Width = 150;
            // 
            // txtPengajarID
            // 
            txtPengajarID.HeaderText = "Pengajar ID";
            txtPengajarID.MinimumWidth = 8;
            txtPengajarID.Name = "txtPengajarID";
            txtPengajarID.Width = 150;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Lime;
            btnTambah.Location = new Point(139, 575);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Cyan;
            btnEdit.Location = new Point(139, 637);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Location = new Point(139, 694);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // dateTimePickerMulai
            // 
            dateTimePickerMulai.CustomFormat = "HH:mm";
            dateTimePickerMulai.Format = DateTimePickerFormat.Custom;
            dateTimePickerMulai.Location = new Point(309, 222);
            dateTimePickerMulai.Name = "dateTimePickerMulai";
            dateTimePickerMulai.Size = new Size(142, 31);
            dateTimePickerMulai.TabIndex = 6;
            // 
            // dateTimePickerSelesai
            // 
            dateTimePickerSelesai.CustomFormat = "HH:mm";
            dateTimePickerSelesai.Format = DateTimePickerFormat.Custom;
            dateTimePickerSelesai.Location = new Point(457, 222);
            dateTimePickerSelesai.Name = "dateTimePickerSelesai";
            dateTimePickerSelesai.Size = new Size(148, 31);
            dateTimePickerSelesai.TabIndex = 7;
            // 
            // cmbHari
            // 
            cmbHari.FormattingEnabled = true;
            cmbHari.Items.AddRange(new object[] { "Senin", "Selasa", "Rabu", "Kamis", "Jum at", "Sabtu", "Minggu" });
            cmbHari.Location = new Point(152, 220);
            cmbHari.Name = "cmbHari";
            cmbHari.Size = new Size(151, 33);
            cmbHari.TabIndex = 8;
            // 
            // cmbKelas
            // 
            cmbKelas.FormattingEnabled = true;
            cmbKelas.Location = new Point(597, 220);
            cmbKelas.Name = "cmbKelas";
            cmbKelas.Size = new Size(158, 33);
            cmbKelas.TabIndex = 9;
            cmbKelas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbPengajar
            // 
            cmbPengajar.FormattingEnabled = true;
            cmbPengajar.Location = new Point(750, 220);
            cmbPengajar.Name = "cmbPengajar";
            cmbPengajar.Size = new Size(156, 33);
            cmbPengajar.TabIndex = 10;
            // 
            // UCJadwalStaf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbPengajar);
            Controls.Add(cmbKelas);
            Controls.Add(cmbHari);
            Controls.Add(dateTimePickerSelesai);
            Controls.Add(dateTimePickerMulai);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(dgvJadwal);
            Controls.Add(lblNamaLengkap);
            Controls.Add(lblUsername);
            Name = "UCJadwalStaf";
            Size = new Size(1073, 750);
            Load += UCJadwalStaf_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void UCJadwalStaf_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label lblUsername;
        private Label lblNamaLengkap;
        private DataGridView dgvJadwal;
        private DataGridViewTextBoxColumn txtHari;
        private DataGridViewTextBoxColumn txtJamMulai;
        private DataGridViewTextBoxColumn txtJamSelesai;
        private DataGridViewTextBoxColumn txtKelasID;
        private DataGridViewTextBoxColumn txtPengajarID;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private DateTimePicker dateTimePickerMulai;
        private DateTimePicker dateTimePickerSelesai;
        private ComboBox cmbHari;
        private ComboBox cmbKelas;
        private ComboBox cmbPengajar;
    }
}
