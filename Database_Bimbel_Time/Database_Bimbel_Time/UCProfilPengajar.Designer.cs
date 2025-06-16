namespace Database_Bimbel_Time
{
    partial class UCProfilPengajar
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
            lblNamaLengkap = new Label();
            lblUsername = new Label();
            txtNamaLengkap = new TextBox();
            txtPassword = new TextBox();
            txtAlamat = new TextBox();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Location = new Point(96, 121);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(154, 25);
            lblNamaLengkap.TabIndex = 0;
            lblNamaLengkap.Text = "Tes Profil Pengajar";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(594, 121);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Location = new Point(96, 213);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(150, 31);
            txtNamaLengkap.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 308);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 4;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(96, 414);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(150, 31);
            txtAlamat.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(255, 470);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // UCProfilPengajar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSimpan);
            Controls.Add(txtAlamat);
            Controls.Add(txtPassword);
            Controls.Add(txtNamaLengkap);
            Controls.Add(lblUsername);
            Controls.Add(lblNamaLengkap);
            Name = "UCProfilPengajar";
            Size = new Size(902, 647);
            Load += UCProfilPengajar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaLengkap;
        private Label lblUsername;
        private TextBox txtNamaLengkap;
        private TextBox txtPassword;
        private TextBox txtAlamat;
        private Button btnSimpan;
    }
}
