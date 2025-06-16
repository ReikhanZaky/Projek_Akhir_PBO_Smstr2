using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Database_Bimbel_Time
{
    public partial class FormPengajar : Form
    {
        private User user;

        public FormPengajar(User u)
        {
            InitializeComponent();
            this.user = u;
            this.Load += FormPengajar_Load;
        }

        private void FormPengajar_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Halo, " + user.NamaLengkap;
            LoadJadwal(); // langsung load jadwal
        }

        private void TampilkanKonten(UserControl uc)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }


        private void LoadJadwal()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=Cdaaptnia123;Database=database_bimbel";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                SELECT j.Hari, j.JamMulai, j.JamSelesai, k.NamaKelas
                FROM Jadwal j
                JOIN Kelas k ON j.KelasID = k.KelasID
                JOIN Pengajar p ON k.PengajarID = p.PengajarID
                WHERE p.UserID = @userId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("userId", user.UserID);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        
                        dgvJadwal.DataSource = dt; // pastikan dgvJadwal ada di form
                    }
                }
            }
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            TampilkanKonten(new UCProfilPengajar(user)); // atau UCProfilPengajar, tergantung form
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            TampilkanKonten(new UCJadwalPengajar(user));
        }

    }

}



