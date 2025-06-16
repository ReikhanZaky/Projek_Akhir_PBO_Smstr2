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
    public partial class FormStaf : Form
    {
        private User user;

        public FormStaf(User u)
        {
            InitializeComponent();
            this.user = u;
            this.Load += FormStaf_Load;
        }

        private void FormStaf_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Selamat datang, " + user.NamaLengkap;
            LoadSemuaJadwal(); // staf bisa lihat semua
        }

        private void TampilkanKonten(UserControl uc)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }



        private void LoadSemuaJadwal()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=Cdaaptnia123;Database=database_bimbel";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                SELECT j.Hari, j.JamMulai, j.JamSelesai, k.NamaKelas, p.NamaLengkap AS Pengajar
                FROM Jadwal j
                JOIN Kelas k ON j.KelasID = k.KelasID
                JOIN Pengajar p ON k.PengajarID = p.PengajarID";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        dgvJadwal.DataSource = dt; // pastikan dgvJadwal ada di form staf
                    }
                }
            }
        }

        private void FormStaf_Load_1(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            TampilkanKonten(new UCJadwalStaf(user));
        }

        private void btnManajemenMurid_Click(object sender, EventArgs e)
        {
            TampilkanKonten(new UCManajemenMurid());
        }

    }


}
