using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Bimbel_Time
{
    public partial class UCManajemenMurid : UserControl
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=Cdaaptnia123;Database=bimbel_time";

        public UCManajemenMurid()
        {
            InitializeComponent();
            
        }

       
        private void LoadMurid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT u.UserID, u.Username, u.NamaLengkap, m.TanggalLahir, m.Alamat
                    FROM UserAccount u
                    JOIN Murid m ON u.UserID = m.UserID";

                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMurid.DataSource = dt;
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string queryUser = @"INSERT INTO UserAccount (Username, Password, NamaLengkap, Role)
                                     VALUES (@username, @password, @nama, 'Murid') RETURNING UserID";

                int newUserId = 0;

                using (var cmd = new NpgsqlCommand(queryUser, conn))
                {
                    cmd.Parameters.AddWithValue("username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("nama", txtNamaLengkap.Text);

                    newUserId = (int)cmd.ExecuteScalar(); // ambil UserID baru
                }

                string queryMurid = @"INSERT INTO Murid (UserID, TanggalLahir, Alamat)
                                      VALUES (@userId, @tgl, @alamat)";

                using (var cmd = new NpgsqlCommand(queryMurid, conn))
                {
                    cmd.Parameters.AddWithValue("userId", newUserId);
                    cmd.Parameters.AddWithValue("tgl", dtpTanggalLahir.Value.Date);
                    cmd.Parameters.AddWithValue("alamat", txtAlamat.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Murid berhasil ditambahkan!");
                LoadMurid();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvMurid.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvMurid.SelectedRows[0].Cells["UserID"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Hapus dari tabel Murid
                    string queryDeleteMurid = "DELETE FROM Murid WHERE UserID = @userId";
                    using (var cmd = new NpgsqlCommand(queryDeleteMurid, conn))
                    {
                        cmd.Parameters.AddWithValue("userId", userId);
                        cmd.ExecuteNonQuery();
                    }

                    // Hapus dari tabel UserAccount
                    string queryDeleteUser = "DELETE FROM UserAccount WHERE UserID = @userId";
                    using (var cmd = new NpgsqlCommand(queryDeleteUser, conn))
                    {
                        cmd.Parameters.AddWithValue("userId", userId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Murid berhasil dihapus!");
                    LoadMurid();
                }
            }
            else
            {
                MessageBox.Show("Pilih murid dulu untuk dihapus.");
            }
        }
    }
}

