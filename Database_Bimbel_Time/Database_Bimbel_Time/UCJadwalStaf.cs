using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Database_Bimbel_Time
{
    public partial class UCJadwalStaf : UserControl
    {

        private int selectedJadwalId = -1;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=Cdaaptnia123;Database=database_bimbel";


        private User user;

        public UCJadwalStaf(User u)
        {
            InitializeComponent();
            this.user = u;

            LoadKelas();

            lblNamaLengkap.Text = user.NamaLengkap; // Contoh isi data
            lblUsername.Text = user.Username;
        }


        private void LoadJadwal()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM Jadwal";
                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvJadwal.DataSource = dt;
                }
            }
        }


        private void dgvJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvJadwal.Rows[e.RowIndex];
                selectedJadwalId = Convert.ToInt32(row.Cells["JadwalID"].Value);
                txtHari.HeaderText = row.Cells["Hari"].Value.ToString();
                txtJamMulai.HeaderText = row.Cells["JamMulai"].Value.ToString();
                txtJamSelesai.HeaderText = row.Cells["JamSelesai"].Value.ToString();
                txtKelasID.HeaderText = row.Cells["KelasID"].Value.ToString();
                txtPengajarID.HeaderText = row.Cells["PengajarID"].Value.ToString();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO Jadwal (Hari, JamMulai, JamSelesai, KelasID, PengajarID) VALUES (@hari, @mulai, @selesai, @kelasId, @pengajarId)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {   // Ambil data dari form
                    string hari = cmbHari.Text;
                    TimeSpan jamMulai = dateTimePickerMulai.Value.TimeOfDay;
                    TimeSpan jamSelesai = dateTimePickerSelesai.Value.TimeOfDay;

                    cmd.Parameters.AddWithValue("hari", txtHari.HeaderText);


                    
                   
                   

                }
            }

            LoadJadwal(); // refresh
            MessageBox.Show("Jadwal berhasil ditambahkan!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedJadwalId == -1)
            {
                MessageBox.Show("Pilih jadwal yang akan diedit!");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"UPDATE Jadwal SET Hari = @hari, JamMulai = @mulai, JamSelesai = @selesai, 
                         KelasID = @kelasId, PengajarID = @pengajarId WHERE JadwalID = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("hari", txtHari.HeaderText);
                    cmd.Parameters.AddWithValue("mulai", TimeSpan.Parse(txtJamMulai.HeaderText));
                    cmd.Parameters.AddWithValue("selesai", TimeSpan.Parse(txtJamSelesai.HeaderText));
                    cmd.Parameters.AddWithValue("kelasId", int.Parse(txtKelasID.HeaderText));
                    cmd.Parameters.AddWithValue("pengajarId", int.Parse(txtPengajarID.HeaderText));
                    cmd.Parameters.AddWithValue("id", selectedJadwalId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadJadwal();
            MessageBox.Show("Jadwal berhasil diperbarui!");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedJadwalId == -1)
            {
                MessageBox.Show("Pilih jadwal yang akan dihapus!");
                return;
            }

            var konfirmasi = MessageBox.Show("Yakin hapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM Jadwal WHERE JadwalID = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", selectedJadwalId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadJadwal();
                MessageBox.Show("Jadwal berhasil dihapus!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadKelas()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=Cdaaptnia123;Database=bimbel_time";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT KelasID, NamaKelas FROM Kelas";

                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbKelas.DataSource = dt;
                    cmbKelas.DisplayMember = "NamaKelas";
                    cmbKelas.ValueMember = "KelasID";
                }
            }
        }

    }
}
