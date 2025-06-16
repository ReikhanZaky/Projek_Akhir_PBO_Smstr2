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
    public partial class UCProfilMurid : UserControl
    {
        private User user;

        public UCProfilMurid(User u)
        {
            InitializeComponent();
            this.user = u;

            lblNamaLengkap.Text = user.NamaLengkap; 
            lblUsername.Text = user.Username;
        }



        private void UCProfilMurid_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=Cdaaptnia123;Database=database_bimbel";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Update ke UserAccount dan Murid
                string updateUser = "UPDATE UserAccount SET NamaLengkap = @nama, Password = @password WHERE UserID = @id";
                string updateMurid = "UPDATE Murid SET Alamat = @alamat WHERE UserID = @id";

                using (var cmd1 = new NpgsqlCommand(updateUser, conn))
                {
                    cmd1.Parameters.AddWithValue("nama", txtNamaLengkap.Text);
                    cmd1.Parameters.AddWithValue("password", txtPassword.Text);
                    cmd1.Parameters.AddWithValue("id", user.UserID);
                    cmd1.ExecuteNonQuery();
                }

                using (var cmd2 = new NpgsqlCommand(updateMurid, conn))
                {
                    cmd2.Parameters.AddWithValue("alamat", txtAlamat.Text);
                    cmd2.Parameters.AddWithValue("id", user.UserID);
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Profil berhasil diperbarui!");
            }
        }

    }
}
