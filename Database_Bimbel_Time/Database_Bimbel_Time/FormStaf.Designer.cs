
namespace Database_Bimbel_Time
{
    partial class FormStaf
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
            btnManajemenMurid = new Button();
            btnKembali = new Button();
            btnProfil = new Button();
            panelMain = new Panel();
            dgvJadwal = new DataGridView();
            panel1.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(48, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(85, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnJadwal);
            panel1.Controls.Add(btnManajemenMurid);
            panel1.Controls.Add(btnKembali);
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 753);
            panel1.TabIndex = 1;
            // 
            // btnJadwal
            // 
            btnJadwal.Location = new Point(48, 276);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(112, 34);
            btnJadwal.TabIndex = 4;
            btnJadwal.Text = "button1";
            btnJadwal.UseVisualStyleBackColor = true;
            btnJadwal.Click += btnJadwal_Click;
            // 
            // btnManajemenMurid
            // 
            btnManajemenMurid.Location = new Point(48, 217);
            btnManajemenMurid.Name = "btnManajemenMurid";
            btnManajemenMurid.Size = new Size(112, 34);
            btnManajemenMurid.TabIndex = 3;
            btnManajemenMurid.Text = "button1";
            btnManajemenMurid.UseVisualStyleBackColor = true;
            btnManajemenMurid.Click += btnManajemenMurid_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(48, 341);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "button2";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.Location = new Point(48, 148);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(112, 34);
            btnProfil.TabIndex = 1;
            btnProfil.Text = "button1";
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvJadwal);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(954, 753);
            panelMain.TabIndex = 2;
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(118, 148);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 62;
            dgvJadwal.Size = new Size(722, 405);
            dgvJadwal.TabIndex = 0;
            // 
            // FormStaf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 753);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "FormStaf";
            Text = "FormStaf";
            Load += FormStaf_Load_1;
            Click += FormStaf_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ResumeLayout(false);
        }

        private void FormStaf_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblWelcome;
        private Panel panel1;
        private Button btnKembali;
        private Button btnProfil;
        private Button btnManajemenMurid;
        private DataGridView dgvJadwal;
        private Button btnJadwal;
        protected Panel panelMain;
    }
}