namespace Database_Bimbel_Time
{
    partial class FormMurid
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
            lblWelcome.Location = new Point(55, 74);
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
            panel1.Size = new Size(192, 882);
            panel1.TabIndex = 1;
            // 
            // btnJadwal
            // 
            btnJadwal.Location = new Point(28, 255);
            btnJadwal.Name = "btnJadwal";
            btnJadwal.Size = new Size(112, 34);
            btnJadwal.TabIndex = 4;
            btnJadwal.Text = "button1";
            btnJadwal.UseVisualStyleBackColor = true;
            btnJadwal.Click += btnJadwal_Click;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(28, 327);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 38);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "button2";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.Location = new Point(28, 185);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(112, 34);
            btnProfil.TabIndex = 2;
            btnProfil.Text = "button1";
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dgvJadwal);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(192, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1176, 882);
            panelMain.TabIndex = 2;
            // 
            // dgvJadwal
            // 
            dgvJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwal.Location = new Point(202, 74);
            dgvJadwal.Name = "dgvJadwal";
            dgvJadwal.RowHeadersWidth = 62;
            dgvJadwal.Size = new Size(753, 604);
            dgvJadwal.TabIndex = 0;
            // 
            // FormMurid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 882);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "FormMurid";
            Text = "FormMurid";
            Load += FormMurid_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJadwal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Panel panel1;
        private Button btnProfil;
        private Button btnKembali;
        private DataGridView dgvJadwal;
        private Button btnJadwal;
        protected Panel panelMain;
    }
}