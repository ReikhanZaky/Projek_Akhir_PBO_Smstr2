namespace Database_Bimbel_Time
{
    partial class UCJadwalPengajar
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(372, 131);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Location = new Point(372, 80);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(131, 25);
            lblNamaLengkap.TabIndex = 1;
            lblNamaLengkap.Text = "Nama Lengkap";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(542, 238);
            dataGridView1.TabIndex = 2;
            // 
            // UCJadwalPengajar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(lblNamaLengkap);
            Controls.Add(lblUsername);
            Name = "UCJadwalPengajar";
            Size = new Size(981, 648);
            Load += UCJadwalPengajar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblNamaLengkap;
        private DataGridView dataGridView1;
    }
}
