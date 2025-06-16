namespace Database_Bimbel_Time
{
    partial class UCProfilStaf
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
            txtNamaLengkap = new TextBox();
            txtPassword = new TextBox();
            txtAlamat = new TextBox();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(108, 142);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(116, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tes Profil staf";
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Location = new Point(614, 142);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(91, 25);
            lblNamaLengkap.TabIndex = 1;
            lblNamaLengkap.Text = "Username";
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Location = new Point(108, 217);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(150, 31);
            txtNamaLengkap.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(108, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 5;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(108, 415);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(150, 31);
            txtAlamat.TabIndex = 6;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(272, 475);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // UCProfilStaf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSimpan);
            Controls.Add(txtAlamat);
            Controls.Add(txtPassword);
            Controls.Add(txtNamaLengkap);
            Controls.Add(lblNamaLengkap);
            Controls.Add(lblUsername);
            Name = "UCProfilStaf";
            Size = new Size(927, 626);
            Load += UCProfilStaf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblNamaLengkap;
        private TextBox txtNamaLengkap;
        private TextBox txtPassword;
        private TextBox txtAlamat;
        private Button btnSimpan;
    }
}
