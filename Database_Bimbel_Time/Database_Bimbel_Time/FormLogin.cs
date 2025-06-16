using Npgsql;
using System;
using System;
using System.Data;
using System.Windows.Forms;

namespace Database_Bimbel_Time
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=Cdaaptnia123;Database=database_bimbel";

            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM UserAccount WHERE Username=@username AND Password=@password";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("password", txtPassword.Text.Trim());

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                int userId = Convert.ToInt32(reader["UserID"]);
                                string nama = reader["NamaLengkap"].ToString();

                                User user = new User
                                {
                                    UserID = userId,
                                    Username = txtUsername.Text,
                                    Password = txtPassword.Text,
                                    Role = role,
                                    NamaLengkap = nama
                                };

                                if (role == "Murid")
                                {
                                    new FormMurid(user).Show();
                                }
                                else if (role == "Pengajar")
                                {
                                    new FormPengajar(user).Show();
                                }
                                else if (role == "Staf")
                                {
                                    new FormStaf(user).Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username atau password salah!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi gagal: " + ex.Message);
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
