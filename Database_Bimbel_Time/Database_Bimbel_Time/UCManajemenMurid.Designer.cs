namespace Database_Bimbel_Time
{
    partial class UCManajemenMurid
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
            dgvMurid = new DataGridView();
            txtNamaLengkap = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            dtpTanggalLahir = new DateTimePicker();
            txtAlamat = new TextBox();
            btnTambah = new Button();
            btnHapus = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMurid).BeginInit();
            SuspendLayout();
            // 
            // dgvMurid
            // 
            dgvMurid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMurid.Location = new Point(158, 67);
            dgvMurid.Name = "dgvMurid";
            dgvMurid.RowHeadersWidth = 62;
            dgvMurid.Size = new Size(775, 553);
            dgvMurid.TabIndex = 0;
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Location = new Point(360, 146);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(150, 31);
            txtNamaLengkap.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(360, 230);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(360, 318);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 3;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(360, 487);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(300, 31);
            dtpTanggalLahir.TabIndex = 4;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(360, 403);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(150, 31);
            txtAlamat.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ActiveCaption;
            btnTambah.Location = new Point(360, 538);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Location = new Point(548, 538);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "button2";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 146);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 8;
            label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 230);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 318);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 403);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 11;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 487);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 12;
            label5.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 82);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 13;
            label6.Text = "Pendaftaran Murid";
            // 
            // UCManajemenMurid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHapus);
            Controls.Add(btnTambah);
            Controls.Add(txtAlamat);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtNamaLengkap);
            Controls.Add(dgvMurid);
            Name = "UCManajemenMurid";
            Size = new Size(1022, 755);
            ((System.ComponentModel.ISupportInitialize)dgvMurid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMurid;
        private TextBox txtNamaLengkap;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private DateTimePicker dtpTanggalLahir;
        private TextBox txtAlamat;
        private Button btnTambah;
        private Button btnHapus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
