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
    public partial class UCJadwalPengajar : UserControl
    {
        private User user;

        public UCJadwalPengajar(User u)
        {
            InitializeComponent();
            this.user = u;

            lblNamaLengkap.Text = user.NamaLengkap; // Contoh isi data
            lblUsername.Text = user.Username;
        }



        private void UCJadwalPengajar_Load(object sender, EventArgs e)
        {

        }
    }
}
