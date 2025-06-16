namespace Database_Bimbel_Time
{
    partial class FormPengajar
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
            lblWelcome = new Label();
            panel1 = new Panel();
            btnJadwal = new Button();
            btnKembali = new Button();
            btnProfil = new Button();
            dgvJadwal = new DataGridView();
            panelMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(47, 100);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(85, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnJadwal);
            panel1.Controls.Add(btnKembali);
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 754);
            panel1.TabIndex = 1;
            // 
            // btnJadwal
            // 
            btnJadwal.Location = new Point(47, 256);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(112, 34);
            btnJadwal.TabIndex = 3;
            btnJadwal.Text = "button1";
            btnJadwal.UseVisualStyleBackColor = true;
            btnJadwal.Click += btnJadwal_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(47, 317);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "button2";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.Location = new Point(47, 194);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(112, 34);
            btnProfil.TabIndex = 1;
            btnProfil.Text = "button1";
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(299, 194);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 62;
            dgvJadwal.Size = new Size(505, 335);
            dgvJadwal.TabIndex = 2;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvJadwal);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1074, 754);
            panelMain.TabIndex = 3;
            // 
            // FormPengajar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 754);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "FormPengajar";
            Text = "FormPengajar";
            Load += FormPengajar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Panel panel1;
        private Button btnKembali;
        private Button btnProfil;
        private DataGridView dgvJadwal;
        private Button btnJadwal;
        protected Panel panelMain;
    }
}