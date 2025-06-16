namespace Database_Bimbel_Time
{
    partial class UCJadwalMurid
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNamaLengkap
            // 
            lblNamaLengkap.AutoSize = true;
            lblNamaLengkap.Location = new Point(408, 79);
            lblNamaLengkap.Name = "lblNamaLengkap";
            lblNamaLengkap.Size = new Size(131, 25);
            lblNamaLengkap.TabIndex = 0;
            lblNamaLengkap.Text = "Nama Lengkap";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(408, 137);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(229, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(564, 318);
            dataGridView1.TabIndex = 2;
            // 
            // UCJadwalMurid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(lblUsername);
            Controls.Add(lblNamaLengkap);
            Name = "UCJadwalMurid";
            Size = new Size(1044, 712);
            Load += UCJadwalMurid_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaLengkap;
        private Label lblUsername;
        private DataGridView dataGridView1;
    }
}
